<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="odeme.aspx.cs" Inherits="odeme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content" class="float_r">
        	<h2>Ödeme</h2>
            <h5><strong>FATURA BİLGİLERİ</strong></h5>
            <div class="content_half float_l checkout">
				Full Name (Kredi Kartınız ile aynı olmalı):  
                  <input type="text"  style="width:300px;"  />
                <br />
                <br />
              Adres:
				<input type="text"  style="width:300px;"  />
                <br />
                <br />
              Şehir:
                <input type="text"  style="width:300px;"  />
                <br />
                <br />
                Ülke:
                <input type="text"  style="width:300px;"  />
            </div>
            
            <div class="content_half float_r checkout">
            	E-MAIL
				<input type="text"  style="width:300px;"  />
                <br />
                <br />
          Telefon<br />
				<span style="font-size:10px">Lütfen ulaşılabilir telefon numaranızı belirtiniz..</span>
                <input type="text"  style="width:300px;"  />
            </div>
            
            <div class="cleaner h50"></div>
            <h3>SEPETİM</h3>
            <h4>TOPLAM TUTAR: <strong>$240</strong></h4>
			<p><input type="checkbox" />
			Bu web sitesinin <a href="#">kullanım şartlarını</a> kabul ediyorum.</p>
       <div id="odemepaypal" style="margin-right: 20px;" runat="server">
            <table style="border:1px solid #CCCCCC;" width="100%">
                <tr>
                    <td height="85px"> <img src="images/paypal.gif" alt="paypal" /></td>
                    <td width="410px;" style="padding: 0px 20px 0px 2px;">En hızlı teslimat süresi.
                    </td>
                  <%--  <td><a href="#" class="more">PAYPAL</a></td>--%>
                </tr>
                </table>
            </div>
        </div>
</asp:Content>

