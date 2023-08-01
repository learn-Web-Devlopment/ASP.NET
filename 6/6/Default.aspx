<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Login Panel">
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Name"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server" GroupingText="Welcome Panel" Visible="False">
            <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        </asp:Panel>
    </form>
</body>
</html>
