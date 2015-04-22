<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyWebForm.aspx.cs" Inherits="MyWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Company Contacts</h1>
    <h3>Fedi Hanna: The coolest slogan there ever was.</h3>
    <form id="form1" runat="server">
    <div>
   
    </div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource6">
            <HeaderTemplate>
                <table border="1">
            </HeaderTemplate>
            <ItemTemplate>

                <tr>
                    <td>branch ID:<%# DataBinder.Eval(Container.DataItem, "BranchId") %></td>
                    <td>First Name:<%# DataBinder.Eval(Container.DataItem, "FirstName") %></td>
                    <td>Last Name:<%# DataBinder.Eval(Container.DataItem, "LastName") %></td>
                    <td>Extension:<%# DataBinder.Eval(Container.DataItem, "Extension") %></td>
                    <td>Saluation:<%# DataBinder.Eval(Container.DataItem, "Salutation") %></td>
                    <td>Company ID:<%# DataBinder.Eval(Container.DataItem, "CompanyId") %></td>
                    <td><img width="100" height="100" src="images/image<%# DataBinder.Eval(Container.DataItem, "BranchId") %>.jpg"/></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>
        <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetContacts" TypeName="FEDISSERVICE.WebService1SoapClient"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </form>
</body>
</html>
