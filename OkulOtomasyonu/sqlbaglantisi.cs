using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-7ROAQ7M\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();

            return baglan;
        }
    }
}