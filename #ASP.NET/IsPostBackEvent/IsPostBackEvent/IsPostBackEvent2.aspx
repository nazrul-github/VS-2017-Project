<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IsPostBackEvent2.aspx.cs" Inherits="IsPostBackEvent.IsPostBackEvent2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family: Arial">
                <tr>
                    <td colspan="2"><strong>Employee Details Form</strong></td>
                </tr>
                <tr>
                    <td>First Name: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ciry</td>

                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server" >
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                    <asp:Button ID="Button1" runat="server" Text="Register Employee" />
                        </td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
