using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class urunguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int kaysay;
            if (Request.QueryString["gun"] == null)
            {
                DataTable tablo = new DataTable();
                UrunCRUD listele = new UrunCRUD();
                tablo = listele.tumliste();
                kaysay = tablo.Rows.Count;
                tbl.InnerHtml = "<table class='table table-bordered' border=1 style='margin:50px' width:50,height:50>";
                tbl.InnerHtml += "<tr><td>Kategoriler</td><td>Marka</td><td>Ürün Adı</td><td>Fiyat</td><td>Para Birimi</td><td>Barkod Kodu</td> <td>Resim</td> <td>Detay</td> <td>Güncelle</td> </tr>";

                for (int i = 0; i < kaysay; i++)
                {
                    tbl.InnerHtml += $"<tr><td>{tablo.Rows[i][0]}</td><td>{tablo.Rows[i][1]}</td><td>{tablo.Rows[i][2]}</td><td>{tablo.Rows[i][3]}</td> <td>{tablo.Rows[i][5]}</td> <td>{tablo.Rows[i][7]}</td> <td><img src='{tablo.Rows[i][10]}'height='60' width='60'>  </td>  <td>{tablo.Rows[i][12]}</td> <td> <a href='urunguncelle.aspx?gun={tablo.Rows[i][7]}'><img src='/images/update.png' height='60' width='60' ></a  </td> </tr>";
                }
                tbl.InnerHtml += "</table>";
            }
            else
            {
                if (!IsPostBack)
                {
                    string gun = Request.QueryString["gun"].ToString();
                    Urun urunguncelle = new Urun();
                    UrunCRUD urunCRUD1 = new UrunCRUD();
                    urunguncelle = urunCRUD1.getir(gun);
                    PnlGuncelle.Visible = true;
                    TextBox1.Text = urunguncelle.Urunad;
                    DropDownList1.SelectedValue = urunguncelle.Kat;
                    DropDownList2.SelectedValue = urunguncelle.Marka;
                    PnlGuncelle.Visible = true;
                    TextBox2.Text = (urunguncelle.Fiyat).ToString();
                    DropDownList3.SelectedValue = urunguncelle.Pbirim;
                    TextBox3.Text = urunguncelle.Stkodu;
                    TextBox5.Text = urunguncelle.Stadet;
                    TextBox6.Text = urunguncelle.Kagirlik;
                    Image1.ImageUrl = urunguncelle.Resim;
                    TextBox7.Text = urunguncelle.Tarih;
                    TextBox8.Text = urunguncelle.Detay;

                }








            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gun = Request.QueryString["gun"].ToString();
            bool cevap;
            UrunCRUD urunCrud = new UrunCRUD();
            Urun yurun = new Urun();
            yurun.Kat = DropDownList1.SelectedItem.Text;
            yurun.Marka = DropDownList2.SelectedItem.Text;
            yurun.Urunad = TextBox1.Text;
            yurun.Fiyat = Convert.ToInt32(TextBox2.Text);
            yurun.Pbirim = DropDownList3.SelectedItem.Text;
            yurun.Stkodu = TextBox3.Text;
            yurun.Stadet = TextBox5.Text;
            yurun.Kagirlik = TextBox6.Text;
            yurun.Resim = Image1.ImageUrl;
            yurun.Tarih = TextBox7.Text;
            yurun.Detay = TextBox8.Text;



            cevap = urunCrud.guncelleme(gun, yurun);
            if (cevap)
            {
                //Response.Write("<script>alert('Güncelleme İşlemi Yapıldı');</script>");
                ////Response.Redirect("urunguncelle.aspx");
                BasariliAnimasyon.Value = "1";
            }


           
        }
    }
    }
    
    




