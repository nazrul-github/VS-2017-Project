<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonControl.aspx.cs" Inherits="RadioButtonControl.RadioButtonControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <fieldset style="width:300px">
                <legend>Gender</legend>

                <asp:RadioButton ID="maleRadioButton" runat="server" Text="Male" GroupName="genderGroup" />
                <asp:RadioButton ID="femaleRadioButton" runat="server" Text="Female" GroupName="genderGroup" />
                <asp:RadioButton ID="unknownRadioButton" runat="server" Text="Unknown" GroupName="genderGroup" />

            </fieldset>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
