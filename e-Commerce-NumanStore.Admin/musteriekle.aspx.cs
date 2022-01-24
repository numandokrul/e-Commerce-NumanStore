using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class musteriekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Adsoyad = TextBox1.Text;
            musteri.Tcno = TextBox2.Text;
            musteri.Meslek = TextBox3.Text;
            musteri.Tel = TextBox4.Text;
            musteri.Adres = TextBox5.Text;
            musteri.Sehir = TextBox6.Text;
            musteri.Mail = TextBox7.Text;
            musteri.Ulke = TextBox8.Text;


            MusteriCRUD musteriCRUD = new MusteriCRUD();
            bool sonuc = musteriCRUD.kaydet(musteri);
            if (sonuc)
            {
                //Response.Write("<script>alert('Kaydınız Tamamlandı!');</script>");
                BasariliAnimasyon.Value = "1";
            }
            else
            {
                //Response.Write("<script>alert('Kayıt işlemi gerçekleştirilemedi!');</script>");
                BasariliAnimasyon.Value = "2";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }
    }
    }
