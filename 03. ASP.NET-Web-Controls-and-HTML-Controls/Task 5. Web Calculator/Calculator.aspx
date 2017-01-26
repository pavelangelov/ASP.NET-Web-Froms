<%@ Page 
    Title="Calculator" 
    MasterPageFile="~/Site.Master" 
    Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="Calculator.aspx.cs" 
    Inherits="Task_5.Web_Calculator.Calculator" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" >
    <div class="calculator">
        <div class="buttons">
            <span runat="server" id="result"></span>
        </div>
        <div class="buttons">
            <asp:Button runat="server" CssClass="button" Text="1" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="2" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="3" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="+" OnClick="SetOperator" />
            <asp:Button runat="server" CssClass="button" Text="4" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="5" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="6" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="-" OnClick="SetOperator" />
            <asp:Button runat="server" CssClass="button" Text="7" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="8" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="9" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="X" OnClick="SetOperator" />
            <asp:Button runat="server" CssClass="button" Text="Clear" OnClick="Reset" />
            <asp:Button runat="server" CssClass="button" Text="0" OnClick="FillNumber" />
            <asp:Button runat="server" CssClass="button" Text="/" OnClick="SetOperator" />
            <asp:Button runat="server" CssClass="button" Text="√" OnClick="Sqrt" />
        </div>
        <div class="buttons">
            <asp:Button runat="server" CssClass="button" Text="=" OnClick="Calculate" />
        </div>
    </div>
</asp:Content>