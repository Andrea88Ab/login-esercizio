<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="login_esercizio.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            Password: <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>

