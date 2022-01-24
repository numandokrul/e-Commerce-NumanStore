<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="yoneticiguncelle.aspx.cs" Inherits="admin2.yoneticiguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="BasariliAnimasyon" hidden="hidden" runat="server" value="0" />
     <div id="tbl" runat="server"> </div>
    <asp:Panel ID="PnlGuncelle" runat="server" Visible="False">
        <div id="yonetici" runat="server" style="margin:30px">


            <div id="yonetici_ekle" runat="server" style="margin:50px">
                <table class="w-100">
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label1" runat="server" Text="Ad Soyad"></asp:Label>
                        </td>
                        <td class="auto-style2">:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" BorderColor="Gray" CssClass="form-control-file" Height="30px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label3" runat="server" Text="Kullanıcı Adı"></asp:Label>
                        </td>
                        <td class="auto-style2">:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" BorderColor="Gray" CssClass="form-control-file" Height="30px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label4" runat="server" Text="Şifre"></asp:Label>
                        </td>
                        <td class="auto-style2">:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" BorderColor="Gray" CssClass="form-control-file" Height="30px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label5" runat="server" Text="Şifre(Tekrar)"></asp:Label>
                        </td>
                        <td class="auto-style2">:</td>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server" BorderColor="Gray" CssClass="form-control-file" Height="30px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label6" runat="server" Text="Resim(Avatar)"></asp:Label>
                        </td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style5">&nbsp;<asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" CssClass="btn-dark" OnClick="Button1_Click" Text="Güncelle" Width="68px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
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
