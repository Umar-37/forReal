<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="learnPostbackEvents.aspx.cs" Inherits="forReal.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="171px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
