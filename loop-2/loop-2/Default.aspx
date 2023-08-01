<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="loop - 5"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" placeholder="enter number "></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
&nbsp;<div>
            <asp:Label ID="loop5" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="loop - 5.2"></asp:Label>
            <br />
            <asp:Label ID="loop52" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="loop - 5.3"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <asp:Label ID="loop53" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="loop - 5.4"></asp:Label>
            <br />
            <asp:Label ID="loop54" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="loop - 6"></asp:Label>
            <br />
            <asp:Label ID="loop6" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="loop - 7"></asp:Label>
            <br />
            <asp:Label ID="loop7" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label" runat="server" Text="loop - 8"></asp:Label>
            <br />
            <asp:Label ID="loop8" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="loop - 9"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <asp:Label ID="loop9" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Label - 10"></asp:Label>
            <br />
            <asp:Label ID="fbs" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
