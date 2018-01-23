using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using Donation.Models;

namespace Donation
{
    public partial class donation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            thank_you.Visible = false;
            if (type_of_donation.SelectedValue == "General Donation")
            {
                type_desc.InnerHtml = "<h4><label>General Donation</label></h4><p>Donors like you contribute to the critical funding that we rely on to meet our greatest needs.</p><p>You enable the specialized programs and services that provide outstanding health care in our community and contribute towards the advanced equipment that allows our doctors, nurses, and staff to provide exceptional care to our patients.</p>";
            }
            if (type_of_donation.SelectedValue == "Grateful Patient or In Honour Donation")
            {
                type_desc.InnerHtml = "<h4><label>Grateful Patient or In Honour Donation</label></h4><p>Thank you for considering greeting card as an expression of honour.</p><p>Whether you are making a gift in honour of a special event or a grateful patientgift in thanks for the care you or your loved one received at our hospital, we will send a card either by email or post to the recipient to notify him/her of your gift.</p>";
            }
            if (type_of_donation.SelectedValue == "In Memory Donation")
            {
                type_desc.InnerHtml = "<h4><label>In Memory Donation</label></h4><p>Our cards are a thoughtful way of expressing remembrance of a person who has passed. Your donation will go toward honouring a life and caring for future generations.</p><p>When you make a donation in memory, we will send a card to the next of kin to notify them of your gift either by email or post.</p><p>You will be sent a tax receipt for the total of your gift, but we keep the amount confidential.In other words, the dollar amount of your gift does not appear on the card.</p>";
            }
            else
            {
                return;
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        protected void btn_Click(object sender, EventArgs e)
        {
            Donation_feature d = new Donation_feature();
            //Contact information
            d.don_amt = donation_amt.Value;
            d.title_name = title_id.Text;
            d.f_name = first_name.Value;
            d.l_name = last_name.Value;
            d.e_mail = email.Value;
            d.country_name = country.Value;
            d.address1 = addr1.Value;
            d.address2 = addr2.Value;
            d.city_n = city.Value;
            d.pr_st = prov_state.Value;
            d.pcode = post_zip.Value;
            d.pnumber = phone.Value;
            d.don_desc_text = type_of_donation.Text;


            //Payment Information

            d.cred_number = ccn.Value;
            d.cred_name = chn.Value;
            d.cred_exp_date = expireMM.Value + "-" + expireYY.Value;
            d.cred_sec_code = csc.Value;

            if (donation_amt.Value.Length <= 0 || donation_amt.Value == "")
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter Donation amount";
                donation_amt.Focus();
            }
            else if (!IsValidEmail(email.Value))
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter valid email";
                email.Focus();
            }
            else if (ccn.Value.Length <= 15 || ccn.Value == "")
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter Credit card number";
                ccn.Focus();
            }
            else if (chn.Value.Length <= 0 || chn.Value == "")
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter Cardholder's name";
                chn.Focus();
            }
            else if (expireMM.Value.Length <= 0 || expireMM.Value == "")
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter Expiration date Month";
                expireMM.Focus();
            }
            else if (expireYY.Value.Length <= 0 || expireYY.Value == "")
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter Expiration date Year";
                expireYY.Focus();
            }
            
            else if (csc.Value.Length <= 0 || csc.Value == "")
            {
                thank_you.Visible = true;
                thank_you.InnerHtml = "Please enter Card Security Code";
                csc.Focus();
            }
            else
            {
                d.insertRow();
                form1.Visible = false;
                thank_you.Visible = true;
                thank_you.InnerHtml = "<h2>Thank you for your donation, " + d.title_name + " " + d.f_name + 
                    " " + d.l_name + "! " + "God bless you!</h2>" + d.err_Msg;
            }
        }
    }
}