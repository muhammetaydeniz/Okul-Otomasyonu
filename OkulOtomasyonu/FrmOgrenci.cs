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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7ROAQ7M\SQLEXPRESS;Initial Catalog=OkulOtomasyonuu;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();




            radioButton1.Text = "KIZ";
            radioButton2.Text = "ERKEK";
            btnListele.Text = "LİSTELE";
            btnListele.Font = new Font("Times New Roman", 12);
            pictureBox1.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\listele.png");


            btnEkle.Text = "EKLE";
            btnEkle.Font = new Font("Times New Roman", 12);
            pictureBox2.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ekle.png");


            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.Font = new Font("Times New Roman", 12);
            pictureBox3.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\guncelle.png");


            btnSil.Text = "SİL";
            btnSil.Font = new Font("Times New Roman", 12);
            pictureBox4.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\sil.png");


            btnAra.Text = "ARA";
            btnAra.Font = new Font("Times New Roman", 12);
            pictureBox7.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ara.png");

            lblOgrSoyad.Text = "SOYADI:";
            lblOgrSoyad.Font = new Font("Times New Roman", 10);

            lblOgrKulup.Text = "KULÜBÜ:";
            lblOgrKulup.Font = new Font("Times New Roman", 10);

            lblOgrCinsiyet.Text = "CİNSİYET:";
            lblOgrCinsiyet.Font = new Font("Times New Roman", 10);


            lblOgrId.Text = "ÖĞRENCİ ID:";
            lblOgrId.Font = new Font("Times New Roman", 10);


            lblOgrAd.Text = "ADI:";
            lblOgrAd.Font = new Font("Times New Roman", 10);

            label7.Text = "ÖĞRENCİ İŞLEMLERİ PANELİ";
            label7.Font = new Font("Times New Roman", 16);

            pictureBox5.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\geri.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\cıkıs.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        string c = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
          
           
            ds.OgrenciEkle(txtAD.Text, txtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme Yapıldı");
        }

        private void txtAd_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            MessageBox.Show("Listelendi");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDersId.Text = comboBox1.SelectedValue.ToString(); // Combobax dan kulup seçtiğimiz gibi otomatik ID sini yazdırıyor
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtID.Text));
            MessageBox.Show("Silme İşleminiz Gerçekleşti");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()=="KIZ")
            {
                radioButton1.Checked = true;

            }
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "ERKEK")
            {
                radioButton2.Checked = true;
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtAD.Text, txtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c,int.Parse( txtID.Text));
            MessageBox.Show("Güncelleme İşlemi Yapıldı");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "KIZ";
            }
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        
            if (radioButton2.Checked == true)
            {
                c = "ERKEK";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ds.OgrenciGetir(txtAra.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}