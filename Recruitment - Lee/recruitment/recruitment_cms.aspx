<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="recruitment_cms.aspx.cs" Inherits="recruitment.recruitment_cms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recruitment - Admin Page</title>
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Recruitment Admin Page</h1>
        <div class="form-control">
            <asp:Label runat="server">Job ID</asp:Label>
            <asp:TextBox runat="server" ID="txt_id"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Job Title</asp:Label>
            <asp:TextBox runat="server" ID="txt_title"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Job Description</asp:Label>
            <asp:TextBox CssClass="text-area" id="txt_desc" TextMode="multiline" runat="server" />
        </div>
        <div class="form-control">
            <asp:Label runat="server">Job Requirement</asp:Label>
            <asp:TextBox CssClass="text-area" id="txt_requirement" TextMode="multiline" runat="server" />
        </div>
        <div class="form-control">
            <asp:Label runat="server">Division</asp:Label>
            <asp:DropDownList ID="job_division_list" AutoPostBack="true" runat="server">
                <asp:ListItem Value=""></asp:ListItem>
                <asp:ListItem Value="Hemodialysis">Hemodialysis</asp:ListItem>
                <asp:ListItem Value="Gen Surgical">Gen Surgical</asp:ListItem>
                <asp:ListItem Value="General Emergency">General Emergency</asp:ListItem>
                <asp:ListItem Value="Post Anaesthetic Care Unit">Post Anaesthetic Care Unit</asp:ListItem>
                <asp:ListItem Value="Cath Suite">Cath Suite</asp:ListItem>
                <asp:ListItem Value="Chief Psychology">Chief Psychology</asp:ListItem>
                <asp:ListItem Value="Dental Clinic">Dental Clinic</asp:ListItem>
                <asp:ListItem Value="Plant Maintenance">Plant Maintenance</asp:ListItem>
                <asp:ListItem Value="Employee Service">Employee Service</asp:ListItem>
                <asp:ListItem Value="Housekeeping">Housekeeping</asp:ListItem>
                <asp:ListItem Value="Endoscopy">Endoscopy</asp:ListItem>
                <asp:ListItem Value="Plant Operation">Plant Operation</asp:ListItem>
                <asp:ListItem Value="Perfusion">Perfusion</asp:ListItem>
                <asp:ListItem Value="Systems Architecture">Systems Architecture</asp:ListItem>
                <asp:ListItem Value="Finance Operator">Finance Operator</asp:ListItem>
                <asp:ListItem Value="Surg Day Care Unit">Surg Day Care Unit</asp:ListItem>
                <asp:ListItem Value="Main Electrical">Main Electrical</asp:ListItem>
                <asp:ListItem Value="Obstetrical Suite">Obstetrical Suite</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-control">
            <asp:Label runat="server">Category</asp:Label>
            <asp:DropDownList ID="job_category_list" AutoPostBack="true" runat="server">
                <asp:ListItem Value=""></asp:ListItem>
                <asp:ListItem Value="Nursing">Nursing</asp:ListItem>
                <asp:ListItem Value="Allied Health Professional">Allied Health Professional</asp:ListItem>
                <asp:ListItem Value="Management">Management</asp:ListItem>
                <asp:ListItem Value="Facilities and Maintenance">Facilities and Maintenance</asp:ListItem>
                <asp:ListItem Value="Information System Technology">Information System Technology</asp:ListItem>
                <asp:ListItem Value="Admin">Admin</asp:ListItem>
                <asp:ListItem Value="Diagnostic Imaging">Diagnostic Imaging</asp:ListItem>
                <asp:ListItem Value="Health Information Management">Health Information Management</asp:ListItem>
                <asp:ListItem Value="Nutrition and Food Service">Nutrition and Food Service</asp:ListItem>
                <asp:ListItem Value="Radiation Therapy">Radiation Therapy</asp:ListItem>
                <asp:ListItem Value="Support">Support</asp:ListItem>
                <asp:ListItem Value="Admin">Admin</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div id="err_msg" runat="server"></div>
        <div class="form-control">
            <asp:Button CssClass="btn" ID="btnShow" runat="server" Text="Show All" OnClick="btnShow_Click" />
            <asp:Button CssClass="btn" ID="btnSearch" runat="server" Text="Search By ID" OnClick="btnSearch_Click" />
            <asp:Button CssClass="btn" ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <asp:Button CssClass="btn" ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button CssClass="btn" ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button CssClass="btn" ID="btnRecruitPage" runat="server" Text="Recruitment Page" OnClick="btnRecruitPage_Click" />
        </div>
        <div id="result" runat="server"></div>
    </form>
</body>
</html>
