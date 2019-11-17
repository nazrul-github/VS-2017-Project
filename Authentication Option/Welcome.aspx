<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Authentication_Option.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul class="nav navbar-nav">
                <li><a runat="server" id="adminLink" visible="false" 
                       href="~/Admin/AdminPage.aspx">Admin</a></li> <!---by default this link is not visible only specific user can see this link-->
                <li><a runat="server" href="~/">Home</a></li>
                <li><a runat="server" href="~/About">About</a></li>
                <li><a runat="server" href="~/Contact">Contact</a></li>
                <li><a runat="server" href="~/ProductList">Products</a></li>
                <li><a runat="server" href="~/ShoppingCart" id="cartCount">&nbsp;</a></li>
            </ul>
            <asp:Button ID="logoutButton" runat="server" Text="Logout" OnClick="logoutButton_Click" />
        </div>
    </form>
</body>
</html>
