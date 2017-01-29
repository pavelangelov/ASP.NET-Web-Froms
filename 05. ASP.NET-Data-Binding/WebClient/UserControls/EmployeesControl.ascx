<%@
    Control
    Language="C#"
    AutoEventWireup="true"
    CodeBehind="EmployeesControl.ascx.cs"
    CodeFile="~/UserControls/EmployeesControl.ascx.cs"
    Inherits="MobileSite.UserControls.EmployeesControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div class="jumbotron">
        <asp:GridView runat="server" CssClass="table table-hover" ID="Employees" AllowPaging="true" AutoGenerateColumns="false" ItemType="DataServices.Contracts.IEmployeeViewModel">
            <Columns>
                <asp:TemplateField HeaderText="Employee name">
                    <ItemTemplate>
                        <a href="EmployeeDetails?id=<%# Item.Id %>"><%# Item.Name%></a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</body>
</html>
