<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recruitment_content.aspx.cs" Inherits="recruitment.recruitment_content" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recruitment Content</title>
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

        a, a:visited, a:link, a:active{
            text-decoration: none;
        }

        form#form1{
            padding: 2em;
            background-color: #dedede;
            max-width: 1024px;
            margin: 0 auto;
        }
        .form-control{
            position: relative;
            display: flex;
            justify-content: space-between;
            flex-flow: row wrap;
            font-size: 1rem;
        }
        .form-control span{
            font-weight: 600;
            flex: 2 1 0;
            align-items: stretch;
            margin: auto;
        }

        .form-control input.btn{
            text-transform: uppercase;
            font-weight: 600;
            font-size: 1rem;
            cursor: pointer;
            margin: 1em;
            background-color: #fff;
            padding: 1em;
            flex: 1 1 0;
        }

        .form-control input, .form-control .text-area, .form-control select{
            margin: .5em;
            padding: .5em;
            border: 1px solid #dedede;
            flex: 8 1 0;
        }

        .form-control .text-area{
            height:100px;
        }
        table{
            border-collapse: collapse;
            width:100%;
        }
        th{
            text-align:center;
        }

        table, tr, td,th{
            border:1px solid #dedede;
            padding:1em;
        }

        table tr td a{
                display: block;
                color: #000;
                font-size: .8rem;
                background-color: #dedede;
                text-align: center;
                padding: 1em;
                text-transform: uppercase;
                font-weight: bold;
                border-radius: 5px;
        }

        #job-content{
            padding:2em;
            margin: 1em auto;
            width:100%;
            text-align:justify;
        }

        #job-wrapper{
            background-color: #dedede;
            padding: .5em 2em;
        }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
    <div id="job-content">
        <h1 id="h_title" runat="server"></h1>
        <h2 id="h_category" runat="server"></h2>
        <h3 id="h_division" runat="server"></h3>
        <div id="job-wrapper">
            <h4>Job Description</h4>
            <div id="c_desc" runat="server"></div>
            <h4>Job Requirement</h4>
            <div id="c_require" runat="server"></div>
        </div>
    </div>
</body>
</html>
