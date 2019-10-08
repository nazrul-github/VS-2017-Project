<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperLinkControl.aspx.cs" Inherits="hyperlinkControl.HyperLinkControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:10vh; height:50vh">
        <asp:HyperLink ID="HyperLink1" Width="100%" runat="server" Text="Go to Google" Target="_blank" NavigateUrl="http://www.google.com" ImageUrl="~/Images/evan.jpg"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
