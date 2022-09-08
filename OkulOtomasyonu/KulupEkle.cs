using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu
{
    public class KulupEkle
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7ROAQ7M\SQLEXPRESS;Initial Catalog=OkulOtomasyonuu;Integrated Security=True");

        public void ekle(string ad)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKULUPLER (KULUPAD) VALUES (@P1)", baglanti);
            komut.Parameters.AddWithValue("@p1", ad);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
