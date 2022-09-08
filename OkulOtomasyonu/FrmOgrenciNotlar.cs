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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7ROAQ7M\SQLEXPRESS;Initial Catalog=OkulOtomasyonuu;Integrated Security=True");
        public String numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            /*
            SqlCommand komut = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID WHERE OGRID = @P1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //  this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/
            Liste();
        }
        SqlDataAdapter da;
        public void Liste()
        {
            
            try
            {
                baglanti.Open();
                SqlCommand com = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID", baglanti);
                da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                com.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox boşken tm data listeleme kodu
            //arama butonu
            try
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter adap = new SqlDataAdapter("select*from TBLOGRENCILER where OGRID like'" + textBox1.Text + "%'", baglanti);
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception hata) { MessageBox.Show(hata.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }
    }
}
