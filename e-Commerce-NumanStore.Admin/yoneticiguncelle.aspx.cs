using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class yoneticiguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int kaysay;
            if (Request.QueryString["gun"] == null)
            {
                DataTable tablo = new DataTable();
                YoneticiCRUD listele = new YoneticiCRUD();
                tablo = listele.tumliste();
                kaysay = tablo.Rows.Count;
                tbl.InnerHtml = "<table class='table table-bordered' border=1 style='margin:30px' width:100,height:100>";
                tbl.InnerHtml += "<tr><td>AD Soyad</td><td>Mail</td><td>Kullanıcı Adı</td><td>Şifre</td> <td>Resim</td><td>Güncelle</td></tr>";

                for (int i = 0; i < kaysay; i++)
                {
                    tbl.InnerHtml += $"<tr><td>{tablo.Rows[i][0]}</td><td>{tablo.Rows[i][1]}</td><td>{tablo.Rows[i][2]}</td> <td>{tablo.Rows[i][3]}</td>  <td><img src='{tablo.Rows[i][4]}'height='60' width='60'>  </td> <td> <a href='yoneticiguncelle.aspx?gun={tablo.Rows[i][1]}'><img src='/images/update.png' height='60' width='60' ></a  </td> </tr>";
                }
                tbl.InnerHtml += "</table>";
            }
            else
            {
                if (!IsPostBack)
                {
                    string gun = Request.QueryString["gun"].ToString();
                    Yonetici yoneticiguncelle = new Yonetici();
                    YoneticiCRUD yoneticiCRUD1 = new YoneticiCRUD();
                    yoneticiguncelle = yoneticiCRUD1.getir(gun);
                    PnlGuncelle.Visible = true;
                    TextBox1.Text = yoneticiguncelle.Adsoyad;
                    TextBox3.Text = yoneticiguncelle.Kadi;
                    TextBox4.Text = yoneticiguncelle.Sfr;
                    TextBox5.Text = yoneticiguncelle.Sfr;
                    Image1.ImageUrl = yoneticiguncelle.Resim;

                }








            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gun = Request.QueryString["gun"].ToString();
            bool cevap;
            YoneticiCRUD yoneticiCrud = new YoneticiCRUD();
            Yonetici yyonetici = new Yonetici();
            yyonetici.Adsoyad = TextBox1.Text;
            yyonetici.Kadi = TextBox3.Text;
            yyonetici.Sfr = TextBox4.Text;
            yyonetici.Sfr = TextBox5.Text;
            yyonetici.Resim = Image1.ImageUrl;
            cevap = yoneticiCrud.guncelleme(gun, yyonetici);
            if (cevap)
            {
                //Response.Write("<script>alert('Güncelleme İşlemi Yapıldı');</script>");
                //Response.Redirect("yoneticiguncelle.aspx");
                BasariliAnimasyon.Value = "1";
            }


           
        }
    }
    }
