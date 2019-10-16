<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BulletedList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Numbered" DisplayMode="LinkButton" FirstBulletNumber="10" OnClick="BulletedList1_Click" Target="_blank">
            <asp:ListItem Value="http://www.google.com" >Google</asp:ListItem>
            <asp:ListItem Value="http://www.yahoo.com">Yahoo</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
            <asp:ListItem>France</asp:ListItem>
        </asp:BulletedList>
    </form>
</body>
</html>
