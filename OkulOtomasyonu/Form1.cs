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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOgrenci.Text = "Öğrenci";
            lblOgrenci.Font = new Font("Times New Roman", 16);
            lblOgretmen.Text = "Öğretmen";
            lblOgretmen.Font = new Font("Times New Roman",16);
            lblNumara.Text = "Numara:";
            lblNumara.Font = new Font("Times New Roman", 16);
            pictureBox1.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ogrenci.png");
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\ogretmen.png");
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox6.Image = Image.FromFile("C:\\Users\\AYDENİZ\\Source\\Repos\\OkulOtomasyonu\\OkulOtomasyonu\\Content\\icons\\cıkıs.png");





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            ogrencisayfasi og = new ogrencisayfasi();
            og.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
