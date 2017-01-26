<%@ Page Title="Personal info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="Task_1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Info about the user.</h2>
    <div class="col-sm-3">
        <img src="/images/user-img.png"
            class="rounded user-img"
             alt="" />
    </div>
    <dl class="dl-horizontal text-info col-sm-9">
        <dt>Username:</dt>
        <dd>Some name</dd>
        <dt>First name:</dt>
        <dd>User first name</dd>
        <dt>Last name:</dt>
        <dd>User last name</dd>
        <dt>Age:</dt>
        <dd>42 (maybe)</dd>
        <dt>Sex:</dt>
        <dd>Other</dd>
        <dt>Country:</dt>
        <dd>Bulgaria</dd>
        <dt>City:</dt>
        <dd>Not set</dd>
    </dl>
</asp:Content>
