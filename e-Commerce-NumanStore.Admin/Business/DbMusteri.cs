using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace admin2
{
    public class DbMusteri
    {
        public SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["ButgemWebConnectionString1"].ConnectionString);
        public DbMusteri()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void ac()
        {
            baglanti.Open();
        }
        public void kapat()
        {
            baglanti.Close();
        }
    }


}
