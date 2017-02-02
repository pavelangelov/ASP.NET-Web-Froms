<%@ Control
    Language="C#"
    AutoEventWireup="true"
    CodeBehind="AllEmployeesDetails.ascx.cs"
    Inherits="WebClient.UserControls.AllEmployeesDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div class="jumbotron">
        <h2>All Northwind employees</h2>
        <asp:Repeater runat="server" ID="EmployeesRepeater" ItemType="DataServices.CurrentEmployeeViewModel">
            <ItemTemplate>
                <div class="list-group">
                    <div class="list-group-item">
                        <span>Title Of Courtesy: </span>
                        <span class="text-danger"><%# Item.TitleOfCourtesy %></span>
                    </div>
                    <div class="list-group-item">
                        <span>First Name: </span>
                        <span class="text-danger"><%# Item.FirstName %></span>
                    </div>
                    <div class="list-group-item">
                        <span>Last Name: </span>
                        <span class="text-danger"><%# Item.LastName %></span>
                    </div>
                    <div class="list-group-item">
                        <span>Country: </span>
                        <span class="text-danger"><%# Item.Country %></span>
                    </div>
                    <div class="list-group-item">
                        <span>City: </span>
                        <span class="text-danger"><%# Item.City %></span>
                    </div>
                    <div class="list-group-item">
                        <span>Address: </span>
                        <span class="text-danger"><%# Item.Address %></span>
                    </div>
                    <div class="list-group-item">
                        <span>Birth date: </span>
                        <span class="text-danger"><%# Item.BirthDate %></span>
                    </div>
                    <div class="list-group-item">
                        <span>Title: </span>
                        <span class="text-danger"><%# Item.Title %></span>
                    </div>
                    <div class="list-group-item">
                        <span>Hire date: </span>
                        <span class="text-danger"><%# Item.HireDate %></span>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</body>
</html>
