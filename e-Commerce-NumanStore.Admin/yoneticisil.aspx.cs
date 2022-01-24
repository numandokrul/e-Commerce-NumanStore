using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class yoneticisil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email;
            bool durum;
            int kaysay;
            YoneticiCRUD yonet = new YoneticiCRUD();
            DataTable gtablo = new DataTable();

            email = Request.QueryString["prm"];
            if (email != null)
            {
                durum = yonet.sil(email);
                if (durum)


                    //Response.Write("<script>alert('Kaydınız Silindi');</script>");
                    BasariliAnimasyon.Value = "1";

                else
                    //Response.Write("<script>alert('Kayıt Silme Hatası');</script>");
                    BasariliAnimasyon.Value = "2";

            }


            gtablo = yonet.tumliste();
            kaysay = gtablo.Rows.Count;


            sil.InnerHtml = "<table class='table table-bordered' id='dataTable' width='100 % ' cellspacing='0' border='1'><tr><td>SIRA NO</td><td>AD Soyad</td><td>E Mail</td><td>Kullanıcı Adı</td><td>Resim</td><td>Sil</td></tr>";

            for (int i = 0; i < kaysay; i++)
            {
                sil.InnerHtml += "<tr><td>" + (i + 1) + "</td><td>" + gtablo.Rows[i][0] + "</td><td>" + gtablo.Rows[i][1] + "</td><td>" + gtablo.Rows[i][2] + "</td><td><img src='" + gtablo.Rows[i][4] + "' height='50' width='50'></td><td><a href='yoneticisil.aspx?prm=" + gtablo.Rows[i][1] + "'><img src='images/sil.png' width='45' height='45'</a></td></tr>";


            }


            sil.InnerHtml += "</table>";



        }
    }
}