using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class yoneticiekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Adsoyad = TextBox1.Text;
            yonetici.Email = TextBox2.Text;
            yonetici.Kadi = TextBox3.Text;
            yonetici.Sfr = TextBox4.Text;
            yonetici.Sfr = TextBox5.Text;
            yonetici.Resim = "images/TabloAdminn/" + FileUpload1.FileName;
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(MapPath("images/TabloAdminn/") + FileUpload1.FileName);

            }

            YoneticiCRUD yoneticiCRUD = new YoneticiCRUD();
            bool sonuc = yoneticiCRUD.kaydet(yonetici);
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
            FileUpload1.Dispose();
        }
    }
}