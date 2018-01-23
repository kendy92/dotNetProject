<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact_cms.aspx.cs" Inherits="ContactUs.contact_cms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact - Admin Page</title>
    <link href="style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Contact Admin Page</h1>
        <div class="form-control">
            <asp:Label runat="server">Contact ID</asp:Label>
            <asp:TextBox runat="server" id="c_id"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Province</asp:Label>
            <asp:TextBox runat="server" id="province_name"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Address</asp:Label>
            <asp:TextBox CssClass="text-area" id="txt_address" TextMode="multiline" runat="server" />
        </div>
        <div id="err_msg" runat="server"></div>
        <div class="form-control">
            <asp:Button CssClass="btn" ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

            <asp:Button CssClass="btn" ID="btnSearch" runat="server" Text="Search by Id" OnClick="btnSearch_Click" BackColor="White" ForeColor="Black" />

            <asp:Button CssClass="btn" ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" BackColor="#FF6600" />

            <asp:Button CssClass="btn" ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" BackColor="#CC0000" />

            <asp:Button CssClass="btn" ID="btnContact_page" runat="server" Text="Go to Contact Page" OnClick="btnContact_page_Click" BackColor="#666666" />

        </div>
    </form>
    <div id="result_text" runat="server"></div>
</body>
</html>
