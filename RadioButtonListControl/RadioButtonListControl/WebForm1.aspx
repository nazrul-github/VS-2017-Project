<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButtonListControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatLayout="UnorderedList">
            <asp:ListItem>Red</asp:ListItem>
            <asp:ListItem>Green</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
            <asp:ListItem>Orange</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />&nbsp &nbsp&nbsp
        <asp:Button ID="Button2" runat="server" Text="Clear Selection" OnClick="Button2_Click" />
    </form>
</body>
</html>
