<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Custom_Validator_Control.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <table style="width: 500px;">

        <tr>
            <td style="width: 232px; height: 68px;"><strong>Please enter a even number</strong></td>
            <td style="height: 68px">
                <asp:TextBox ID="numberTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidatorEven" ClientValidationFunction="IsEven" runat="server" ControlToValidate="numberTextBox" ForeColor="red" SetFocusOnError="True" Display="Dynamic" ErrorMessage="Please Enter An Even Number" OnServerValidate="CustomValidatorEven_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
            </td>
        </tr>
        <tr style="padding-top: 10px">
            <td style="width: 232px">
                <center><asp:Button ID="submitButton" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="submitButton_Click" /></center>
            </td>
        </tr>
        <tr style="padding-top: 10px">
            <td style="width: 232px">
                <center><asp:Label ID="msgLabel" runat="server" ></asp:Label></center>
            </td>
        </tr>

    </table>
    <script language="javascript" type="text/javascript">
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            } else {
                if (args.Value % 2 == 0) {
                    args.IsValid = true;
                } else {
                    args.IsValid = false;
                }
            }

        }
    </script>

</asp:Content>
