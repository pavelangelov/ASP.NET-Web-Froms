<%@ Page 
    Title="Employee details" 
    Language="C#" 
    MasterPageFile="~/Site.Master"
     AutoEventWireup="true" 
    CodeBehind="EmployeeDetailsFormView.aspx.cs" 
    Inherits="WebClient.EmployeeDetailsFormView" %>

<%@ Register Src="~/UserControls/EmployeeDetailsFormView.ascx" TagPrefix="uc" TagName="employeeDetailsFormView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc:employeeDetailsFormView runat="server"></uc:employeeDetailsFormView>
</asp:Content>
