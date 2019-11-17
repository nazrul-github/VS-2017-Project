<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Authentication_Option.Admin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Administration</h1>
    <hr />
    <h3>Add Product:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelAddCategory" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddCategory" runat="server"
                    ItemType="WingtipToys.Models.Category"
                    SelectMethod="GetCategories" DataTextField="CategoryName"
                    DataValueField="CategoryID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Product
name required."
                    ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic">
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddDescription" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductDescription" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*
Description required."
                    ControlToValidate="AddProductDescription" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddPrice" runat="server">Price:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Price
required."
                    ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic">
1. In Solution Explorer, open the AdminPage.aspx file from the Admin folder.
2. Replace the existing markup with the following:required." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="*
Must be a valid price without $."
                    ControlToValidate="AddProductPrice" SetFocusOnError="True"
                    Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ProductImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image
path required."
                    ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic">
                </asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddProductButton" runat="server" Text="Add Product"
        OnClick="AddProductButton_Click" CausesValidation="true" />
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remove Product:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelRemoveProduct" runat="server">Product:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemoveProduct" runat="server"
                    ItemType="WingtipToys.Models.Product"
                    SelectMethod="GetProducts" AppendDataBoundItems="true"
                    DataTextField="ProductName" DataValueField="ProductID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveProductButton" runat="server" Text="Remove Product"
        OnClick="RemoveProductButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label><h1>Administration</h1>
    <hr />
    <h3>Add Product:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"
                    ItemType="WingtipToys.Models.Category"
                    SelectMethod="GetCategories" DataTextField="CategoryName"
                    DataValueField="CategoryID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="* Product
name required."
                    ControlToValidate="AddProductName" SetFocusOnError="true" Display="Dynamic">
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="*
Description required."
                    ControlToValidate="AddProductDescription" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server">Price:</asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Text="* Price
required."
                    ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic">
1. In Solution Explorer, open the AdminPage.aspx file from the Admin folder.
2. Replace the existing markup with the following:required." ControlToValidate="AddProductPrice" SetFocusOnError="true" Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Text="*
Must be a valid price without $."
                    ControlToValidate="AddProductPrice" SetFocusOnError="True"
                    Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="* Image
path required."
                    ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic">
                </asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="Button1" runat="server" Text="Add Product"
        OnClick="AddProductButton_Click" CausesValidation="true" />
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remove Product:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server">Product:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server"
                    ItemType="WingtipToys.Models.Product"
                    SelectMethod="GetProducts" AppendDataBoundItems="true"
                    DataTextField="ProductName" DataValueField="ProductID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="Button2" runat="server" Text="Remove Product"
        OnClick="RemoveProductButton_Click" CausesValidation="false" />
    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
</body>
</html>
