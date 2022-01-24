﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div id="content" class="float_r">
        	<h1> Ürünler</h1>
            <%  System.Data.DataTable ktbl = new System.Data.DataTable();
                UrunCRUD kurun= new UrunCRUD();
                string uruncek = Request.QueryString["kat"];
                if (string.IsNullOrEmpty(uruncek))
                {
                    uruncek = "";
                }
                ktbl = kurun.kategoriyeuruncek(uruncek);
                for (int i = 0; i < ktbl.Rows.Count; i++)
                {



		%>
            <div class="product_box">
	            <h3><%=ktbl.Rows[i]["urunadi"]%></h3>
            	<a href="urunincele.aspx?bno=<%=ktbl.Rows[i][7]%>"><img width="200px"  src="<%=ktbl.Rows[i]["resim"]%>" alt=""/></a>
                <p> <%--Fusce in dui et neque malesuada tincidunt nec at urna. Validate --%><a href="http://validator.w3.org/check?uri=referer" rel="nofollow"><%=ktbl.Rows[i]["marka"]%></a>  <a href="http://jigsaw.w3.org/css-validator/check/referer" rel="nofollow"></a></p>
              <p class="product_price"><%=ktbl.Rows[i]["fiyat"]%> TL</p>
                <a href="sepetim.aspx?bno=<%=ktbl.Rows[i][7]%>"> Sepete Ekle</a>
                <a href="urunincele.aspx?bno=<%=ktbl.Rows[i][7]%>" class="detail"></a>
            </div>        	
         <%} %>
            <%--   <div class="product_box">
            	<h3>Curabitur et turpis</h3>
            	<a href="productdetail.html"><img src="images/product/02.jpg" alt="Shoes 2" /></a>
                <p>Etiam et sapien ut nunc blandit euismod. Sed dui libero, semper a volutpat sed, placerat eu lectus.</p>
            <p class="product_price">$ 80</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box no_margin_right">
            	<h3>Mauris consectetur</h3>
            	<a href="productdetail.html"><img src="images/product/03.jpg" alt="Shoes 3" /></a>
                <p>Curabitur pellentesque ullamcorper massa ac ultricies. Maecenas porttitor erat quis leo pellentesque.</p>
              <p class="product_price">$ 60</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>     
            
            <div class="cleaner"></div>
               	
            <div class="product_box">
            	<h3>Proin volutpat</h3>
            	<a href="productdetail.html"><img src="images/product/04.jpg" alt="Shoes 4" /></a>
                <p>Morbi non risus vitae est vestibulum tincidunt ac eget metus. Sed congue, erat id congue vehicula.</p>
              <p class="product_price">$ 260</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box">
	            <h3>Aenean tempus</h3>
            	<a href="productdetail.html"><img src="images/product/05.jpg" alt="Shoes 5" /></a>
                <p>Aenean eu elit arcu. Quisque eget blandit erat. Integer molestie malesuada augue vitae mollis.</p>
            <p class="product_price">$ 80</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box no_margin_right">
            	<h3>Nulla luctus urna</h3>
            	<a href="productdetail.html"><img src="images/product/06.jpg" alt="Shoes 6" /></a>
                <p>Nunc nisl nisi, aliquet eu gravida vitae, porta vel ante. Pellentesque faucibus risus et sem volutpat.</p>
              <p class="product_price">$ 190</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>   
            
            <div class="cleaner"></div>
                 	
            <div class="product_box">
            	<h3>Pellentesque egestas</h3>
            	<a href="productdetail.html"><img src="images/product/07.jpg" alt="Shoes 7" /></a>
				<p>Aenean eu elit arcu. Quisque eget blandit erat. Integer molestie malesuada augue vitae mollis.</p>
              <p class="product_price">$ 30</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box">
            	<h3>Suspendisse porttitor</h3>
            	<a href="productdetail.html"><img src="images/product/08.jpg" alt="Shoes 8" /></a>
                <p>Nulla rutrum neque vitae erat condimentum eget malesuada neque molestie. Nunc a leo tellus.</p>
            <p class="product_price">$ 220</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>        	
            <div class="product_box no_margin_right">
            	 <h3>Nam vehicula</h3>
            	<a href="productdetail.html"><img src="images/product/09.jpg" alt="Shoes 9" /></a>
               	<p>Vivamus accumsan luctus interdum. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
              <p class="product_price">$ 65</p>
                <a href="shoppingcart.html" class="addtocart"></a>
                <a href="productdetail.html" class="detail"></a>
            </div>  --%>
        </div> 

</asp:Content>

