<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationGroups.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" language="javascript">
        function ValidLength 2(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            } else {
                if (args.Value.Length < 3) {
                    args.IsValid = false;
                } else {
                    args.IsValid = true;
                }
            }
        }
        function ValidLength(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            } else {
                if (args.Value.length > 3) {
                    args.IsValid = true;
                } else {
                    args.IsValid = false;
                }
            }
        }

        function IsEighteen(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            } else {
                if (args.Value > 18) {
                    args.IsValid = true;
                } else {
                    args.IsValid = false;
                }
            }
        }

    </script>
    <table style="width: 552px;">
        <tr>
            <td colspan="2">
                <h2 dir="ltr" class="text-center">Login</h2>
            </td>
        </tr>
        <tr>
            <td style="padding: 20px; width: 153px; font-size: medium;" class="text-right"><strong>User Name</strong></td>
            <td style="width: 233px">
                <asp:TextBox ID="userNameTextBox" CssClass="form-control" runat="server" ValidationGroup="LogInValidator"></asp:TextBox></td>
            <td>
                <asp:CustomValidator  ClientValidationFunction="ValidLength"  ID="userNameTextBoxValidator" ControlToValidate="userNameTextBox" Display="Dynamic" ForeColor="red" SetFocusOnError="True" runat="server" ErrorMessage="User Name Must Be More Than Two Character" Text="*" OnServerValidate="userNameTextBoxValidator_ServerValidate" ValidationGroup="LogInValidator"></asp:CustomValidator>
                <asp:RequiredFieldValidator  ID="userNameTextBoxRequiredValidator"  ForeColor="red" ControlToValidate="userNameTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" runat="server" ErrorMessage="User Name is required" ValidationGroup="LogInValidator"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="padding: 20px; width: 153px; font-size: medium;" class="text-right"><strong>Password</strong></td>
            <td style="width: 233px">
                <asp:TextBox ID="passwordTextBox" TextMode="Password" CssClass="form-control" runat="server" ValidationGroup="LogInValidator"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="passwordTextBoxValidator" ForeColor="red" Display="Dynamic" SetFocusOnError="True" ControlToValidate="passwordTextBox" runat="server" ErrorMessage="Password is required" Text="*" ValidationGroup="LogInValidator"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="1" style="padding: 10px" aria-orientation="horizontal" dir="rtl">
                <asp:Button ID="loginButton" CssClass="btn btn-success" runat="server" Text="Login" OnClick="loginButton_Click" ValidationGroup="LogInValidator" /></td>
            <td colspan="2">
                <asp:Label ID="msgLabel" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="validationSummary" DisplayMode="List" ForeColor="red" HeaderText="Validation Failed!!" runat="server" ValidationGroup="LogInValidator" />
            </td>
        </tr>
    </table>

    <table align="right" cellpadding="10" cellspacing="5" style="width: 662px; float: left">
        <tr>
            <td colspan="3">
                <h2 class="text-center">User Registration</h2>
            </td>

        </tr>
        <tr>
            <td style="padding: 10px; font-size: medium; font-weight: bold; width: 227px;" class="text-right">Email:</td>
            <td style="height: 53px; width: 292px;">
                <asp:TextBox ID="emailTextBox" CssClass="form-control" TextMode="Email" runat="server" Width="268px" ValidationGroup="RegistrationValidation"></asp:TextBox></td>
            <td style="height: 53px">
                <asp:RegularExpressionValidator ID="emailTypeValidator" ForeColor="red" ControlToValidate="emailTextBox" SetFocusOnError="True" runat="server" ErrorMessage="Please input valid email address" Display="Dynamic" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="emailRequiredValidator" runat="server" Text="*" ErrorMessage="Email is required" ForeColor="red" Display="Dynamic" SetFocusOnError="True" ControlToValidate="emailTextBox" ValidationGroup="RegistrationValidation"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="padding: 10px; font-size: medium; font-weight: bold; width: 227px;">User Name</td>
            <td style="width: 292px">
                <asp:TextBox ID="userNameTextBoxRegistration" CssClass="form-control" runat="server" Width="268px"  ValidationGroup="RegistrationValidation"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="userNameTextBoxRegistrationValidation" runat="server"  ErrorMessage="User Name Is Required" Display="Dynamic" ForeColor="red" ControlToValidate="userNameTextBoxRegistration" SetFocusOnError="True" Text="*" ValidationGroup="RegistrationValidation"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="padding: 10px; font-size: medium; font-weight: bold; width: 227px;">Password</td>
            <td style="height: 53px; width: 292px">
                <asp:TextBox ID="passwordTextBoxRegistration" TextMode="Password" CssClass="form-control" runat="server" Width="268px" ValidationGroup="RegistrationValidation"></asp:TextBox></td>
            <td style="height: 53px">
                <asp:RequiredFieldValidator ID="passwordTextBoxRegistrationRequired" runat="server" ErrorMessage="Please enter password" Display="Dynamic" Text="*" ForeColor="red" ControlToValidate="passwordTextBoxRegistration" SetFocusOnError="True" ValidationGroup="RegistrationValidation"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="text-right" style="padding: 10px; font-size: medium; font-weight: bold; width: 227px;">Confirm Password</td>
            <td style="width: 292px">
                <asp:TextBox ID="confirmPasswordTextBox" TextMode="Password" CssClass="form-control" runat="server" Width="268px" ValidationGroup="RegistrationValidation"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="confirmPasswordTextBoxCompare" runat="server" ErrorMessage="Both passwrod's should be same" Text="*" ForeColor="red" Display="Dynamic" ControlToValidate="confirmPasswordTextBox" SetFocusOnError="True" ControlToCompare="passwordTextBoxRegistration" Operator="Equal" Type="String" ValidationGroup="RegistrationValidation"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="padding: 10px; font-size: medium; font-weight: bold; width: 227px;">Age</td>
            <td style="width: 292px">
                <asp:TextBox ID="ageTextBox" TextMode="Number" CssClass="form-control" runat="server" Width="268px" ValidationGroup="RegistrationValidation"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="ageTextBoxRequiredValidator" runat="server" ErrorMessage="Please enter your age" Text="*" ForeColor="red" Display="Dynamic" ControlToValidate="ageTextBox" SetFocusOnError="True" ValidationGroup="RegistrationValidation"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="ageNumberValidator" Text="*" ForeColor="red" Display="Dynamic" ControlToValidate="ageTextBox" SetFocusOnError="True" Type="Integer" Operator="DataTypeCheck" runat="server" ErrorMessage="Please input valid age"></asp:CompareValidator>
                <asp:CustomValidator ID="ageTextBoxCustomValidator" runat="server" ErrorMessage="Age must be more than 18" Text="*" ForeColor="red" Display="Dynamic" ControlToValidate="ageTextBox" SetFocusOnError="True" ClientValidationFunction="" OnServerValidate="ageTextBoxCustomValidator_ServerValidate" ValidateEmptyText="True" ValidationGroup="RegistrationValidation"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="padding: 10px; font-size: medium; font-weight: bold; width: 227px;">Opening Date</td>
            <td style="width: 292px">
                <asp:TextBox ID="openingDateTextBox" TextMode="Date" CssClass="form-control" runat="server" Width="268px" ValidationGroup="RegistrationValidation"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="openingDateTextBoxValidator" Text="*" ForeColor="red" Display="Dynamic" ControlToValidate="openingDateTextBox" SetFocusOnError="True" runat="server" ErrorMessage="Please select your opening date" ValidationGroup="RegistrationValidation"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 227px">
                <asp:Button ID="registerButton" runat="server" Text="Register" CssClass="btn btn-primary" ValidationGroup="RegistrationValidation" OnClick="registerButton_Click"  /></td>
            
              <td>  <asp:Button ID="clearButton" runat="server" Text="Clear" CssClass="btn btn-info" OnClick="clearButton_Click" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="msgLabelForRegistration" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="registrationValidationSummary" ForeColor="red" DisplayMode="List" HeaderText="Validation Failed!!"  runat="server" ValidationGroup="RegistrationValidation" />
            </td>
        </tr>
    </table>

</asp:Content>
