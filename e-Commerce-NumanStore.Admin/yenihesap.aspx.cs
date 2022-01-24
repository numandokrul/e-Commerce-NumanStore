using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class yenihesap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void KayitOl_ServerClick(object sender, EventArgs e)
        {
            YoneticiCRUD yoneticiCRUD = new YoneticiCRUD();
            var sonuc = yoneticiCRUD.yenikullanici(new Yonetici
            {
                Adsoyad = AdSoyad.Text,
                Email = Email.Text,
                Sfr = Sifre.Text,
                Kadi = KullaniciAdi.Text
            });
            if (sonuc)
            {
                Response.Redirect("giris.aspx");
            }
            else
            {

            }
        }
    }
}