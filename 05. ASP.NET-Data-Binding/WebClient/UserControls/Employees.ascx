﻿<%@
    Control
    Language="C#"
    AutoEventWireup="true"
    CodeBehind="Employees.ascx.cs"
    CodeFile="~/UserControls/Employees.ascx.cs"
    Inherits="WebClient.UserControls.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div class="jumbotron">
        <h3>Click the employee name for more details.</h3>
        <asp:GridView 
            runat="server" 
            CssClass="table table-hover" 
            ID="EmployeesTable" 
            AllowPaging="true" 
            AutoGenerateColumns="false" 
            ItemType="DataServices.Contracts.IEmployeeViewModel">
            <Columns>
                <asp:TemplateField HeaderText="Employee name">
                    <ItemTemplate>
                        <a href="EmployeeDetails?id=<%# Item.Id %>"><%# Item.Name%></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <a href="EmployeeDetailsFormView?id=<%# Item.Id %>">View details in FormView</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</body>
</html>
