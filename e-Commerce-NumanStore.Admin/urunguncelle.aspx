<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="urunguncelle.aspx.cs" Inherits="admin2.urunguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <input id="BasariliAnimasyon" hidden="hidden" runat="server" value="0" />
    <div id="tbl" runat="server"> </div>
    <asp:Panel ID="PnlGuncelle" runat="server" Visible="False">
        <div id="urun0" runat="server" style="margin:50px">
            <table class="w-100">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Kategoriler"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="147px" DataSourceID="SqlDataSource1" DataTextField="kategoriler" DataValueField="kategoriler">
                            <asp:ListItem>Seçiniz</asp:ListItem>
                            <asp:ListItem>Giyim</asp:ListItem>
                            <asp:ListItem>Aksesuar</asp:ListItem>
                            <asp:ListItem>Ayakkabı</asp:ListItem>
                            <asp:ListItem>Spor&amp;Outdoor</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ButgemWebConnectionString1 %>" SelectCommand="SELECT DISTINCT [kategoriler] FROM [urunler]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Marka"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="147px" DataSourceID="SqlDataSource2" DataTextField="marka" DataValueField="marka">
                            <asp:ListItem>Seçiniz</asp:ListItem>
                            <asp:ListItem>Mavi</asp:ListItem>
                            <asp:ListItem>Zara</asp:ListItem>
                            <asp:ListItem>Nike</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ButgemWebConnectionString1 %>" SelectCommand="SELECT DISTINCT [marka] FROM [urunler]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Ürün Adı"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Fiyat"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Para Birimi"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="parabirimi" DataValueField="parabirimi">
                            <asp:ListItem>TL</asp:ListItem>
                            <asp:ListItem>USD</asp:ListItem>
                            <asp:ListItem>EURO</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ButgemWebConnectionString1 %>" SelectCommand="SELECT DISTINCT [parabirimi] FROM [urunler]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Text="Stok Kodu"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label9" runat="server" Text="Stok Adedi"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label10" runat="server" Text="Kargo Ağırlık"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label11" runat="server" Text="Resim"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        &nbsp;<asp:Image ID="Image1" runat="server" Height="110px" Width="110px" />
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label12" runat="server" Text="Tarih"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label13" runat="server" Text="Detay"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" class="btn-dark" runat="server" Text="Güncelle" Width="68px" OnClick="Button1_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
            </table>
            
            <div class="position-fixed bottom-0 end-0 p-3" style="z-index: 11">
                <div id="liveToast" class="toast align-items-center text-white bg-primary border-0"
                    role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                        <div class="toast-body">
                            Güncelleme İşlemi Başarılı.
                        </div>
                        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                </div>
            </div>
        </div>

    </asp:Panel>
     <script>
        document.addEventListener("DOMContentLoaded", function (event) {
            if (document.getElementById("ContentPlaceHolder1_BasariliAnimasyon").value === '1') {
                //alert('Güncelleme İşlemi Yapıldı');
                var toastLiveExample = document.getElementById('liveToast');
                var toast = new bootstrap.Toast(toastLiveExample);
                toast.show();
            }
            document.getElementById("ContentPlaceHolder1_BasariliAnimasyon").value = '0';
        });
     </script>
</asp:Content>
