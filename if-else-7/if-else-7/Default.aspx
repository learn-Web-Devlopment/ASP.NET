<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Subject 1 : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Subject 2 : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Subject 3 : "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Subject 4 : "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clac Percentage" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Percentage is : "></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="0" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Grade : "></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="A" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
