<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Enter Base Salaray : "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate Gross Salary " />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="HRA : "></asp:Label>
                <asp:Label ID="hrapr" runat="server" Text="0%"></asp:Label>
                &nbsp;&nbsp;
                <asp:Label ID="hra" runat="server" Text="00000"></asp:Label>
                <br />
                <br />
                DA : <asp:Label ID="dapr" runat="server" Text="0%"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="da" runat="server" Text="00000"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Gross Salary : "></asp:Label>
                <asp:Label ID="gs" runat="server" Text="00000"></asp:Label>
            </div>
        </form>
    </body>

    </html>