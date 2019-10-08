<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBoxContron.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <fieldset style="width:400px">
                <legend>Education</legend>

                <asp:CheckBox ID="graduateTextBox" runat="server" Text="Graduate" AutoPostBack="True" OnCheckedChanged="graduateTextBox_CheckedChanged" />
                <asp:CheckBox ID="postGraduateTextBox" runat="server" Text="Post Graduate" />
                <asp:CheckBox ID="doctorateTextBox" runat="server" Text="Doctorate" />

            </fieldset>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
