<%@ Control
    Language="C#"
    AutoEventWireup="true"
    CodeBehind="EmployeeDetailsFormView.ascx.cs"
    CodeFile="~/UserControls/EmployeeDetailsFormView.ascx.cs"
    Inherits="WebClient.UserControls.EmployeeDetailsFormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div class="jumbotron">
        <h2>Employee details with FormView</h2>
        <asp:FormView
            runat="server"
            ItemType="DataServices.CurrentEmployeeViewModel"
            ID="EmployeeDetails">
            <ItemTemplate>
                <table class="table table-striped">
                    <tr>
                        <td>Title Of Courtesy: </td>
                        <td><%# Item.TitleOfCourtesy %></td>
                    </tr>
                    <tr>
                        <td>First Name: </td>
                        <td><%# Item.FirstName %></td>
                    </tr>
                    <tr>
                        <td>Last Name: </td>
                        <td><%# Item.LastName %></td>
                    </tr>
                    <tr>
                        <td>Country: </td>
                        <td><%# Item.Country %></td>
                    </tr>
                    <tr>
                        <td>City: </td>
                        <td><%# Item.City %></td>
                    </tr>
                    <tr>
                        <td>Address: </td>
                        <td><%# Item.Address %></td>
                    </tr>
                    <tr>
                        <td>Birth date: </td>
                        <td><%# Item.BirthDate %></td>
                    </tr>
                    <tr>
                        <td>Title: </td>
                        <td><%# Item.Title %></td>
                    </tr>
                    <tr>
                        <td>Hire date: </td>
                        <td><%# Item.HireDate %></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
        <asp:HyperLink runat="server" NavigateUrl="~/Employees.aspx" Text="Go back" />
    </div>
</body>
</html>
