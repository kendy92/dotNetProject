<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faq_cms.aspx.cs" Inherits="faq_page.faq_cms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FAQ Admin Page</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <style>
        html{
            box-sizing: border-box;
        }

        *, *::before, *::after{
            box-sizing: inherit;
        }

        body{
            color:#333;
            -webkit-font-smoothing: antialiased;
            font-family: 'Raleway', sans-serif;
            text-align:justify;
        }

        .form-control{
            position:relative;
            width:100%;
        }
        .form-control span{
            display: inline-block;
            width: 10%;
            vertical-align:middle;
            font-weight:500;
        }

        .form-control input.btn{
            width:200px;
            text-transform:uppercase;
            font-weight:bold;
            font-size:1rem;
            cursor:pointer;
        }

        .form-control input, .form-control textarea{
            width: 80%;
            margin: .5em;
            padding: .5em;
            border: 1px solid #dedede;
        }

        .form-control textarea{
            height:100px;
        }

        #err_msg{
            color:#ff0000;
            font-weight:700;
            text-align:center;
        }

        table{
            border-collapse: collapse;
            width:100%;
        }

        table, tr, td,th{
            border:1px solid #dedede;
        }
    </style>
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
            <textarea runat="server" id="txt_answer"></textarea>
        </div>
        <div class="form-control">
            <asp:Button CssClass="btn" ID="btnShow" Text="Show All" runat="server" OnClick ="btnShow_Click" />
            <asp:Button CssClass="btn" ID="btnInsert" Text="Add Question" runat="server" OnClick="btnInsert_Click" />
            <asp:Button CssClass="btn" ID="btnUpdate" Text="Edit Question" runat="server" OnClick="btnUpdate_Click" />
            <asp:Button CssClass="btn" ID="btnDelete" Text="Delete Question" runat="server" OnClick="btnDelete_Click" />
        </div>
        <div id="err_msg" runat="server"></div>
        <div id="result" runat="server"></div>
    </form>
</body>
</html>
