<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="musteriekle.aspx.cs" Inherits="admin2.musteriekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 23px;
        }
        .auto-style2 {
            width: 198px;
        }
        .auto-style3 {
            width: 198px;
            height: 20px;
        }
        .auto-style4 {
            width: 23px;
            height: 20px;
        }
        .auto-style5 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <input id="BasariliAnimasyon" hidden="hidden" runat="server" value="0" />
      <div id="musteri_ekle" runat="server" style="margin:50px">

          <table class="w-100">
              <tr>
                  <td class="auto-style3">
                      <asp:Label ID="Label1" runat="server" Text="AD SOYAD"></asp:Label>
                  </td>
                  <td class="auto-style4">:</td>
                  <td class="auto-style5">
                       <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Width="200px" Height="30px"  ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style3">
                      <asp:Label ID="Label2" runat="server" Text="TC NO"></asp:Label>
                  </td>
                  <td class="auto-style4">:</td>
                  <td class="auto-style5">
                      <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Width="200px" Height="30px" ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style3">
                      <asp:Label ID="Label3" runat="server" Text="MESLEK"></asp:Label>
                  </td>
                  <td class="auto-style4">:</td>
                  <td class="auto-style5">
                     <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" Width="200px" Height="30px"  ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style3">
                      <asp:Label ID="Label4" runat="server" Text="TELEFON"></asp:Label>
                  </td>
                  <td class="auto-style4">:</td>
                  <td class="auto-style5">
                       <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" Width="200px" Height="30px"  ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label5" runat="server" Text="ADRES"></asp:Label>
                  </td>
                  <td class="auto-style1">:</td>
                  <td>
                      <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server" Width="200px" Height="30px"  ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label6" runat="server" Text="ŞEHİR"></asp:Label>
                  </td>
                  <td class="auto-style1">:</td>
                  <td>
                     <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" Width="200px" Height="30px" ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label7" runat="server" Text="MAİL"></asp:Label>
                  </td>
                  <td class="auto-style1">:</td>
                  <td>
                       <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server" Width="200px" Height="30px" ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label8" runat="server" Text="ÜLKE"></asp:Label>
                  </td>
                  <td class="auto-style1">:</td>
                  <td>
                       <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server" Width="200px" Height="30px"  ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style1">&nbsp;</td>
                  <td>
                      <asp:Button ID="Button1" runat="server" CssClass="btn btn-outline-primary btn-icon-text" Text="KAYDET" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="Button2" runat="server" CssClass="btn btn-outline-warning btn-icon-text" Text="TEMİZLE" />
                  </td>
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
            </div> 
          <div class="position-fixed bottom-0 end-0 p-3" style="z-index: 11">
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
