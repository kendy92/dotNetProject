<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faq_page.aspx.cs" Inherits="faq_page.faq_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FAQ PAGE</title>
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

        h1{
            padding-left:1.5em;
        }

        #faq_content{
            background-color: #f2f2f2;
            padding: 1em;
            margin: 3em;
            border-radius: 5px;
        }

        .search-content{
            margin: 1em 3em;
        }

        #result{
            padding: 1em;
            background-color: cadetblue;
            margin: 1em 3em;
            color: #fff;
            border-radius: 5px;
            display:none;
        }

        .form-control{
            position:relative;
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
            margin:0;
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
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
    <h1>FAQ Section</h1>
    <form id="form1" runat="server">
        <div class="search-content form-control">
        <asp:Label runat="server">Search Box</asp:Label>
        <asp:TextBox ID="txt_search" runat="server"></asp:TextBox>
        <asp:Button CssClass="btn" ID="btnFind" runat="server" Text="Find Question" OnClick="btnFind_Click" />
        </div>
    </form>
    <div id="err_msg" runat="server"></div>
    <div id="result" runat="server"></div>
    <div id="faq_content" runat="server"></div>
</body>
</html>
