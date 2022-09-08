using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            btnDersİslemleri.Text = "DERS İŞLEMLERİ";
            btnDersİslemleri.Font = new Font("Times New Roman", 12);
            pictureBox1.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\derssecimi.png");
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnKulupİslemleri.Text = "KULÜP İŞLEMLERİ";
            btnKulupİslemleri.Font = new Font("Times New Roman", 12);
            pictureBox2.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\hobi.png");

            btnSinavNotları.Text = "SINAV NOTLARI";
            btnSinavNotları.Font = new Font("Times New Roman", 12);
            pictureBox3.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\notlar.png");

            btnOgretmenler.Text = "ÖĞRETMENLER";
            btnOgretmenler.Font = new Font("Times New Roman", 12);
            pictureBox4.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ogretmen2.png");

            btnOgrenciİslemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            btnOgrenciİslemleri.Font = new Font("Times New Roman", 12);
            pictureBox5.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ogrenci2.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\geri.png");







        }

        private void btnKulupİslemleri_Click(object sender, EventArgs e)
        {
            FrmKulup fr = new FrmKulup();
            fr.Show();
        }

        private void btnDersİslemleri_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
        }

        private void btnOgrenciİslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSinavNotları_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr = new FrmSinavNotlar();
            fr.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
