<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBoxListAndListBoxRealTimeExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" Width="213px" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
        </asp:CheckBoxList><br />
        <asp:ListBox ID="mainListBox" runat="server" Height="190px" Width="215px"></asp:ListBox>
        <p>
            <asp:Label ID="checkBoxStatusLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
