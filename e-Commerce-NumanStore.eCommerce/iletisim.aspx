<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content" class="float_r">
        	<h1>Bize Ulaşın</h1>
            <div class="content_half float_l">
              <%--  <p>Etiam eget leo nisl. Morbi magna enim, lobortis vitae condimentum eu, ultrices a lacus.</p>--%>
                <div id="contact_form">
                   <form method="post" name="contact" action="#">
                        
                        <label for="author">İsim:</label> <input type="text" id="author" name="author" class="required input_field" />
                        <div class="cleaner h10"></div>
                        <label for="email">Email:</label> <input type="text" id="email" name="email" class="validate-email required input_field" />
                        <div class="cleaner h10"></div>
                        
                        <label for="phone">Telefon:</label> <input type="text" name="phone" id="phone" class="input_field" />
                        <div class="cleaner h10"></div>
        
                        <label for="text">Mesaj:</label> <textarea id="text" name="text" rows="0" cols="0" class="required"></textarea>
                        <div class="cleaner h10"></div>
                        
                        <input type="submit" class="submit_btn" name="submit" id="submit" value="Gönder" />
                        
                    </form>
                </div>
            </div>
        <div class="content_half float_r">
        	<h5>Ofis</h5>
			DOSAB, Mustafa Karaer Caddesi,/<br />
			 Çiğdem 2 Sokak No:1,<br />
			16245 Osmangazi/Bursa<br /><br />
						
			Telefon: 0533 240 07 07<br />
			Email: <a href="mailto:numandokrulll@gmail.com">numandokrulll@gmail.com</a><br/>
			
            <div class="cleaner h40"></div>
			
           <%-- <h5>Secondary Office</h5>
			120-360 Cras ac nunc laoreet,<br />
			Nulla vitae leo ac dui, 10680<br />
			Cras id sem nulla<br /><br />
			
			Phone: 030-030-0220<br />
			Email: <a href="mailto:contact@yourcompany.com">contact@yourcompany.com</a><br/>--%>
			<br />
          <%--  Validate <a href="http://validator.w3.org/check?uri=referer" rel="nofollow">XHTML</a> &amp; <a href="http://jigsaw.w3.org/css-validator/check/referer" rel="nofollow">CSS</a>--%>
        </div>
        
        <div class="cleaner h40"></div>
        
 <iframe width="680" height="350" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3044.373444420414!2d29.079944915391433!3d40.267453879382714!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14ca40653791a2d5%3A0xd25ecfe140a173f2!2sBUTGEM%20BTSO%20E%C4%9Fitim%20Vakf%C4%B1!5e0!3m2!1sen!2str!4v1640873129270!5m2!1sen!2str"></iframe>
</div>
        

</asp:Content>

