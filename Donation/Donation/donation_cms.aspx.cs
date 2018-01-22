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
    public partial class donation_cms : System.Web.UI.Page
    {
        Donation_feature d = new Donation_feature();

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        protected void resetFields()
        {
            txt_title.Text = "";
            txt_first_name.Text = "";
            txt_last_name.Text = "";
            txt_email.Text = "";
            txt_country.Text = "";
            txt_addr1.Text = "";
            txt_addr2.Text = "";
            txt_city.Text = "";
            txt_prov_state.Text = "";
            txt_post_zip.Text = "";
            txt_phone.Text = "";
            type_of_donation.Text = "";
        }
        protected void del_but_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job ID!";
                txt_id.Focus();
            }
            else
            {
                d.id_val = Convert.ToInt32(txt_id.Text);
                d.deleteRow();
                resetFields();
                err_msg.InnerHtml = d.err_Msg;
            }
        }

        protected void show_all_Click(object sender, EventArgs e)
        {
            result.InnerHtml = d.showDonationData();
            result.Style.Add("display", "block");
        }
        
        protected void update_btn_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter ID";
                txt_id.Focus();
            }
            else if (txt_title.Text.Length <= 0 || txt_title.Text == "")
            {
                err_msg.InnerHtml = "Please select Title";
                txt_title.Focus();
            }
            else if (txt_first_name.Text.Length <= 0 || txt_first_name.Text == "")
            {
                err_msg.InnerHtml = "Please enter First name";
                txt_first_name.Focus();
            }
            else if (txt_last_name.Text.Length <= 0 || txt_last_name.Text == "")
            {
                err_msg.InnerHtml = "Please enter Last name";
                txt_last_name.Focus();
            }
            else if (txt_email.Text.Length <= 0 || txt_email.Text == "")
            {
                err_msg.InnerHtml = "Please enter Email";
                txt_email.Focus();
            }
            else if (txt_country.Text.Length <= 0 || txt_country.Text == "")
            {
                err_msg.InnerHtml = "Please enter country name";
                txt_country.Focus();
            }
            else if (txt_addr1.Text.Length <= 0 || txt_addr1.Text == "")
            {
                err_msg.InnerHtml = "Please enter Address 1";
                txt_addr1.Focus();
            }
            else if (txt_addr2.Text.Length <= 0 || txt_addr2.Text == "")
            {
                err_msg.InnerHtml = "Please enter Address 2";
                txt_addr2.Focus();
            }
            else if (txt_city.Text.Length <= 0 || txt_city.Text == "")
            {
                err_msg.InnerHtml = "Please enter City";
                txt_city.Focus();
            }
            else if (txt_prov_state.Text.Length <= 0 || txt_prov_state.Text == "")
            {
                err_msg.InnerHtml = "Please enter Province/State";
                txt_prov_state.Focus();
            }
            else if (txt_post_zip.Text.Length <= 0 || txt_post_zip.Text == "")
            {
                err_msg.InnerHtml = "Please enter Postal/Zip code";
                txt_post_zip.Focus();
            }
            else if (txt_phone.Text.Length <= 0 || txt_phone.Text == "")
            {
                err_msg.InnerHtml = "Please enter phone number";
                txt_phone.Focus();
            }
            else if (type_of_donation.Text.Length <= 0 || type_of_donation.Text == "")
            {
                err_msg.InnerHtml = "Please select type of donation";
                type_of_donation.Focus();
            }
            else
            {
                d.title_name = txt_title.Text;
                d.f_name = txt_first_name.Text;
                d.l_name = txt_last_name.Text;
                d.e_mail = txt_email.Text;
                d.country_name = txt_country.Text;
                d.address1 = txt_addr1.Text;
                d.address2 = txt_addr2.Text;
                d.city_n = txt_city.Text;
                d.pr_st = txt_prov_state.Text;
                d.pcode = txt_post_zip.Text;
                d.pnumber = txt_phone.Text;
                d.don_desc_text = type_of_donation.Text;
                d.id_val = Convert.ToInt32(txt_id.Text);
                d.updateRow();
                resetFields();
                err_msg.InnerHtml = d.err_Msg;
            }
        }
        protected void search_by_id_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter ID";
                txt_id.Focus();
            }
            else
            {
                d.id_val = Convert.ToInt32(txt_id.Text);
                d.findById(txt_id, txt_title, txt_first_name, txt_last_name, txt_email, txt_country, txt_addr1, txt_addr2, txt_city, txt_prov_state, txt_post_zip, txt_phone, type_of_donation);
                err_msg.InnerHtml = d.err_Msg;
            }
           
        }
        protected void donation_p_reditect_Click(object sender, EventArgs e)
        {
            Response.Redirect("donation.aspx");
        }
    }
}