<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="Authentication_Option.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 379px;
        }
        .auto-style2 {
            width: 424px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style2">
        <div>
            <fieldset>
                <legend>Login</legend>
                <table class="auto-style1">
                    <tr>
                        <td>
                            User Name
                        </td>
                        <td>
                            <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>  <tr>
                        <td>
                           Password
                        </td>
                        <td>
                            <asp:TextBox ID="passwrodTextBox" TextMode="Password" runat="server"></asp:TextBox>
                        </td>
                    </tr> <tr>
                        <td>
                            <asp:RadioButton ID="rememeberRadioButton" Text="Remember Me" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
                        </td>
                    </tr> <tr>
                        <td colspan="2">
                            <asp:Label ID="msgLabel" runat="server" ></asp:Label>
                        </td>
                        
                    </tr>
                </table>
                <a href="Registration/registration.aspx">Click here to register</a>
            </fieldset>
        </div>
    </form>
</body>
</html>
