<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="faq_cms.aspx.cs" Inherits="faq_page.faq_cms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FAQ Admin Page</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h1>FAQ Admin Page</h1>
        <div class="form-control">
            <asp:Label runat="server">ID</asp:Label>
            <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Question</asp:Label>
            <asp:TextBox ID="txt_question" runat="server"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Answer</asp:Label>
            <asp:TextBox CssClass="text-area" ID="text_answer" TextMode="MultiLine" runat="server"></asp:TextBox>
        </div>
        <div id="err_msg" runat="server"></div>
        <div class="form-control">
            <asp:Button CssClass="btn" ID="btnShow" Text="Show All" runat="server" OnClick ="btnShow_Click" />
            <asp:Button CssClass="btn" ID="btnFind" Text="Find By Id" runat="server" OnClick="btnFind_Click" />
            <asp:Button CssClass="btn" ID="btnInsert" Text="Add Question" runat="server" OnClick="btnInsert_Click" />
            <asp:Button CssClass="btn" ID="btnUpdate" Text="Edit Question" runat="server" OnClick="btnUpdate_Click" />
            <asp:Button CssClass="btn" ID="btnDelete" Text="Delete Question" runat="server" OnClick="btnDelete_Click" />
            <asp:Button CssClass="btn" ID="btnFAQPage" Text="FAQ Page" runat="server" OnClick="btnFAQPage_Click" />
        </div>
        <div id="result" runat="server"></div>
    </form>
</body>
</html>
