<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="donation.aspx.cs" Inherits="Donation.donation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  
    <title>Donation page</title>
</head>
<body>

   
    <form id="form1" runat="server">
        <h2 style="text-align:center">Welcome to donation page!</h2>


         <div class="form-control">
            <asp:Label runat="server"><h4>Select a type of donation</h4></asp:Label>
            <asp:DropDownList ID="type_of_donation" AutoPostBack="true" runat="server">
                <asp:ListItem Selected="True" Value="General Donation">General Donation</asp:ListItem>
                <asp:ListItem Value="Grateful Patient or In Honour Donation">Grateful Patient or In Honour Donation</asp:ListItem>
                <asp:ListItem Value="In Memory Donation">In Memory Donation</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <br />

        <div id="type_desc" runat="server"></div>
        <br />
        <br />


        <div id="cont_inf" runat="server">
            
            <h4>Please complete the form below.</h4>
                <p>We require your contact information and e-mail address to send you a confirmation.</p>

             <asp:Label runat="server"><h5>Donation amount (CAD $)</h5></asp:Label>
             <input id="donation_amt" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Title</h5></asp:Label>
            <asp:DropDownList ID="title_id" AutoPostBack="true" runat="server">
                <asp:ListItem>Mr.</asp:ListItem>
                <asp:ListItem>Ms.</asp:ListItem>
                <asp:ListItem>Mrs.</asp:ListItem>
                <asp:ListItem>Miss</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label runat="server"><h5>First Name</h5></asp:Label>
             <input id="first_name" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Last Name</h5></asp:Label>
             <input id="last_name" runat="server" />
             <br />
             <asp:Label runat="server"><h5>E-mail</h5></asp:Label>
             <input id="email" type="email" placeholder="Your e-mail address" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Country</h5></asp:Label>
             <input id="country" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Address 1</h5></asp:Label>
             <input id="addr1" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Address 2</h5></asp:Label>
             <input id="addr2" runat="server" />
             <br />
            <asp:Label runat="server"><h5>City</h5></asp:Label>
             <input id="city" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Province/State</h5></asp:Label>
             <input id="prov_state" maxlength="2" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Postal Code/ZIP Code</h5></asp:Label>
             <input id="post_zip" runat="server" />
             <br />
            <asp:Label runat="server"><h5>Phone</h5></asp:Label>
             <input id="phone" runat="server" />
        
             <br />
            <br />
          
        </div>

         <div id="payment_info" runat="server">
             <h4>Payment Information</h4>
             

             <i class="fa fa-cc-mastercard" aria-hidden="true"></i>
             <i class="fa fa-cc-visa" aria-hidden="true"></i>
             <i class="fa fa-cc-amex" aria-hidden="true"></i>

             <asp:Label runat="server"><h5>Credit card number</h5></asp:Label>
             <input id="ccn" maxlength="16" runat="server" />
             <br />

             <asp:Label runat="server"><h5>Cardholder's name</h5></asp:Label>
             <input id="chn" runat="server" />
             <br />

             <asp:Label runat="server"><h5>Expiration date</h5></asp:Label>

                <select name="expireMM" id="expireMM" runat="server">
                        <option value=''>Month</option>
                        <option value='01'>January</option>
                        <option value='02'>February</option>
                        <option value='03'>March</option>
                        <option value='04'>April</option>
                        <option value='05'>May</option>
                        <option value='06'>June</option>
                        <option value='07'>July</option>
                        <option value='08'>August</option>
                        <option value='09'>September</option>
                        <option value='10'>October</option>
                        <option value='11'>November</option>
                        <option value='12'>December</option>
                  </select> 
                        <select name="expireYY" id="expireYY" runat="server">
                            <option value=''>Year</option>
                            <option value='18'>2018</option>
                            <option value='19'>2019</option>
                            <option value='20'>2020</option>
                            <option value='21'>2021</option>
                            <option value='22'>2022</option>
                        </select> 

             <br />

             <asp:Label runat="server"><h5>Card Security Code</h5></asp:Label>
             <input id="csc" maxlength="3" runat="server" />
             <br />
         </div>
			<div id="donate_button" style="text-align:center">
                <asp:Button runat="server" Text="DONATE" type="submit" OnClick="btn_Click" />
			</div>
    </form>

    <div id="thank_you" runat="server"></div>

</body>
</html>
