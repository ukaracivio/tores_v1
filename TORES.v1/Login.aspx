<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TORES.v1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TORES - Login</title>

	<!-- css files -->
	<link href="../Styles/font-awesome.min.css" rel="stylesheet" type="text/css" media="all">
	<link href="../Styles/style.css" rel="stylesheet" type="text/css" media="all"/>
	
	<!-- google fonts -->
	<link href="http://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

</head>
<body>
    <form id="form1" runat="server">
        <div class="signupform">
            <div class="container">
                <!-- main content -->
                <div class="agile_info">
                    <div class="w3l_form">
                        <div class="left_grid_info">
                            <h1>Manage Your Business Account</h1>
                            <p>Donec dictum nisl nec mi lacinia, sed maximus tellus eleifend. Proin molestie cursus sapien ac eleifend.</p>
                            <img src="Images/image.jpg" alt="" />
                        </div>
                    </div>
                    <div class="w3_info">
                        <h2>Sistem Giriş</h2>
                        <p>Sisteme bağlanabilmek için kullanıcı adınızı ve şifrenizi giriniz...</p>

                        <asp:Label ID="lbelKulAd" runat="server" Text="Kullanıcı Adı :"></asp:Label>
                        <div class="input-group">
                            <span class="fa fa-envelope" aria-hidden="true"></span>
                            <asp:TextBox ID="tboxKulAd" runat="server" MaxLength="10" PlaceHolder="Kullanıcı Adı"></asp:TextBox>
                        </div>
                        <asp:Label ID="lbelKulSifre" runat="server" Text="Kullanıcı Şifre : "></asp:Label>
                        <div class="input-group">
                            <span class="fa fa-lock" aria-hidden="true"></span>
                            <asp:TextBox ID="tboxKulSifre" runat="server" MaxLength="10" TextMode="Password" PlaceHolder="Kullanıcı Şifresi"></asp:TextBox>
                        </div>
                        <div class="login-check">
                            <label class="checkbox">
                                <input type="checkbox" name="checkbox" checked=""><i> </i>Remember me</label>
                        </div>
                        <asp:Button ID="btonOK" runat="server" CssClass="btn btn-danger btn-block" Text="Sistem Giriş" OnClick="btonOK_Click" />


                        <p class="account">By clicking login, you agree to our <a href="#">Terms & Conditions!</a></p>
                        <p class="account1">Dont have an account? <a href="#">Register here</a></p>
                    </div>
                </div>
                <!-- //main content -->
            </div>
            <!-- footer -->
            <div class="footer">
                <p>&copy; 2019 Business login form. All Rights Reserved | Design by <a href="https://w3layouts.com/" target="blank">W3layouts</a></p>
            </div>
            <!-- footer -->
        </div>

    </form>


</body>
</html>
