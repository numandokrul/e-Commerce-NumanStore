<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="sepetim.aspx.cs" Inherits="sepetim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div id="content" class="float_r">
        <div>
            <%--<p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: bolder; color: #000000;">Sepetim</p>--%>
            <h1 style="padding-top: 18px">Sepetim</h1>
            <%SepetCRUD listem = new SepetCRUD();
                System.Data.DataTable dtlistem = new System.Data.DataTable();
                dtlistem = listem.liste(Session["uye"].ToString());
            %>
            <table width="665px" cellspacing="0" cellpadding="5">
                <tr bgcolor="#ddd">
                    <th width="180" align="left">Ürün Resmi </th>
                    <th width="180" align="left">Ürün Adı </th>
                    <th width="100" align="center">Adet </th>
                    <th width="50" align="left">Fiyat </th>
                    <th width="50" align="right">Toplam </th>
                    <th width="70" align="left">Kaldır </th>
                    <th width="90"></th>

                </tr>
                <% double fiyat = 0;
                    for (int i = 0; i < dtlistem.Rows.Count; i++)
                    {
                %>
                <tr>
                    <td>
                        <img width="80px" src="<%=dtlistem.Rows[i]["resim"] %>" alt="image 1" /></td>
                    <td><%=dtlistem.Rows[i]["urunadi"] %></td>
                    <td>
                        <div class="input-append">
                            <input class="span1" style="max-width: 20px" value="<%=dtlistem.Rows[i]["Adet"] %>" id="appendedInputButtons" size="15" type="text">

                            <% if (Convert.ToInt32(dtlistem.Rows[i]["Adet"]) > 1)
                                {%>
                            <a href="sepetim.aspx?bnosepet=<%=dtlistem.Rows[i]["Barkod"] %>&kod=0">
                                <button class="active" type="button"><i class="icon-minus">-</i></button></a>
                            <%}
                                else
                                {%>
                            <a href="#">
                                <button class="active" type="button" disabled><i class="icon-minus">-</i></button></a>

                            <% }%>
                            <a href="sepetim.aspx?bnosepet=<%=dtlistem.Rows[i]["Barkod"] %>&kod=1">
                                <button class="active" type="button"><i class="icon-plus">+</i></button></a>


                        </div>
                    </td>


                    <td><%=dtlistem.Rows[i]["fiyat"] %>  </td>
                    <%fiyat += (Convert.ToDouble(dtlistem.Rows[i]["fiyat"]) * Convert.ToDouble(dtlistem.Rows[i]["adet"])); %>
                    <td align="right"><%=Convert.ToDouble(dtlistem.Rows[i]["fiyat"]) * Convert.ToDouble(dtlistem.Rows[i]["adet"]) %> </td>

                    <%--<td align="center"> <a href="#"><img src="images/remove_x.gif" alt="remove" <br />Kaldır</a> </td>--%>
                    <td>
                        <a href="sepetim.aspx?bnosepet=<%=dtlistem.Rows[i]["Barkod"] %>&kod=2">
                            <button id="myBtn" class="btn btn-danger" type="button" style="background-color: #FF0000; color: #FFFFFF"><i class="fas fa-trash"></i>X</button></a>
                    </td>
                </tr>
                <%} %>
                <%--   <tr>
                        	<td><img src="images/product/02.jpg" alt="image 2" /> </td>
                            <td>Second Red Shoes</td> 
                       	  	<td align="center"><input type="text" value="1" style="width: 20px; text-align: right" />  </td>
                            <td align="right">$80  </td>
                            <td align="right">$80 </td>
                            <td align="center"> <a href="#"><img src="images/remove_x.gif" alt="remove" /><br />Remove</a>  </td>
						</tr>--%>
                <%--<tr>
                        	<td><img src="images/product/03.jpg" alt="image 3" /> </td>
                            <td>Hendrerit justo</td> 
                       	  	<td align="center"><input type="text" value="1" style="width: 20px; text-align: right" />  </td>
                            <td align="right">$60  </td>
                            <td align="right">$60 </td>
                            <td align="center"> <a href="#"><img src="images/remove_x.gif" alt="remove" /><br />Remove</a>  </td>
						</tr>--%>
                <tr>
                    <td colspan="3" align="right" height="30px"><a href="shoppingcart.html"><strong></strong></a>&nbsp;&nbsp;</td>
                    <td align="right" style="background: #ddd; font-weight: bold">Toplam:</td>
                    <td align="right" style="background: #ddd; font-weight: bold"><%=fiyat %> TL</td>
                    <td style="background: #ddd; font-weight: bold"></td>
                </tr>
            </table>
            <div style="float: right; width: 215px; margin-top: 20px;">

                <p><a href="checkout.html">Proceed to checkout</a></p>
                <p><a href="javascript:history.back()">Alışverişe devam et</a></p>

            </div>
        </div>
    </div>

</asp:Content>

