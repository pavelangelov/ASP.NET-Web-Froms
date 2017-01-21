<%@ Page Title="Random Number Generator" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="RandomNumber.aspx.cs" Inherits="Tasks_1___2.RandomNumber" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div>
        <label for="FirstNumber">Min value: </label>
        <asp:TextBox runat="server" ID="FirstNumber" />
        <asp:RequiredFieldValidator runat="server"
            ControlToValidate="FirstNumber"
            ForeColor="IndianRed"
            ErrorMessage="First number field is required!" />
    </div>
    <div>
        <label for="SecondNumber">Max value: </label>
        <asp:TextBox runat="server" ID="SecondNumber" />
        <asp:RequiredFieldValidator runat="server"
            ControlToValidate="SecondNumber"
            ForeColor="IndianRed"
            ErrorMessage="Second number field is required!" />
    </div>

    <asp:Button runat="server" OnClick="GenerateRandomNumber" Text="Generate" />
    
    <div>
        <asp:Literal runat="server" ID="Result" />
    </div>
</asp:Content>
