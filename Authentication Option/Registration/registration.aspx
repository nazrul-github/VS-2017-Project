<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Authentication_Option.Registration.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table>
               <thead>
               <tr>
                   <td colspan="2">User Registration</td>
               </tr>
               </thead>
               <tr>
                   <td>User Name:</td>
                   <td>
                       <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox></td>
               </tr> <tr>
                   <td>Password:</td>
                   <td>
                       <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server"></asp:TextBox></td>
               </tr> <tr>
                   <td>Confirm Password:</td>
                   <td>
                       <asp:TextBox ID="confirmpasswordTextBox" TextMode="Password" runat="server"></asp:TextBox></td>
               </tr><tr>
                   <td>Email:</td>
                   <td>
                       <asp:TextBox ID="emailTextBox" TextMode="Email" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                  <td colspan="2">
                      <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />
                  </td>
               </tr> <tr>
                  <td colspan="2">
                      <asp:Label ID="msgLabel" runat="server" ></asp:Label>
                  </td>
               </tr>
           </table>
        </div>
    </form>
</body>
</html>
