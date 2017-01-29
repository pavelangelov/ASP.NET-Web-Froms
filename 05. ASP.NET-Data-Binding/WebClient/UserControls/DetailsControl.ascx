<%@ Control
    Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="DetailsControl.ascx.cs" 
    CodeFile="~/UserControls/DetailsControl.ascx.cs"
    Inherits="MobileSite.UserControls.DetailsControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div class="jumbotron">
        <h2>Employee details</h2>
        <asp:Image runat="server" ID="employeeImage" />
        <asp:DetailsView ID="Details" CssClass="table table-striped" runat="server"></asp:DetailsView>
        <asp:HyperLink runat="server" NavigateUrl="~/Employees.aspx" Text="Go back" />
    </div>
</body>
</html>
