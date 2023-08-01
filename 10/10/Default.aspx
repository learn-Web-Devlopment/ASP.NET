<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Name"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="TextBox1" ErrorMessage="* Please Enter Name" ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Age"></asp:TextBox>
                &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="* age &gt; 18 &amp; &lt; 70" ForeColor="Red" MaximumValue="70" MinimumValue="18">
                </asp:RangeValidator>
                <br />
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="TextBox3" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                &nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox3"
                    ControlToValidate="TextBox4" ErrorMessage="Password Not Match"></asp:CompareValidator>
                <br />
                <br />
                <asp:TextBox ID="TextBox5" runat="server" placeholder="Enter Email"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                    ControlToValidate="TextBox5" ErrorMessage="Please Enter Correct Mail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                </asp:RegularExpressionValidator>
                <br />
                <br />
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
                &nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
                &nbsp;&nbsp;&nbsp;
                <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic"
                    ErrorMessage="Please Select Gender" OnServerValidate="CustomValidator1_ServerValidate">
                </asp:CustomValidator>
                <br />
                <br />
                <asp:TextBox ID="TextBox6" runat="server" palceholder="Enter Even Number"></asp:TextBox>
                &nbsp;
                <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="TextBox6" Display="Dynamic"
                    ErrorMessage="Not Event Number" OnServerValidate="CustomValidator2_ServerValidate">
                </asp:CustomValidator>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" />
                <br />
            </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </form>
    </body>

    </html>