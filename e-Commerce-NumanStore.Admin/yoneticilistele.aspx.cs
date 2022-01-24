using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class yoneticilistele : System.Web.UI.Page
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

            YoneticiCRUD yonet = new YoneticiCRUD();
            DataTable gtablo = new DataTable();

            gtablo = yonet.tumliste();
            kaysay = gtablo.Rows.Count;
            kacar = 3;

            liste.InnerHtml = "<table class='table table-bordered' width='100 % ' cellspacing='0' border='1'><tr><td>SIRA NO</td><td>AD Soyad</td><td>Mail</td><td>Kullanıcı Adı</td><td>Resim</td></tr>";
            for (int i = (sno * kacar) - kacar; i < sno * kacar; i++)
            {
                liste.InnerHtml += $"<tr><td>{i + 1}</td><td>{gtablo.Rows[i][0]}</td><td>{gtablo.Rows[i][1]}</td><td>{gtablo.Rows[i][2]}</td><td><img src='{gtablo.Rows[i][4]}' height='70' width='70'</td></tr>";
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
                liste.InnerHtml += " <a href='yoneticilistele.aspx?sno=" + i + "'>" + i + "</a>- ";
            }
        }
            
        }
    }
