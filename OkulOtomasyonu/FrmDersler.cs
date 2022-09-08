using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
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


            label5.Text = "DERS ID";
            label5.Font = new Font("Times New Roman", 8);


            label6.Text = "DERS ADI";
            label6.Font = new Font("Times New Roman", 8);

            label7.Text = "DERS İŞLEMLERİ PANELİ";
            label7.Font = new Font("Times New Roman", 16);

            pictureBox5.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\geri.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\cıkıs.png");
            
            
           
            dataGridView1.DataSource = ds.DersListesi();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
           
            
           
        } 

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAd.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtDersId.Text));
            MessageBox.Show("Ders Silme İşlemi Yapılmıştır");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtDersAd.Text, byte.Parse(txtDersId.Text));
            MessageBox.Show("Ders Güncellendi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
