<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="insert data inside a database using connected architecture"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="268px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="268px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Message"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="268px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert " />
        </div>
    </form>
</body>
</html>
