<%@ Page Title="Student registration" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="Task_3.Students_and_Courses.StudentRegistration" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="form-group col-sm-offset-2">
        <label for="FirstName">First name: </label>
        <asp:RequiredFieldValidator 
                runat="server" 
                ForeColor="IndianRed" 
                ControlToValidate="Firstname" 
                ErrorMessage="First name is required" />
        <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" />

        <label for="LastName">Last name: </label>
        <asp:RequiredFieldValidator 
                runat="server" 
                ForeColor="IndianRed" 
                ControlToValidate="LastName" 
                ErrorMessage="Last name is required" />
        <asp:TextBox runat="server" ID="LastName" CssClass="form-control" />

        <label for="FacultyNumber">Faculty number: </label>
        <asp:RequiredFieldValidator 
                runat="server" 
                ForeColor="IndianRed" 
                ControlToValidate="FacultyNumber" 
                ErrorMessage="Faculty number is required" />
        <asp:TextBox runat="server" ID="FacultyNumber" CssClass="form-control" />

        <label for="University">University</label>
        <asp:DropDownList runat="server" ID="University" CssClass="form-control" Width="280" >
            <asp:ListItem Text="New Bulgarian" Value="New Bulgarian" />
            <asp:ListItem Text="Sofia University" Value="Sofia University" />
            <asp:ListItem Text="Other University" Value="Other University" />
            <asp:ListItem Text="Another University" Value="Another University" />
        </asp:DropDownList>
        <label for="Specialty">Specialty</label>
        <asp:DropDownList runat="server" ID="Specialty" CssClass="form-control" Width="280" >
            <asp:ListItem Text="Layer" Value="Layer" />
            <asp:ListItem Text="Cashier" Value="Cashier" />
            <asp:ListItem Text="Waithress" Value="Waithress" />
            <asp:ListItem Text="Freelancer" Value="Freelancer" />
        </asp:DropDownList>

        <label for="Courses">Courses</label>
        <asp:CheckBoxList runat="server" ID="Courses">
            <asp:ListItem Text="Math" Value="Math" />
            <asp:ListItem Text="Some course" Value="Some course" />
            <asp:ListItem Text="Other course" Value="Other course" />
            <asp:ListItem Text="Another course" Value="Another course" />
        </asp:CheckBoxList>

        <asp:Button runat="server" Text="Register" OnClick="Unnamed_Click" CssClass="btn btn-default" />
    </div>
</asp:Content>
