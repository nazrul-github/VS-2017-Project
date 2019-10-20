<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Regular_Expression_Validation_Check.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<table style="width: 500px; margin-top: 20px;">
    <tr>
        <td><strong>Email Address</strong></td>
        <td>
            <asp:TextBox ID="emailTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="emaialAddressValidator" SetFocusOnError="True" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" ErrorMessage="Please enter a valid mail address" Display="Dynamic " ControlToValidate="emailTextBox" ></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td></td>
        <td style="padding-top: 20px;">
            <asp:Button CssClass="btn btn-primary" ID="Button1"  runat="server" Text="Button" OnClick="Button1_Click" /></td>
    </tr>
    <tr>
        <td>
           <center><asp:Label ID="msgLabel" runat="server" Font-Bold="True" ></asp:Label></center> </td>
    </tr>
  
</table>
</asp:Content>
