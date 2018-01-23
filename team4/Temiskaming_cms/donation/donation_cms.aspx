<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="donation_cms.aspx.cs" Inherits="Donation.donation_cms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title>Donation Admin Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Donation Admin Page</h1>
        <div id="cont_inf" runat="server">
            <div class="form-control">
            <asp:Label runat="server"><h5>ID</h5></asp:Label>
            <asp:TextBox ID="txt_id" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Title</h5></asp:Label>
            <asp:DropDownList ID="txt_title" AutoPostBack="true" runat="server">
                <asp:ListItem>Mr.</asp:ListItem>
                <asp:ListItem>Ms.</asp:ListItem>
                <asp:ListItem>Mrs.</asp:ListItem>
                <asp:ListItem>Miss</asp:ListItem>
            </asp:DropDownList></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>First Name</h5></asp:Label>
            <asp:TextBox ID="txt_first_name" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Last Name</h5></asp:Label>
            <asp:TextBox ID="txt_last_name" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>E-mail</h5></asp:Label>
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Country</h5></asp:Label>
            <asp:TextBox ID="txt_country" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Address 1</h5></asp:Label>
            <asp:TextBox ID="txt_addr1" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Address 2</h5></asp:Label>
            <asp:TextBox ID="txt_addr2" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>City</h5></asp:Label>
            <asp:TextBox ID="txt_city" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Province/State</h5></asp:Label>
            <asp:TextBox ID="txt_prov_state" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Postal Code/ZIP Code</h5></asp:Label>
            <asp:TextBox ID="txt_post_zip" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Phone</h5></asp:Label>
            <asp:TextBox ID="txt_phone" runat="server"></asp:TextBox></div>
            <div class="form-control">
            <asp:Label runat="server"><h5>Type of donation</h5></asp:Label>
            <asp:DropDownList ID="type_of_donation" runat="server">
                <asp:ListItem Value="General Donation">General Donation</asp:ListItem>
                <asp:ListItem Value="Grateful Patient or In Honour Donation">Grateful Patient or In Honour Donation</asp:ListItem>
                <asp:ListItem Value="In Memory Donation">In Memory Donation</asp:ListItem>
            </asp:DropDownList></div>
        </div>
             <br />
         <div id="err_msg" runat="server"></div>
              <br />
        <div class="form-control">
        <asp:Button CssClass="btn" ID="show_all" runat="server" Text="Show All" OnClick="show_all_Click" />
        <asp:Button CssClass="btn" ID="search_by_id" runat="server" Text="Search By ID" OnClick="search_by_id_Click" />
        <asp:Button CssClass="btn" ID="update_btn" runat="server" Text="Update" OnClick="update_btn_Click" />
        <asp:Button CssClass="btn" ID="del_but" runat="server" Text="Delete" OnClick="del_but_Click"/>
        <asp:Button CssClass="btn" ID="donation_p_reditect" runat="server" Text="Donation Page" OnClick="donation_p_reditect_Click"/></div>
            <br />
            <br />
        <div id="result" style="overflow-x: scroll" runat="server"></div>
    </form>
</body>
</html>
