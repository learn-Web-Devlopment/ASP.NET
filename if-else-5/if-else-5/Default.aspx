<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter number : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
            <asp:Label ID="Label3" runat="server" ForeColor="#0099FF" Text="Odd" Visible="False"></asp:Label>
            <asp:Label ID="Label2" runat="server" ForeColor="#66FF66" Text="Even" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check number is Odd or Even" />
        </div>
    </form>
</body>
</html>
