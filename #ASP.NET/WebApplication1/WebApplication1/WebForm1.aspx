<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" /><br />
        <asp:Button ID="Button2" runat="server" Text="Show" OnClick="Button2_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
