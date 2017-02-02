<%@ Control 
    Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="TreeView.ascx.cs" 
    Inherits="WebClient.UserControls.TreeView" %>

<h3>Display XML file downloaded from <a href="http://www.w3schools.com/xml/simple.xml">here</a> with TreeView Control</h3>

<asp:XmlDataSource
        ID="XmlDataSource"
        runat="server"/>

<asp:TreeView runat="server" ID="XmlTreeView" DataSourceID="XmlDataSource" OnSelectedNodeChanged="XmlTreeView_SelectedNodeChanged">

</asp:TreeView>