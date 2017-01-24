<%@ Page Title="Tic-Tac-Toe" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Tic-Tac-Toe.aspx.cs" Inherits="Task_4.Tic_tac_toe.Tic_Tac_Toe" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h2>Tic-Tac-Toe</h2>
    <table class="game-field">
        <tr>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button1" data-id="0" CssClass="field" />
            </td>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button2" data-id="1" CssClass="field" />
            </td>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button3" data-id="2" CssClass="field" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button4" data-id="3" CssClass="field" />
            </td>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button5" data-id="4" CssClass="field" />
            </td>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button6" data-id="5" CssClass="field" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button7" data-id="6" CssClass="field" />
            </td>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button8" data-id="7" CssClass="field" />
            </td>
            <td>
                <asp:Button runat="server" OnClick="Unnamed_Click" ID="Button9" data-id="8" CssClass="field" />
            </td>
        </tr>
    </table>

    <h2 runat="server" id="winner"></h2>
    <asp:Button runat="server" ID="Restart" PostBackUrl="~/Tic-Tac-Toe.aspx" Text="New Game" CssClass="btn btn-success" Visible="false" />
</asp:Content>
