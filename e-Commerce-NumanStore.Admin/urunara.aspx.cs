using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class urunara : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int kaysay, kacar, sayfasay, sskaysay;

            int sno = Convert.ToInt16(Request.QueryString["sno"]);
            if ((sno == 0) || (Convert.ToInt16(Session["sec"]) == 1))
            {
                sno = 1;
                Session["sec"] = 0;
            }

            UrunCRUD urunyonet = new UrunCRUD();
            DataTable gtablo = new DataTable();

            gtablo = urunyonet.AramaSonuclariListe(Request.QueryString["q"]);
            kaysay = gtablo.Rows.Count;
            kacar = 3;

            liste.InnerHtml = "<table class='table table-bordered' width='100 % ' cellspacing='0' border='1'><tr><td>SIRA NO</td><td>Kategoriler</td><td>Marka</td><td>Ürün Adı</td><td>Fiyat</td><td>Para Birimi</td><td>Barkod Kodu</td> <td>Resim</td> <td>Tarih</td> <td>Detay</td> </tr>";
            for (int i = (sno * kacar) - kacar; i < sno * kacar; i++)
            {
                liste.InnerHtml += $"<tr><td>{i + 1}</td><td>{gtablo.Rows[i][0]}</td><td>{gtablo.Rows[i][1]}</td><td>{gtablo.Rows[i][2]}</td><td>{gtablo.Rows[i][3]}</td> <td>{gtablo.Rows[i][5]}</td> <td>{gtablo.Rows[i][6]}</td> <td><img src='{gtablo.Rows[i][10]}'height='70' width='70'  </td> <td>{gtablo.Rows[i][11]}</td> <td>{gtablo.Rows[i][12]}</td> </tr>";
                if (i == (kaysay - 1))
                {
                    break;
                }
            }


            liste.InnerHtml += "</table>";
            if (kaysay % kacar == 0)
            {
                sayfasay = kaysay / kacar;
            }
            else
            {
                sayfasay = (kaysay / kacar) + 1;
            }
            for (int i = 1; i <= sayfasay; i++)
            {
                liste.InnerHtml += " <a href='urunlistele.aspx?sno=" + i + "'>" + i + "</a>- ";
            }
        }

    }
    }
