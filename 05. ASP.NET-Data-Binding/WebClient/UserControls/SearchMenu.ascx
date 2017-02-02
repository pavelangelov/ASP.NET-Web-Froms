<%@  Control
    Language="C#"
    AutoEventWireup="true"
    CodeBehind="SearchMenu.ascx.cs"
    CodeFile="~/UserControls/SearchMenu.ascx.cs"
    Inherits="MobileSite.UserControls.SearchMenu" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div>
        <asp:Literal runat="server" ID="Summary" Mode="PassThrough" />
    </div>
    <div class="jumbotron">
        <div>
            <asp:Label runat="server" CssClass="label label-info" Text="Producer: " />
            <asp:DropDownList
                runat="server"
                ID="CarProducers"
                OnSelectedIndexChanged="CarProducers_SelectedIndexChanged"
                AutoPostBack="true">
            </asp:DropDownList>

            <asp:Label runat="server" CssClass="label label-info" Text="Model: " />
            <asp:DropDownList
                runat="server"
                ID="Models"
                AutoPostBack="false">
            </asp:DropDownList>

        </div>
        <div>
            <asp:Label runat="server" CssClass="label label-info" Text="Extras: " />
            <asp:CheckBoxList runat="server" ID="Extras" />
        </div>

        <asp:Button runat="server" OnClick="Submit" CssClass="btn btn-success" Text="Submit" />
    </div>
</body>
</html>

