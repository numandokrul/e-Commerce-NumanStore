using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class musterisil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tcno;
            bool durum;
            int kaysay;
            MusteriCRUD yonet = new MusteriCRUD();
            DataTable gtablo = new DataTable();

            tcno = Request.QueryString["prm"];
            if (tcno != null)
            {
                durum = yonet.sil(tcno);
                if (durum)


                    //Response.Write("<script>alert('Kaydınız Silindi');</script>");
                    BasariliAnimasyon.Value = "1";

                else
                    //Response.Write("<script>alert('Kayıt Silme Hatası');</script>");
                    BasariliAnimasyon.Value = "2";

            }


            gtablo = yonet.tumlistemm();
            kaysay = gtablo.Rows.Count;


            sil.InnerHtml = "<table class='table table-bordered' id='dataTable' width='100 % ' cellspacing='0' border='1'><tr><td>SIRA NO</td><td>AD Soyad</td><td>TC NO</td><td>Meslek</td><td>Telefon</td><td>Adres</td><td>Mail</td><td>Ülke</td><td>Sil</td></tr>";

            for (int i = 0; i < kaysay; i++)
            {
                sil.InnerHtml += "<tr><td>" + (i + 1) + "</td><td>" + gtablo.Rows[i][0] + "</td><td>" + gtablo.Rows[i][1] + "</td><td>" + gtablo.Rows[i][2] + "</td><td>" + gtablo.Rows[i][3] + "</td><td>" + gtablo.Rows[i][4] + "</td><td>" + gtablo.Rows[i][6] + "</td><td>" + gtablo.Rows[i][7] + "</td><td><a href='musterisil.aspx?prm=" + gtablo.Rows[i][1] + "'><img src='images/sil.png' width='35' height='35'</a></td></tr>";


            }


            sil.InnerHtml += "</table>";

        }


    }
}
