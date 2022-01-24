using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;//sql bağlantı için



namespace admin2
{
    public class Db
    {

        public SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["ButgemWebConnectionString1"].ConnectionString);
        public Db()
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