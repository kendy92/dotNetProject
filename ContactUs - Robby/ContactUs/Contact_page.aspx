<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact_page.aspx.cs" Inherits="ContactUs.Contact_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Page</title>
    <link href="style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form2" runat="server">
        <h1>Welcome to Contact Page</h1>
        <div class="form-control">
            <asp:Label runat="server">Province</asp:Label>
            <asp:DropDownList ID="province_list" AutoPostBack="false" runat="server">
            </asp:DropDownList>
        </div>
        <div class="form-control">
            <asp:Button CssClass="btn" ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
    </form>
    <div id="result_text" runat="server"></div>
</body>
</html>
