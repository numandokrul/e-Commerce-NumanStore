using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class urunsil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string barkod;
            bool durum;
            int kaysay;
            UrunCRUD yonet = new UrunCRUD();
            DataTable gtablo = new DataTable();

            barkod = Request.QueryString["prm"];
            if (barkod != null)
            {
                durum = yonet.Sil(barkod);
                if (durum)


                    //Response.Write("<script>alert('Kaydınız Silindi');</script>");
                    BasariliAnimasyon.Value = "1";

                else
                    //Response.Write("<script>alert('Kayıt Silme Hatası');</script>");
                    BasariliAnimasyon.Value = "2";

            }


            gtablo = yonet.tumliste();
            kaysay = gtablo.Rows.Count;


            sil.InnerHtml = "<table class='table table-bordered' id='dataTable' width='100 % ' cellspacing='0' border='1'><tr><td>SIRA NO</td><td>Kategori</td><td>Marka</td><td>Ürün Adı</td><td>Fiyat</td><td>Stok Kodu</td><td>Barkod No</td><td>Resim</td><td>Sil</td></tr>";

            for (int i = 0; i < kaysay; i++)
            {
                sil.InnerHtml += "<tr><td>" + (i + 1) + "</td><td>" + gtablo.Rows[i][0] + "</td><td>" + gtablo.Rows[i][1] + "</td><td>" + gtablo.Rows[i][2] + "</td><td>"+ gtablo.Rows[i][3] + "</td><td>"+ gtablo.Rows[i][6] + "</td><td>" + gtablo.Rows[i][7] + "</td><td><img src='" + gtablo.Rows[i][10] + "' height='80' width='80'></td><td><a href='urunsil.aspx?prm=" + gtablo.Rows[i][7] + "'><img src='images/sil.png' width='35' height='35'</a></td></tr>";


            }


            sil.InnerHtml += "</table>";

        }

    }
    }
