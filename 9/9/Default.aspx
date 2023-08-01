<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="gender"
                    OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
                <br />
                <br />
                <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="gender"
                    OnCheckedChanged="RadioButton2_CheckedChanged" Text="Female" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Gender : "></asp:Label>
            </div>
        </form>
    </body>

    </html>