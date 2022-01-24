using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class musteriguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int kaysay;
            if (Request.QueryString["gun"] == null)
            {
                DataTable tablo = new DataTable();
                MusteriCRUD listele = new MusteriCRUD();
                tablo = listele.tumlistemm();
                kaysay = tablo.Rows.Count;
                tbl.InnerHtml = "<table class='table table-bordered' border=1 style='margin:30px' width:50,height:50>";
                tbl.InnerHtml += "<tr><td>AD Soyad</td><td>TC.NO</td><td>Meslek</td><td>Telefon</td> <td>Adres</td> <td>Şehir</td> <td>E-Maill</td><td>Ülke</td>  <td>Güncelle</td></tr>";

                for (int i = 0; i < kaysay; i++)
                {
                    tbl.InnerHtml += $"<tr><td>{tablo.Rows[i][0]}</td><td>{tablo.Rows[i][1]}</td><td>{tablo.Rows[i][2]}</td> <td>{tablo.Rows[i][3]}</td>  <td>{tablo.Rows[i][4]}</td><td>{tablo.Rows[i][5]}</td>  <td>{tablo.Rows[i][6]}</td> <td>{tablo.Rows[i][7]}</td> <td> <a href='Musteriguncelle.aspx?gun={tablo.Rows[i][1]}'><img src='/images/update.png' height='60' width='60' ></a  </td> </tr>";
                }
                tbl.InnerHtml += "</table>";
            }
            else
            {
                if (!Page.IsPostBack)
                {
                    string gun = Request.QueryString["gun"].ToString();
                    Musteri musteriguncelle = new Musteri();
                    MusteriCRUD musteriCRUD1 = new MusteriCRUD();
                    musteriguncelle = musteriCRUD1.getir(gun);
                    PnlGuncelle.Visible = true;
                    TextBox1.Text = musteriguncelle.Adsoyad;
                    TextBox7.Text = musteriguncelle.Mail;
                    TextBox3.Text = musteriguncelle.Meslek;
                    TextBox4.Text = musteriguncelle.Tel;
                    TextBox5.Text = musteriguncelle.Adres;
                    TextBox6.Text = musteriguncelle.Sehir;
                    TextBox8.Text = musteriguncelle.Ulke;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BasariliAnimasyon.Value = "0";
            string gun = Request.QueryString["gun"].ToString();
            bool cevap;
            MusteriCRUD musteriCrud = new MusteriCRUD();
            Musteri ymusteri = new Musteri();
            ymusteri.Adsoyad = TextBox1.Text;

            ymusteri.Meslek = TextBox3.Text;
            ymusteri.Tel = TextBox4.Text;
            ymusteri.Adres = TextBox5.Text;
            ymusteri.Sehir = TextBox6.Text;
            ymusteri.Mail = TextBox7.Text;
            ymusteri.Ulke = TextBox8.Text;
            cevap = musteriCrud.guncelleme(gun, ymusteri);
            if (cevap)
            {
                BasariliAnimasyon.Value = "1";
                //Response.Write("<script>alert('Güncelleme İşlemi Yapıldı');</script>");
                //Response.Redirect("yoneticiguncelle.aspx");
            }
        }

    }




}

