<%@ Page Title="Print name" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="PrintName.aspx.cs" Inherits="HomeworkTasks.PrintName" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <span>Enter your name: </span>
    <asp:TextBox runat="server" ID="InputName" />
    <asp:Button runat="server" OnClick="Unnamed_Click" Text="Click me!" />
    <br />
    <asp:Label runat="server" ID="Result" />
</asp:Content>
