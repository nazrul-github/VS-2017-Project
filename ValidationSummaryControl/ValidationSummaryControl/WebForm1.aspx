<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationSummaryControl.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>User Information</legend>
        <table style="width: 500px; border: 1px solid black">
            <tr>
                <td class="text-right" style="font-size: medium; width: 195px"><strong>Email</strong></td>
                <td>
                    <asp:TextBox ID="emailTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="emailTextBoxValidator" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ForeColor="red" SetFocusOnError="True" ErrorMessage="Email can't be empty">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="emailRegularExpressionValidate" runat="server" ForeColor="red" ControlToValidate="emailTextBox" SetFocusOnError="True" Display="Dynamic"  ErrorMessage="Email Address Is Not Valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 195px"><strong>User Name</strong></td>
                <td>
                    <asp:TextBox ID="userNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="userNameTextBoxValidator" runat="server" ControlToValidate="userNameTextBox" Display="Dynamic" ForeColor="red" SetFocusOnError="True" ErrorMessage="User Name can't be empty">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 195px"><strong>Password</strong></td>
                <td>
                    <asp:TextBox ID="passwordTextBox" CssClass="form-control" TextMode="Password" runat="server" Style="margin-left: 0"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="passwordTextBoxValidator" runat="server" ControlToValidate="passwordTextBox" Display="Dynamic" ForeColor="red" SetFocusOnError="True" ErrorMessage="password can't be empty">*</asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 195px"><strong>Confirm Password</strong></td>
                <td>
                    <asp:TextBox ID="confirmPasswordTextBox" CssClass="form-control" TextMode="Password" runat="server" Style="margin-left: 58"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="confirmPasswordTextBoxValidator" ControlToValidate="confirmPasswordTextBox" ForeColor="red" SetFocusOnError="True" Display="Dynamic"  runat="server" ErrorMessage="Please confirm the password">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="confirmPasswordTextBoxMatchValidator" ForeColor="red" Display="Dynamic" ControlToValidate="confirmPasswordTextBox" SetFocusOnError="True" ControlToCompare="passwordTextBox" Operator="Equal" runat="server" Type="String"  ErrorMessage="Password don't match">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 195px"></td>
                <td style="padding-top: 15px">
                    <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-primary" />

                </td>
            </tr>
            <tr>
                <td style="width: 195px" colspan="2">
                    <asp:ValidationSummary ForeColor="red" HeaderText="Validation Error" DisplayMode="SingleParagraph" ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
                </td>
                <td style="padding-top: 15px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 195px" colspan="2">
                    <asp:Label ID="msgLabel" runat="server"></asp:Label></td>
            </tr>

        </table>
    </fieldset>
</asp:Content>
