<%@ Page 
    Title="Three view" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="TreeView.aspx.cs" 
    Inherits="WebClient.TreeView" %>

<%@ Register Src="~/UserControls/TreeView.ascx" TagPrefix="uc" TagName="treeview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc:treeview runat="server"></uc:treeview>
</asp:Content>
