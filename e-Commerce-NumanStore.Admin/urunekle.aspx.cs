using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class urunekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Kat = DropDownList1.SelectedValue;
            urun.Marka = DropDownList2.SelectedValue;
            urun.Urunad = TextBox1.Text;
            urun.Fiyat = Convert.ToInt32(TextBox2.Text);
            
            if (CheckBox1.Checked)
            {
               urun.Kdv = "Evet";
            }
            else
            {
                urun.Kdv = "Hayır";
            }
            urun.Pbirim = DropDownList3.SelectedValue;
            urun.Stkodu = TextBox3.Text;
            urun.Barkod = TextBox4.Text;
            urun.Stadet = TextBox5.Text;
            urun.Kagirlik = TextBox6.Text;
           
            urun.Tarih = TextBox7.Text;
            urun.Detay = TextBox8.Text;
            urun.Resim = "images/urunler/" + FileUpload1.FileName;
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(MapPath("images/urunler/") + FileUpload1.FileName);

            }

            UrunCRUD urunCRUD = new UrunCRUD();
            bool sonuc = urunCRUD.kaydet(urun);
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
            DropDownList1.Items.Clear();
            DropDownList2.Items.Clear()
;            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            FileUpload1.Dispose();
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
           
            DropDownList3.Items.Clear();
        }
    }
    }
