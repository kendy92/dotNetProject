using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactUs.Models;

namespace ContactUs
{
    public partial class contact_cms : System.Web.UI.Page
    {
        contact_feature c = new contact_feature();

        protected void Page_Load(object sender, EventArgs e)
        {
           string result =  c.viewAllRecord();
            result_text.InnerHtml = result;
        }

        protected void resetFields()
        {
            c_id.Text = "";
            province_name.Text = "";
            txt_address.Text = "";
        }

          protected void btnAdd_Click(object sender, EventArgs e)
          {

        //    System.Diagnostics.Debug.WriteLine("c_id :" + c_id.Text);
        //    System.Diagnostics.Debug.WriteLine("p_name :" + province_name.Text);
        //    System.Diagnostics.Debug.WriteLine("address :" + txt_address.Text);


            if (c_id.Text.Length <= 0 || c_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Contact ID";
                c_id.Focus();
            }
            else if (province_name.Text.Length <= 0 || province_name.Text == "")
            {
                err_msg.InnerHtml = "Please enter Province Name";
                province_name.Focus();
            }
            else if (txt_address.Text.Length <= 0 || txt_address.Text == "")
            {
                err_msg.InnerHtml = "Please enter Address";
                txt_address.Focus();
            }
            else
            {
                c.ID = Convert.ToInt32(c_id.Text);
                c.PROVINCE = province_name.Text;
                c.ADDRESS = Server.HtmlEncode(txt_address.Text);
                bool status = c.AddRecord();
                if (status)
                {
                    resetFields();
                    err_msg.InnerHtml = c.err_msg;
                    string result = c.viewAllRecord();
                    result_text.InnerHtml = result;
                } else
                {
                    resetFields();
                    err_msg.InnerHtml = c.err_msg;
                }
                
            }

          }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //    System.Diagnostics.Debug.WriteLine("c_id :" + c_id.Text);
            //    System.Diagnostics.Debug.WriteLine("p_name :" + province_name.Text);
            //    System.Diagnostics.Debug.WriteLine("address :" + txt_address.Text);


            if (c_id.Text.Length <= 0 || c_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Contact ID";
                c_id.Focus();
            }
            else if (province_name.Text.Length <= 0 || province_name.Text == "")
            {
                err_msg.InnerHtml = "Please enter Province Name";
                province_name.Focus();
            }
            else if (txt_address.Text.Length <= 0 || txt_address.Text == "")
            {
                err_msg.InnerHtml = "Please enter Address";
                txt_address.Focus();
            }
            else
            {
                c.ID = Convert.ToInt32(c_id.Text);
                c.PROVINCE = province_name.Text;
                c.ADDRESS = Server.HtmlEncode(txt_address.Text);
                bool status = c.UpdateRecord();
                if (status)
                {
                    resetFields();
                    err_msg.InnerHtml = c.err_msg;
                    string result = c.viewAllRecord();
                    result_text.InnerHtml = result;
                }
                else
                {
                    resetFields();
                    err_msg.InnerHtml = c.err_msg;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (c_id.Text.Length <= 0 || c_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Contact ID";
                c_id.Focus();
            }
            else
            {
                c.ID = Convert.ToInt32(c_id.Text);
                bool status = c.DeleteRecord();
                if (status)
                {
                    resetFields();
                    err_msg.InnerHtml = c.err_msg;
                    string result = c.viewAllRecord();
                    result_text.InnerHtml = result;
                }
                else
                {
                    resetFields();
                    err_msg.InnerHtml = c.err_msg;
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (c_id.Text.Length <= 0 || c_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Contact ID";
                c_id.Focus();
            } else
            {
                c.ID = Convert.ToInt32(c_id.Text);
                c.SearchRecordById(province_name, txt_address);
                err_msg.InnerHtml = c.err_msg;
            }
        }

        protected void btnContact_page_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact_page.aspx");
        }
    }
}