<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title></title>
  </head>
  <body>
    <form id="form1" runat="server">
      <div>
        <asp:GridView
          ID="GridView1"
          runat="server"
          AutoGenerateColumns="False"
          DataKeyNames="Id"
          DataSourceID="SqlDataSource1"
        >
          <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField
              DataField="Id"
              HeaderText="Id"
              InsertVisible="False"
              ReadOnly="True"
              SortExpression="Id"
            />
            <asp:BoundField
              DataField="name"
              HeaderText="name"
              SortExpression="name"
            />
            <asp:BoundField
              DataField="email"
              HeaderText="email"
              SortExpression="email"
            />
            <asp:BoundField
              DataField="message"
              HeaderText="message"
              SortExpression="message"
            />
          </Columns>
        </asp:GridView>
        <asp:SqlDataSource
          ID="SqlDataSource1"
          runat="server"
          ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
          DeleteCommand="DELETE FROM [users] WHERE [Id] = @Id"
          InsertCommand="INSERT INTO [users] ([name], [email], [message]) VALUES (@name, @email, @message)"
          ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
          SelectCommand="SELECT * FROM [users]"
          UpdateCommand="UPDATE [users] SET [name] = @name, [email] = @email, [message] = @message WHERE [Id] = @Id"
        >
          <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
          </DeleteParameters>
          <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="message" Type="String" />
          </InsertParameters>
          <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="message" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
          </UpdateParameters>
        </asp:SqlDataSource>
      </div>
    </form>
  </body>
</html>
