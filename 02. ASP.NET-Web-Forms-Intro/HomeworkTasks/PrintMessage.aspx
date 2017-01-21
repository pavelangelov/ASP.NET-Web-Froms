<%@ Page Title="Print Message" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="PrintMessage.aspx.cs" Inherits="HomeworkTasks.PrintMessage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Message printed  from the <b>C#</b> code!</h3>
    <div>
        <asp:Literal runat="server" ID="MessageBox" />
    </div>

    <h3>Message printed  from the <b>aspx</b> code!</h3>
    <div>Hello, ASP.NET</div>

    <hr />

    <asp:Button runat="server" Text="Show Assembly Location" OnClick="ShowAssemblyLocation" />
    <div>
        <asp:Literal runat="server" ID="assemblyInfo" />
    </div>
</asp:Content>
