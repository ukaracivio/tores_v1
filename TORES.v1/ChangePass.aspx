<%@ Page Title="" Language="C#" MasterPageFile="~/TORES.Master" AutoEventWireup="true" CodeBehind="ChangePass.aspx.cs" Inherits="TORES.v1.ChangePass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Table ID="tbleChangePass" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Eski şifre"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="tboxOldPass" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Yeni Şifre"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="tboxNewPass" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Yeni Şifre (tekrar)"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="tboxNewPass2" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    <br />

</asp:Content>
