<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faq_page.aspx.cs" Inherits="faq_page.faq_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FAQ PAGE</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
    <h1>FAQ Section</h1>
    <form id="form1" runat="server">
        <div class="search-content form-control">
        <asp:Label runat="server">Search Box</asp:Label>
        <asp:TextBox ID="txt_keyword" runat="server"></asp:TextBox>
        <asp:Button CssClass="btn" ID="btnFind" runat="server" Text="Find Question" OnClick="btnFind_Click" />
        </div>
    </form>
    <div id="err_msg" runat="server"></div>
    <div id="result" runat="server"></div>
    <div id="faq_content" runat="server"></div>
</body>
</html>
