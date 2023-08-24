<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <br />
    <br />
    <br />
    <br />
    <br />
    <form id="form1" runat="server" style="text-align:center;">
        <asp:Label ID="Label1" runat="server" Font-Size="30px" Text="Registration "></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter email" Width="216px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter password" Width="216px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" Width="92px" />
        <br />
        <div>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
