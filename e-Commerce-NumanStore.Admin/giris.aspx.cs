using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Veri tabanı kontrol
            YoneticiCRUD yoneticiCRUD = new YoneticiCRUD();
            Yonetici yonetici = yoneticiCRUD.KullaniciGirisKontrol(TextBox1.Text, TextBox2.Text);
            //if ((TextBox1.Text == "numan@mail.com") && (TextBox2.Text == "Wesley.10"))
            if (yonetici != null)
            {
                Session["uye"] = yonetici.Email;
                Session["uyeAdSoyad"] = yonetici.Adsoyad;
                Session["uyeKadi"] = yonetici.Kadi;
                Session["uyeResim"] = yonetici.Resim;
                Response.Redirect("default.aspx");
            }
            else
            {
                Label1.Text = "Mail Adresi veya Şifre Hatalı!";
            }
        }

      
    }
}