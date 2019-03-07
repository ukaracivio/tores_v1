<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TORES.v1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TORES - Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbelKulAd" runat="server" Text="Kullanıcı Adı :"></asp:Label>
        <asp:TextBox ID="tboxKulAd" runat="server" MaxLength="10" Width="156px"></asp:TextBox><br />
        <asp:Label ID="lbelKulSifre" runat="server" Text="Kullanıcı Şifre : "></asp:Label>
        <asp:TextBox ID="tboxKulSifre" runat="server" MaxLength="10" TextMode="Password" ToolTip="Şifreyi Giriniz" Width="92px"></asp:TextBox><br />
        <br />
        <br />
        <asp:Button ID="btonOK" runat="server" Text="Sistem Giriş" OnClick="btonOK_Click" />
    </div>
    </form>
</body>
</html>
