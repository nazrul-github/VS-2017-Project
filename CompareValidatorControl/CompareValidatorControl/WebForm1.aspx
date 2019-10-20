<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompareValidatorControl.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset style="width: 600px; margin: 30px;">
        <legend>Compare Field Validator</legend>
        <table style="width: 110%; height: 250px; margin-right: 72px;" class="nav-justified">
            <tr>
                <td class="text-right" style="width: 128px; padding: 15px;">Password</td>
                <td>
                    <input id="typePasswordTextBo" class="form-control" runat="server" type="password" style="width: 150px;" />
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 128px; padding: 15px;">Retype Password</td>
                <td>
                    <input id="retypePasswrodTextBox" class="form-control" runat="server" type="password" style="width: 150px;" />
                    <asp:CompareValidator ID="typePasswordTextBoxCompareValidator" ForeColor="red" runat="server" SetFocusOnError="True" ControlToCompare="typePasswordTextBo" ControlToValidate="retypePasswrodTextBox" Display="Dynamic" Type="String" Operator="Equal" ErrorMessage="Password doesn't match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 128px; padding: 15px;">Date Of Application</td>
                <td>
                    <input id="dateInputTextBox" runat="server" class="form-control" type="date" style="width: 150px;" />
                    <asp:CompareValidator ID="CompareValidator1" ControlToValidate="dateInputTextBox" Display="Dynamic" ForeColor="red" Type="Date" ValueToCompare="01/01/2008" Operator="LessThan" runat="server" ErrorMessage="Date of application must be less than 01/01/2008"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 128px; padding: 15px;">Age</td>
                <td>
                    <input id="ageTextBox" runat="server" class="form-control" type="text" style="width: 150px;" />
                    <asp:CompareValidator ID="ageTextBoxValidation" runat="server" ControlToValidate="ageTextBox" Operator="DataTypeCheck" ForeColor="red" ErrorMessage="Age Must Be A Number" Type="Integer" Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 128px"></td>
                <td>
                    <asp:Button ID="submitButton" CssClass="btn-primary btn" runat="server" Text="Submit" OnClick="submitButton_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 128px">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>

        </table>
    </fieldset>
</asp:Content>
