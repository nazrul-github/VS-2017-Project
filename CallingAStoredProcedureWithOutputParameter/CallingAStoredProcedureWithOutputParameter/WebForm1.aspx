<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CallingAStoredProcedureWithOutputParameter.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="margin-bottom: 205px; border: 1px solid black; font-family: Arial">
        <tr>
            <td style="height: 20px; width: 379px;">Employee Name</td>
            <td style="height: 20px">
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>

        </tr>

        <tr>
            <td style="width: 379px">Gender</td>
            <td><asp:DropDownList ID="genderDropDownList" runat="server" Height="16px" Width="141px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 379px">Salary</td>
            <td><asp:TextBox ID="salaryTextBox" runat="server" Width="136px"></asp:TextBox></td>

        </tr>
        <tr>
            <td style="width: 379px">
                <asp:Button ID="submitButton" runat="server" Text="Submit" Width="209px" OnClick="submitButton_Click" /></td>


        </tr>
        <tr>
            <td style="width: 379px">
                <asp:Label ID="successLabel" runat="server"></asp:Label></td>


        </tr>
    </table>
</asp:Content>
