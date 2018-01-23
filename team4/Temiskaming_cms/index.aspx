<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Temiskaming_cms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            display: flex;
            justify-content: center;
            flex-direction: column;
            align-items: center;
            height: 100vh;
        }
        body>div{
            font-size:1.5rem;
            margin-bottom:1rem;
        }
    </style>
</head>
<body>
    <div>
        <a href="appointments/appointment_list.aspx">Appointments feature</a>
    </div>
    <div>
        <a href="contactus/contact_cms.aspx">Contact us feature</a>
    </div>
    <div>
        <a href="donation/donation_cms.aspx">Donation feature</a>
    </div>
    <div>
        <a href="faq/faq_cms.aspx">FAQ feature</a>
    </div>
    <div>
        <a href="recruitment/recruitment_cms.aspx">Recruitment feature</a>
    </div>
</body>
</html>
