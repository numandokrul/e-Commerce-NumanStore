<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="yoneticiekle.aspx.cs" Inherits="admin2.yoneticiekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 219px;
            height:37px;
        }
        .auto-style2 {
            width: 32px;
            height:37px;
        }
        .auto-style3 {
            width: 216px;
            height: 34px;
        }
        .auto-style4 {
            width: 32px;
            height: 37px;
        }
        .auto-style5 {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="BasariliAnimasyon" hidden="hidden" runat="server" value="0" />
     <div id="yonetici_ekle" runat="server" style="margin:50px">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Ad Soyad"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox1" CssClass="form-control-file" runat="server" Width="200px" Height="30px" BorderColor="Gray" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox2"  CssClass="form-control-file" runat="server" Width="200px" Height="30px" BorderColor="Gray"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Kullanıcı Adı"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox3"  CssClass="form-control-file" runat="server" Width="200px" Height="30px" BorderColor="Gray"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Şifre"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox4"  CssClass="form-control-file" runat="server" Width="200px" Height="30px" BorderColor="Gray" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="Şifre(Tekrar)"></asp:Label>
            </td>
            <td class="auto-style2">:</td>
            <td>
                <asp:TextBox ID="TextBox5"  CssClass="form-control-file" runat="server" Width="200px" Height="30px" BorderColor="Gray" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Resim(Avatar)"></asp:Label>
            </td>
            <td class="auto-style4">:</td>
            <td class="auto-style5">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1"  CssClass="btn-dark" runat="server" Text="Kaydet" OnClick="Button1_Click" Width="68px"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2"  CssClass="btn-dark" runat="server" Text="Temizle" OnClick="Button2_Click" Width="68px" />
            </td>
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
                            Ekleme İşlemi Başarılı.
                        </div>
                        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                </div>
               <div id="liveToast2" class="toast align-items-center text-white bg-primary border-0"
                    role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                        <div class="toast-body">
                            Ekleme İşlemi Başarısız.
                        </div>
                        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                </div>
            </div>
         </div>
    <script>
        document.addEventListener("DOMContentLoaded", function (event) {
            if (document.getElementById("ContentPlaceHolder1_BasariliAnimasyon").value === '1') {
                //alert('Güncelleme İşlemi Yapıldı');
                var toastLiveExample = document.getElementById('liveToast');
                var toast = new bootstrap.Toast(toastLiveExample);
                toast.show();
            }
            else if (document.getElementById("ContentPlaceHolder1_BasariliAnimasyon").value === '2') {
                //alert('Güncelleme İşlemi Yapıldı');
                var toastLiveExample = document.getElementById('liveToast2');
                var toast = new bootstrap.Toast(toastLiveExample);
                toast.show();
            }
            document.getElementById("ContentPlaceHolder1_BasariliAnimasyon").value = '0';

        });
    </script>
</asp:Content>
