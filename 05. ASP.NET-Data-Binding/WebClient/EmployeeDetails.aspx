<%@ Page
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="EmployeeDetails.aspx.cs"
    Inherits="MobileSite.EmployeeDetails" %>

<%@ Register Src="~/UserControls/DetailsControl.ascx" TagPrefix="uc" TagName="details" %>

<asp:Content runat="server"  ContentPlaceHolderID="MainContent">

    <div class="container">
        <uc:details runat="server"></uc:details>
    </div>

</asp:Content>
