<%@ Page 
    Title="All Employees" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="AllEmployeesDetails.aspx.cs" Inherits="WebClient.AllEmployeesDetails" %>

<%@ Register Src="~/UserControls/AllEmployeesDetails.ascx" TagPrefix="uc" TagName="AllEmployeesDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <uc:AllEmployeesDetails runat="server"></uc:AllEmployeesDetails>
</asp:Content>
