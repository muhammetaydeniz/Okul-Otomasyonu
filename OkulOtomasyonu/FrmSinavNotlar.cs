using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkulOtomasyonu
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7ROAQ7M\SQLEXPRESS;Initial Catalog=OkulOtomasyonuu;Integrated Security=True");

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DERSAD";
            comboBox1.ValueMember = "DERSID";
            comboBox1.DataSource = dt;
            baglanti.Close();



            lblDersId.Text = "ÖĞRENCİ ID:";
            lblDersId.Font = new Font("Times New Roman", 10);

            lblDers.Text = "DERS:";
            lblDers.Font = new Font("Times New Roman", 10);

            lblSınav1.Text = "SINAV1:";
            lblSınav1.Font = new Font("Times New Roman", 10);

            label1.Text = "SINAV2:";
            label1.Font = new Font("Times New Roman", 10);

            label2.Text = "SINAV3:";
            label2.Font = new Font("Times New Roman", 10);

            label3.Text = "PROJE:";
            label3.Font = new Font("Times New Roman", 10);

            label4.Text = "ORTALAMA:";
            label4.Font = new Font("Times New Roman", 10);

            label5.Text = "DURUM:";
            label5.Font = new Font("Times New Roman", 10);

            btnHesapla.Text = "HESAPLA";
            btnHesapla.Font = new Font("Times New Roman", 12);
            pictureBox1.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\hesapla.png");

            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.Font = new Font("Times New Roman", 12);
            pictureBox2.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\guncelle2.png");

            btnTemizle.Text = "TEMİZLE";
            btnTemizle.Font = new Font("Times New Roman", 12);
            pictureBox3.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\temizle.png");

            btnAra.Text = "ARA";
            btnAra.Font = new Font("Times New Roman", 12);
            pictureBox7.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ara.png");

            label7.Text = "NOT İŞLEMLERİ PANELİ";
            label7.Font = new Font("Times New Roman", 16);

            pictureBox5.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\geri.png");




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtID.Text));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
            //string durum;
            sinav1 = Convert.ToInt16(txtSınav1.Text);
            sinav2 = Convert.ToInt16(txtSınav2.Text);
            sinav3 = Convert.ToInt16(txtSınav3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            double ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();
           
            if (ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }

            MessageBox.Show("Hesaplama İşlemi Yapıldı");



        }

        private void txtOrtalama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
         
            ds.NotGuncelle(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtID.Text),byte.Parse(txtSınav1.Text), byte.Parse(txtSınav2.Text), byte.Parse(txtSınav3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtOrtalama.Text), bool.Parse(txtDurum.Text), notid);
            MessageBox.Show("Güncellendi");

        }
    }
}
