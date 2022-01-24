<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="admin2.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <title>Numan Store</title>
  <!-- base:css -->
  <link rel="stylesheet" href="../../vendors/mdi/css/materialdesignicons.min.css">
  <link rel="stylesheet" href="../../vendors/feather/feather.css">
  <link rel="stylesheet" href="../../vendors/base/vendor.bundle.base.css">
  <!-- endinject -->
  <!-- plugin css for this page -->
  <!-- End plugin css for this page -->
  <!-- inject:css -->
  <link rel="stylesheet" href="../../css/style.css">
  <!-- endinject -->
  <link rel="shortcut icon" href="../../images/n.jpg" />
  
    <style type="text/css">
        .auto-style1 {
            position: relative;
            display: block;
            left: 0px;
            top: 8px;
            height: 38px;
            margin-top: 10px;
            margin-bottom: 10px;
            padding-left: 0;
        }
    </style>
  
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-scroller">
    <div class="container-fluid page-body-wrapper full-page-wrapper">
      <div class="content-wrapper d-flex align-items-center auth px-0">
        <div class="row w-100 mx-0">
          <div class="col-lg-4 mx-auto">
            <div class="auth-form-light text-left py-5 px-4 px-sm-5">
              <div class="brand-logo">
               <%-- <img src="../../images/n.jpg"  alt="logo"  ">--%>
                  <h2 style="color: #CC0000">NUMAN STORE</h2>
              </div>
              <h4>Merhaba!</h4>
              <h6 class="font-weight-light">Giriş Yaparak Devam Et.</h6>
              </div>
                <div class="form-group">
                  &nbsp; <asp:TextBox ID="TextBox1" cssClass="form-control form-control-lg" runat="server"  placeholder="E-mail adresi" TextMode="Email" ></asp:TextBox>
                </div>
                <div class="form-group">
                  &nbsp;<asp:TextBox ID="TextBox2" CssClass="form-control form-control-lg" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                </div>
                <div class="mt-3">
                    <asp:Button ID="Button1" CssClass="btn btn-block btn-info btn-lg font-weight-medium auth-form-btn" runat="server" Text="Giriş Yap" OnClick="Button1_Click"/>
                    
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000"></asp:Label>
                </div>
                <div class="my-2 d-flex justify-content-between align-items-center">
                  <div class="auto-style1">
                    <label class="form-check-label text-muted" style="height: 36px">
                      <br />
&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" />
                    </label>&nbsp;Oturumu Açık Tut&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                </div>
           
                <div class="text-center mt-4 font-weight-light">
                  Hesabın Yok Mu?&nbsp;&nbsp;&nbsp;&nbsp; <a href="yenihesap.aspx" class="text-primary">Oluştur</a>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
      <!-- content-wrapper ends -->
    </div>
    <!-- page-body-wrapper ends -->
  </div>
  <!-- container-scroller -->
  <!-- base:js -->
  <script src="../../vendors/base/vendor.bundle.base.js"></script>
  <!-- endinject -->
  <!-- inject:js -->
  <script src="../../js/off-canvas.js"></script>
  <script src="../../js/hoverable-collapse.js"></script>
  <script src="../../js/template.js"></script>
        </div>
    </form>
</body>
</html>
