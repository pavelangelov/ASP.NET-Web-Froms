<%@ Page Title="Http Handler" Language="C#" AutoEventWireup="true" CodeBehind="CustomHttpHandler.aspx.cs" Inherits="_01.ASP.NET_Web_Forms_application.CustomHttpHandler" %>

<h2>Custom Http Handler</h2>
<form action="Sample.img" method="get">
    <span>Send Get Request: </span>
    <input type="text"  name="q" />
    <input type="submit" value="Submit" />
</form>
<br />
<form action="Sample.img" method="post">
    <span>Send POST Request: </span>
    <input type="text" name="postValue" value="" />
    <input type="submit" value="Submit" />
</form>
<br />
<span runat="server" id="result"></span>
