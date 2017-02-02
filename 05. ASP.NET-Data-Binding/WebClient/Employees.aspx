<%@ Page Title="Northwind Employees" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="WebClient.Employees" %>

<%@ Register Src="~/UserControls/Employees.ascx" TagName="employees" TagPrefix="uc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <asp:HyperLink runat="server" NavigateUrl="~/AllEmployeesDetails.aspx" Text="See all employees with details" />
    <div class="container">
        <uc:employees runat="server"></uc:employees>
    </div>
</asp:Content>
