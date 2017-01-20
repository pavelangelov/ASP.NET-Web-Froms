<%@ Page Title="Calculate sum of two numbers" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Calculator.aspx.cs" Inherits="_01.ASP.NET_Web_Forms_application.Calculator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <input type="number" runat="server" id="firstNumber" value="" />
    <span> + </span>
    <input type="number" runat="server" id="secondNumber" value="" />
    <asp:Button Text="Sum" runat="server" OnClick="CalculateSum" />
    <br />
    <span runat="server" id="result"></span>
</asp:Content>
