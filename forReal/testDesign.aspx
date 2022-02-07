<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testDesign.aspx.cs" Inherits="forReal.WebForm3" %>

<%@ Register TagPrefix="uc" TagName="fakeForm" Src="~/MyfirstWebFormControl.ascx" %>
                    <%-- this is how you use user control--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:fakeForm runat="server"></uc:fakeForm>
        </div>
    </form>
</body>
</html>
