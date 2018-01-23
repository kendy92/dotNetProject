<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="make_appointment.aspx.cs" Inherits="BookAppointment.clientPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book appointment</title>
    <link href="sources/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <h1 class="heading">Book an appointment</h1>
    </header>
    <main>
        <div class="booking">
            <p class="booking__paragraph">
                Use the online form to book an appointment.
            We will call you back to provide the exact time of the appointment.
            </p>

            <form class="booking-form" id="bookingForm" runat="server">
                <div class="booking-form__content">
                    <div class="input-group">
                        <label for="fullname">Your name</label>
                        <asp:TextBox ID="fullname" required="required" runat="server" />
                    </div>
                    <div class="input-group">
                        <label for="email">E-mail address</label>
                        <asp:TextBox type="email" ID="email" required="required" runat="server" />
                    </div>
                    <div class="input-group">
                        <label for="phone">Phone number</label>
                        <asp:TextBox type="tel" ID="phone" required="required" runat="server" />
                    </div>
                    <div class="input-group">
                        <label for="service">Service requested</label>
                        <asp:DropDownList ID="service" runat="server" required="required">
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
                        <asp:TextBox type="date" ID="date" required="required" runat="server" />
                    </div>
                    <div class="input-group">
                        <label for="message">Message</label>
                        <asp:TextBox ID="message" runat="server" TextMode="multiline" />

                    </div>
                    <div id="err_msg" style="color:red;" runat="server"></div>
                    <asp:Button CssClass="booking-form__submit" type="submit"
                        ID="submit" runat="server" Text="Book appointment" OnClick="submit_Click" />
                </div>
                <img class="booking-form__image" src="sources/wegotyou.png" alt="we've got you">
            </form>
            <p class="booking__paragraph">
                *The date may change due to doctors availability.
            </p>
            <p class="booking__paragraph">
                For testing purposes only: <a href="appointment_list.aspx">Go to admin panel</a>
            </p>
        </div>
    </main>
</body>
</html>
