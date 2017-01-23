<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" ValidateRequest="false" CodeBehind="Escaping.aspx.cs" Inherits="Tasks_1___2.Escaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Escaping</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="input">Enter some text: </label>
            <input runat="server" class="form-control" id="input" type="text" value="" />
            <asp:Button runat="server" CssClass="btn btn-success"  OnClick="SubmitForm" Text="Submit" />
            <asp:RequiredFieldValidator runat="server"
                ForeColor="IndianRed"
                ControlToValidate="input"
                ErrorMessage="Add some text before submit" />
            <span runat="server" id="errorContainer"></span>
        </div>
    </form>
    <div>
        <h3>Result: </h3>
        <p runat="server" id="result"></p>
    </div>
</body>
</html>
