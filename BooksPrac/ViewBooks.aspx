<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBooks.aspx.cs" Inherits="BooksPrac.ViewBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="View Books"></asp:Label>
        </div>
        <asp:GridView ID="gvBooks" runat="server" SelectMethod="gvBooks_GetData">
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Menu.aspx">Back to menu</asp:HyperLink>
        <br />

        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AddBook.aspx">Add new Books</asp:HyperLink>
    </form>
</body>
</html>
