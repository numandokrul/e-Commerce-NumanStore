<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="musteriguncelle.aspx.cs" Inherits="admin2.musteriguncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }

        .auto-style2 {
            height: 23px;
        }

        .auto-style3 {
            height: 22px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="BasariliAnimasyon" hidden="hidden" runat="server" value="0" />
    <div id="tbl" runat="server"></div>
    <asp:Panel ID="PnlGuncelle" runat="server" Visible="False">
        <div id="musteri" runat="server" style="margin: 30px">
            <table class="w-100">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="AD SOYAD"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="MESLEK"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="TELEFON"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="ADRES"></asp:Label>
                    </td>
                    <td class="auto-style1">:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="ŞEHİR"></asp:Label>
                    </td>
                    <td class="auto-style1">:</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">E-Mail</td>
                    <td class="auto-style3">:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="ÜLKE"></asp:Label>
                    </td>
                    <td class="auto-style1">:</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
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
