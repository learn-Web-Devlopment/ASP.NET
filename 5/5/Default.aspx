<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Height="100px">
                <asp:ListItem>Apple</asp:ListItem>
                <asp:ListItem>Banana</asp:ListItem>
                <asp:ListItem>Orange</asp:ListItem>
                <asp:ListItem>Mango</asp:ListItem>
                <asp:ListItem>Lime</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="&gt;" Width="24px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="&gt;&gt;" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="&lt;&lt;" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&lt;" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox2" runat="server" Height="100px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
