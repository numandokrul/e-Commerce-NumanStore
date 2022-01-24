using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunara : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        urunler.InnerHtml = string.Empty;
        try
        {
            UrunCRUD urunCRUD = new UrunCRUD();
            if (!string.IsNullOrEmpty(Request.QueryString["q"]))
            {
                DataTable dt = urunCRUD.AramaSonuclariListe(Request.QueryString["q"].ToString());
                foreach (DataRow item in dt.Rows)
                {
                    urunler.InnerHtml += @"
                      <div class=""product_box"">
                        <h3>" + item[2].ToString() + @"</h3>
                        <a href=""urunincele.aspx?bno=" + item[7].ToString() + @""">
                            <img src=""" + item[10].ToString() + @""" alt=""..."" width=""150px"" /></a>
                            <p>
                            " + item[1].ToString() + @"
                            </p>
                        <p class=""product_price"">" + item[3].ToString() + @" TL</p>
                        <a href=""shoppingcart.html"" class=""addtocart""></a>
                        <a href=""urunincele.aspx?bno=" + item[7].ToString() + @""" class=""detail""></a>
                    </div>
                    ";

                }
            }
        }
        catch (Exception)
        {

        }





    }
}