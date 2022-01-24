<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yenihesap.aspx.cs" Inherits="admin2.yenihesap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <!-- Required meta tags -->
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <title>Numan STORE</title>
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
               <%-- <img src="../../images/logo-dark.svg" alt="logo">--%>
                  <h2 style="color: #CC0000">NUMAN STORE</h2>
              </div>
              <h4>Burada Yeni Misiniz?</h4>
              <h6 class="font-weight-light">Sadece birkac adımda kayıt olablirsiniz</h6>
              <form class="pt-3">
                <div class="form-group">
                   <asp:TextBox ID="AdSoyad" cssClass="form-control form-control-lg" runat="server"  placeholder="Ad Soyad" ></asp:TextBox>
                </div>
                <div class="form-group">
                  <asp:TextBox ID="Email" cssClass="form-control form-control-lg" runat="server"  placeholder="E-mail adresi" TextMode="Email" ></asp:TextBox>
                </div>
                  <div class="form-group">
                   <asp:TextBox ID="KullaniciAdi" cssClass="form-control form-control-lg" runat="server"  placeholder="Kullanıcı Adı" ></asp:TextBox>
                </div>

                <div class="form-group">
                 <asp:TextBox ID="Sifre" CssClass="form-control form-control-lg" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                </div>
                <div class="mb-4">
                  <div class="form-check">
                  </div>
                </div>
                <div class="mt-3">
                  <button class="btn btn-block btn-info btn-lg font-weight-medium auth-form-btn" id="KayitOl" runat="server" onserverclick="KayitOl_ServerClick" >Kayıt Ol</button>
                </div>
                <div class="text-center mt-4 font-weight-light">
                 Zaten Bir Hesabım Var <a href="giris.aspx" class="text-primary">Giriş Yap</a>
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
