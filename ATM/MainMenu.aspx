<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="ATM.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ATM - Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMainMenu" runat="server" Text="Main Menu" Font-Size="20px" Font-Bold="true"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblBalance" runat="server" Text="Balance:" Font-Size="20px" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblActionMessage" runat="server" Font-Size="20px" Font-Italic="True">-</asp:Label>
        </p>
        <p>
            <asp:Button ID="btnWithdraw" runat="server" OnClick="btnWithdraw_Click" Text="Withdraw" />
            <asp:TextBox ID="txtWithdrawAmount" runat="server" placeholder="Withdraw Amount"></asp:TextBox>
            <asp:Label ID="lblWithdrawMessage" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnDeposit" runat="server" OnClick="btnDeposit_Click" Text="Deposit" />
            <asp:TextBox ID="txtDepositAmount" runat="server" placeholder="Deposit Amount"></asp:TextBox>
            <asp:Label ID="lblDepositMessage" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnQuit" runat="server" OnClick="btnQuit_Click" Text="Quit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
