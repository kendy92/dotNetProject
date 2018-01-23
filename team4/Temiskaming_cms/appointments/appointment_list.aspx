<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="appointment_list.aspx.cs" Inherits="BookAppointment.appointment_list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="sources/admin.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css">
</head>
<body>
    <header>
        <h1 class="heading">List of
        appointments<a class="heading__link" href="make_appointment.aspx">Go to "Make appointment page"</a></h1>
        <form class="search-form" id="searchForm" runat="server">
            <div class="input-group">
                <label for="fullname">Search by name</label>
                <asp:TextBox ID="fullname" runat="server" />
            </div>
            <div class="input-group">
                <label for="service">Filter by service</label>
                <asp:DropDownList ID="service" runat="server">
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
            <asp:Button type="submit"
                ID="search" runat="server" Text="Search" OnClick="search_Click" />
        </form>
    </header>
    <main>
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Service</th>
                    <th>Preferred date</th>
                    <th class="actions">Actions</th>
                </tr>
            </thead>
            <tbody id="a_table" runat="server">
                
            </tbody>
        </table>
    </main>
</body>
</html>
