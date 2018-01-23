<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editAppointment.aspx.cs" Inherits="BookAppointment.editAppointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="sources/admin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <h1 class="heading" id="heading" runat="server">Edit appointment</h1>
    </header>
    <main>
        <span id="server_output" runat="server" style="color:red;"></span>
        <form class="edit-form" runat="server" id="editForm">
            <div class="input-group">
                <label for="fullname">Full name</label>
                <asp:TextBox ID="fullname" required="required" runat="server" />
            </div>
            <div class="input-group">
                <label for="email">E-mail</label>
                <asp:TextBox type="email" ID="email"  runat="server" />
            </div>
            <div class="input-group">
                <label for="phone">Phone number</label>
                <asp:TextBox type="tel" ID="phone"  runat="server" />
            </div>
            <div class="input-group">
                <label for="service">Service requested</label>
                <asp:DropDownList ID="service" runat="server" >
                    <asp:ListItem Value="">--Select service--</asp:ListItem>
                    <asp:ListItem Value="1">Anaesthesiology</asp:ListItem>
                    <asp:ListItem Value="2">Cardiology</asp:ListItem>
                    <asp:ListItem Value="3">Critical Care</asp:ListItem>
                    <asp:ListItem Value="4">Dermatology</asp:ListItem>
                    <asp:ListItem Value="5">Oncology</asp:ListItem>
                    <asp:ListItem Value="6">Neurology</asp:ListItem>
                    <asp:ListItem Value="7">Psychiatry</asp:ListItem>
                    <asp:ListItem Value="8">Rheumatology</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="input-group">
                <label for="date">Preferred date*</label>
                <asp:TextBox ID="a_date" runat="server" />
            </div>
            <div class="input-group">
                <label for="message">Message</label>
                <asp:TextBox ID="message" runat="server" TextMode="multiline" />

            </div>
            <div id="err_msg" style="color: red;" runat="server"></div>
            <asp:Button CssClass="booking-form__submit" type="submit"
                ID="submit" runat="server" Text="Save" OnClick="submit_Click" />
        </form>
    </main>
</body>
</html>
