<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="MobileSite.About" %>

<%@ Register Src="~/UserControls/SearchMenu.ascx" TagPrefix="uc" TagName="searchmenu"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div class="container">
        <uc:searchmenu runat="server" />
    </div>
</asp:Content>
