<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="urunincele.aspx.cs" Inherits="urunincele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <% string bno = Request.QueryString["bno"];
        Urun urunum = new Urun();
        UrunCRUD uruncrud = new UrunCRUD();
        urunum = uruncrud.tekurun(bno);

		%>
     <div id="templatemo_main">
            <div id="content" class="float_r">
        	<h1><%=urunum.Urunad%></h1>
            <div class="content_half float_l">
        	<a  rel="lightbox[portfolio]" href="<%=urunum.Resim %>"><img width="200px" src="<%=urunum.Resim %>" alt="image" /></a>
            </div>
            <div class="content_half float_r">
                <table>
                    <tr>
                        <td width="160">Fiyat:</td>
                        <td><%=urunum.Fiyat%></td>
                    </tr>
                    <tr>
                        <td>Stok Adedi:</td>
                        <td><%=urunum.Stadet%></td>
                    </tr>
                    <tr>
                        <td>Marka:</td>
                        <td><%=urunum.Marka%></td>
                    </tr>
                    <tr>
                        <td>Kategori:</td>
                        <td><%=urunum.Kat%></td>
                    </tr>
                    <tr>
                    	<%--<td>Quantity</td>
                        <td><input type="text" value="1" style="width: 13px; text-align: right" /></td>--%>
                    </tr>
                </table>
                <div class="cleaner h20"></div>

               <%-- <a href="sepetim.aspx" class="addtocart"></a>--%>
                <a href="sepetim.aspx?bno=<%=bno%>" Css class="submit_btn">Sepete Ekle</a>

			</div>
            <div class="cleaner h30"></div>
            
            <h3>Ürün Detay</h3>
            <p style="font-size: large"><%=urunum.Detay%><a href="http://validator.w3.org/check?uri=referer" rel="nofollow"></a> <a href="http://jigsaw.w3.org/css-validator/check/referer" rel="nofollow"></a></p>	
            
          <div class="cleaner h50"></div>
            
            <h3>Related Products</h3>
        	<div class="product_box">
            	<a href="productdetail.html"><img src="images/product/01.jpg" alt="" /></a>
                <h3>Ut eu feugiat</h3>
                <p class="product_price">$ 100</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box">
            	<a href="productdetail.html"><img src="images/product/02.jpg" alt="" /></a>
                <h3>Curabitur et turpis</h3>
                <p class="product_price">$ 200</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box no_margin_right">
            	<a href="productdetail.html"><img src="images/product/03.jpg" alt="" /></a>
                <h3>Mauris consectetur</h3>
                <p class="product_price">$ 120</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>     
        </div> 
         </div>
</asp:Content>

