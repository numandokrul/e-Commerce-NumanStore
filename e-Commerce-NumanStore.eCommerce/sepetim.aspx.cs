using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sepetim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SepetCRUD sepet = new SepetCRUD();
        string bno = Request.QueryString["bno"];
        string bnosepet = Request.QueryString["bnosepet"];
        int kod = Convert.ToInt16(Request.QueryString["kod"]);
        if (bno != null)
        {

            Sepet mysepet = new Sepet();

            mysepet.Bkod = bno;
            mysepet.Adet = 1;
            mysepet.Durum = false;

            mysepet.Email = Session["uye"].ToString();
            if (sepet.varmi(Session["uye"].ToString(), bno) == false)// ürün ilk defa ekleniyor//
            {
                bool cevap = sepet.kaydet(mysepet);

                if (cevap)
                {
                    Response.Write("<script> alert('Ürününüz Sepete eklenmiştir');</script>");
                }
            }
            else
            {
                sepet.adetartir(bno, Session["uye"].ToString());
            }




            //sepetteki ürün - İşlemi//
        }

        if ((bnosepet != null) && (kod == 0))
        {
            sepet.adetazalt(bnosepet, (Session["uye"]).ToString());
            Response.Redirect("sepetim.aspx");
        }

        //sepetteki ürün + işlemi//
        else if ((bnosepet != null) && (kod == 1))
        {
            sepet.adetartir(bnosepet, (Session["uye"]).ToString());
            Response.Redirect("sepetim.aspx");
        }

        //sepetteki ürün sil işlemi//
        else if ((bnosepet != null) && (kod == 2))
        {

            sepet.sil(bnosepet, (Session["uye"]).ToString());

            Response.Redirect("sepetim.aspx");
        }

    }
}