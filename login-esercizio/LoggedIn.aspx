<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoggedIn.aspx.cs" Inherits="login_esercizio.LoggedIn" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logged In</title>
</head>
<body>
    <form id="form1" runat="server">
        Benvenuto, <asp:Label ID="lblUsername" runat="server"></asp:Label><br />
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    </form>
</body>
</html>

