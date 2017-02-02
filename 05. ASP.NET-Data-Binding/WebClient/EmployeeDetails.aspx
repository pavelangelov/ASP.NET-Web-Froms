﻿<%@ Page
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="EmployeeDetails.aspx.cs"
    Inherits="WebClient.EmployeeDetails" %>

<%@ Register Src="~/UserControls/EmployeeDetails.ascx" TagPrefix="uc" TagName="details" %>

<asp:Content runat="server"  ContentPlaceHolderID="MainContent">

    <div class="container">
        <uc:details runat="server"></uc:details>
    </div>

</asp:Content>
