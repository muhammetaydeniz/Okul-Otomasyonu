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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKULUPLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7ROAQ7M\SQLEXPRESS;Initial Catalog=OkulOtomasyonuu;Integrated Security=True");
        private void FrmKulup_Load(object sender, EventArgs e)
        {
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


            label5.Text = "KULÜP ID";
            label5.Font = new Font("Times New Roman", 8);


            label6.Text = "KULÜP ADI";
            label6.Font = new Font("Times New Roman", 8);

            label7.Text = "KULÜP İŞLEMLERİ PANELİ";
            label7.Font = new Font("Times New Roman", 16);

            pictureBox5.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\geri.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\cıkıs.png");
            /**********************************************************************************************************/
            liste();
        

        }

    
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

     

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKULUPLER (KULUPAD) VALUES (@P1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();*/
            KulupEkle insert = new KulupEkle();
            insert.ekle(txtKulupAd.Text);
            MessageBox.Show("Kulüpler Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLKULUPLER Where KULUPID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Silme İşlemi Gerçekleşti");
            liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLKULUPLER SET KULUPAD=@P1 WHERE KULUPID=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", txtKulupAd.Text);
            komut.Parameters.AddWithValue("@P2", txtKulupId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Güncelleme İşlemi Gerçekleşti");
            liste();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
