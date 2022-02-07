<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="forReal.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%string omar = "myName is omar"; %><%= Title %>
    <%: Title %><!--Inline c# code (not recommended) --> 
    <h2><%-- here you can write c# comments  --%>.</h2> <!-- if you put = sign it will decode it as html but its not recommended-->
    <h2><%: Title %>.</h2> <!-- run it as pure text; i guess-->
    <%-- here you can write c# comments  --%>

    <h3>Your application description page.</h3>
    <h3>
        <asp:Button ID="btnSendInfo" runat="server" BorderStyle="Groove" OnClick="btnSendInfo_Click" OnCommand="btnSendInfo_Command" Text="Send info" Width="133px" />
    </h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>
