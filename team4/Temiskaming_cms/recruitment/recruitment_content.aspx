<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recruitment_content.aspx.cs" Inherits="recruitment.recruitment_content" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recruitment Content</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet"/>
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
