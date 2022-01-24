<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <%System.Data.DataTable dt = new System.Data.DataTable();
        UrunCRUD uruncrud = new UrunCRUD();
        dt = uruncrud.katliste("Çok Satanlar");

            %>
     <div id="content" class="float_r">
        	<div id="slider-wrapper">
                <div id="slider" class="nivoSlider">
                    <%--<img src="images/slider/02.jpg" alt="" />
                    <a href="#"><img src="images/slider/01.jpg" alt="" title="This is an example of a caption" /></a>
                    <img src="images/slider/03.jpg" alt="" />
                    <img src="images/slider/04.jpg" alt="" title="#htmlcaption" />--%>
                     <% for (int i = 0; i < dt.Rows.Count; i++)
                  {%>
                    <a href="urunincele.aspx?bno=<%=dt.Rows[i][7]%>"><img width="500px" height="300px" src="<%=dt.Rows[i][10] %>"  alt="" /></a>

            <%} %>



                </div>
                <div id="htmlcaption" class="nivo-html-caption">
                    <strong>This</strong> is an example of a <em>HTML</em> caption with <a href="#">a link</a>.
                </div>
            </div>
            <script type="text/javascript" src="js/jquery-1.4.3.min.js"></script>
            <script type="text/javascript" src="js/jquery.nivo.slider.pack.js"></script>
            <script type="text/javascript">
                $(window).load(function () {
                    $('#slider').nivoSlider();
                });
            </script>
        	<h1>Yeni Gelenler</h1>
          <%System.Data.DataTable yg = new System.Data.DataTable();
        UrunCRUD yurun = new UrunCRUD();
        yg = yurun.yenigelenler("Üst Giyim");

            %>
         <% for (int i = 0; i < yg.Rows.Count; i++)
             {

             %>
            <div class="product_box">
	            <h3><%=yg.Rows[i]["urunadi"]%></h3>
            	<a href="urunincele.aspx?bno=<%=yg.Rows[i][7]%>"><img width="130px" src="<%=yg.Rows[i]["resim"]%>" alt=""/></a>
                <p><%=yg.Rows[i]["marka"]%></p>
                <p class="product_price"><%=yg.Rows[i]["fiyat"]%> TL</p>
                <a href="sepetim.aspx?bno=<%=yg.Rows[i][7]%>" <%--class="addtocart"--%>>Sepete Ekle</a>
                <a href="urunincele.aspx?bno=<%=yg.Rows[i][7]%>" class="detail"></a>

           <%-- <div class="product_box">
	            <h3>Ut eu feugiat</h3>
            	<a href="productdetail.html"><img src="images/product/01.jpg" alt="Shoes 1" /></a>
                <p>Nulla rutrum neque vitae erat condimentum eget malesuada.</p>
                <p class="product_price">$ 100</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div> --%>       	
           <%-- <div class="product_box">
            	<h3>Curabitur et turpis</h3>
            	<a href="productdetail.html"><img src="images/product/02.jpg" alt="Shoes 2" /></a>
                <p>Sed congue, erat id congue vehicula. Validate <a href="http://validator.w3.org/check?uri=referer" rel="nofollow">XHTML</a> &amp; <a href="http://jigsaw.w3.org/css-validator/check/referer" rel="nofollow">CSS</a>.</p>
              <p class="product_price">$ 80</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box no_margin_right">
            	<h3>Mauris consectetur</h3>
            	<a href="productdetail.html"><img src="images/product/03.jpg" alt="Shoes 3" /></a>
                <p>Morbi non risus vitae est vestibulum tincidunt ac eget metus.</p>
              <p class="product_price">$ 60</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>   
            
            <div class="cleaner"></div>
                 	
<div class="product_box">
            	<h3>Proin volutpat</h3>
           	<a href="productdetail.html"><img src="images/product/04.jpg" alt="Shoes 4" /></a>
            <p>Sed semper euismod dolor sit amet interdum. Phasellus in mi eros.</p>
      <p class="product_price">$ 220</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box">
	            <h3>Aenean tempus</h3>
            	<a href="productdetail.html"><img src="images/product/05.jpg" alt="Shoes 5" /></a>
                <p>Maecenas porttitor erat quis leo pellentesque molestie.</p>
              <p class="product_price">$ 180</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box no_margin_right">
            	<h3>Nulla luctus urna</h3>
            	<a href="productdetail.html"><img src="images/product/06.jpg" alt="Shoes 6" /></a>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                <p class="product_price">$ 160</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>   --%>     
               
        </div> 
 <%} %>
</div>
</asp:Content>

