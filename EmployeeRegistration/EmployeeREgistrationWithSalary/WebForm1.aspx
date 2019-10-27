<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeREgistrationWithSalary.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset style="margin: 20px 200px">
        <legend>Employee Registration Form</legend>

        <table class="nav-justified" style="width: 76%">
            <tr style="padding-bottom: 20px">
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Name</strong></td>
                <td>
                    <asp:TextBox ID="employeeNameTextBox" CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="employeeNameTextBoxValidator" runat="server" ControlToValidate="employeeNameTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="Employee Name Is Required"></asp:RequiredFieldValidator></td>
            </tr>
            <tr style="margin: 20px">
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Email Address</strong></td>
                <td>
                    <asp:TextBox ID="emailAddressTextBox" CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="emailAddressTextBoxValidator" runat="server" ControlToValidate="emailAddressTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="Email address is required" ForeColor="Red"></asp:RequiredFieldValidator></td>
                <asp:RegularExpressionValidator ID="emailAddressRegularExpressionValidator1" runat="server" ErrorMessage="Email address must be in correct format" ControlToValidate="emailAddressTextBox" Display="Dynamic" SetFocusOnError="True" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Mobile Number</strong></td>
                <td>
                    <asp:TextBox ID="mobileNumberTextBox" CssClass="form-control" runat="server" style="margin-left: 0"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="mobileNumberTextBoxValidator" runat="server" ControlToValidate="mobileNumberTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="Mobile number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="mobileNumberTextBoxLengthValidator" runat="server" ErrorMessage="Mobile Number Should be 11 digit" ForeColor="red" Text="*" Display="Dynamic" ControlToValidate="mobileNumberTextBox" SetFocusOnError="True" OnServerValidate="mobileNumberTextBoxLengthValidator_ServerValidate"></asp:CustomValidator>
                </td>

            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 341px"><strong>District</strong></td>
                <td>
                    <asp:TextBox ID="districtTextBox" CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="districtTextBoxValidator" runat="server" ControlToValidate="districtTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="District is required" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Gender</strong></td>
                <td>
                    <asp:DropDownList ID="genderDropDownList" runat="server" Height="81px" Width="189px">
                        <asp:ListItem Text="--Select Gender--" runat="server" Selected="True" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Male" runat="server" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" runat="server" Value="Female"></asp:ListItem>
                    </asp:DropDownList>
                <td>
                    <asp:RequiredFieldValidator ID="genderDropDownListValidator" runat="server" ControlToValidate="genderDropDownList" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="Please select gender" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Date of birth</strong></td>
                <td>
                    <asp:TextBox ID="dateSelectTextBox" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="dateSelectTextBoxValidator" runat="server" ControlToValidate="dateSelectTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="Select the birth date" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="dateSelectTextBoxValidatorRangeValidator" runat="server" ErrorMessage="Age must be 18" Type="Date" Display="Dynamic" ControlToValidate="dateSelectTextBox" ForeColor="red" MaximumValue="31/12/2009" MinimumValue="01/01/1950" SetFocusOnError="True" Text="*"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Registration Number</strong></td>
                <td>
                    <asp:TextBox ID="registrationNumberTextBox" CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="registrationNumberTextBoxValidator" runat="server" ControlToValidate="registrationNumberTextBox" Display="Dynamic" Text="*" SetFocusOnError="True" ErrorMessage="Registration number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ID="registrationNumberTextBoxDigitValidator" Text="*" Display="Dynamic" ControlToValidate="registrationNumberTextBox" SetFocusOnError="True" ForeColor="red" Type="Integer" ErrorMessage="Registration Number Must Be Digit" Operator="DataTypeCheck" ></asp:CompareValidator>
                </td>

            </tr>
            <tr>
                <td class="text-right" style="font-size: medium; width: 341px"><strong>Department</strong></td>
               <td><asp:DropDownList runat="server" ID="ddlDepartment" Height="81px" Width="189px"/></td> 
            </tr>
            <tr >
                <td class="text-center align-content-xl-around" colspan="3">
                    <asp:Button  ID="saveButton" runat="server" Text="Save" CssClass="btn  btn-default" OnClick="saveButton_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button CssClass="btn btn-success" ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />

                <td>

            </tr>
            <tr >
                <td colspan="3" style="padding: 20px" class="text-center">
                    <asp:Label ID="msgLabel" runat="server" ></asp:Label></td>
               
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red" DisplayMode="List" HeaderText="Validation Failed!!!"  runat="server" />
                </td>
            </tr>
           
        </table>

    </fieldset>
</asp:Content>
