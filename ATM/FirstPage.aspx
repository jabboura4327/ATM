<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="ATM.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ATM - First Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWelcome" runat="server" Text="First Page" Font-Size="20px" Font-Bold="True"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblUI" runat="server" Text="User ID"></asp:Label>
            <asp:TextBox ID="txtUI" runat="server" autofocus></asp:TextBox>
            <asp:Label ID="lblUIMessage" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:Label ID="lblPasswordMessage" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </p>
    </form>
</body>
</html>
