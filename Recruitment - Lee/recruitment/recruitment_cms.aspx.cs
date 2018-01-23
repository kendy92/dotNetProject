using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using recruitment.Models;

namespace recruitment
{
    public partial class recruitment_cms : System.Web.UI.Page
    {
        recruitment_feature r = new recruitment_feature();
        DateTime today = DateTime.Now;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resetFields()
        {
            txt_id.Text = "";
            txt_title.Text = "";
            txt_requirement.Text = "";
            txt_desc.Text = "";
            job_category_list.Text = "";
            job_division_list.Text = "";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            result.InnerHtml = r.showRecruitmentData();
            result.Style.Add("display", "block");
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if(txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job ID";
                txt_id.Focus();
            }
            else if (txt_title.Text.Length <= 0 || txt_title.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job Title";
                txt_title.Focus();
            }
            else if (txt_desc.Text.Length <= 0 || txt_desc.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job Description";
                txt_desc.Focus();
            }
            else if (txt_requirement.Text.Length <= 0 || txt_requirement.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job Requirement";
                txt_requirement.Focus();
            }
            else if (job_category_list.Text.Length <= 0 || job_category_list.Text == "")
            {
                err_msg.InnerHtml = "Please select Job Category";
                job_category_list.Focus();
            }
            else if (job_division_list.Text.Length <= 0 || job_division_list.Text == "")
            {
                err_msg.InnerHtml = "Please select Job Division";
                job_division_list.Focus();
            }else
            {
                r.job_id = Convert.ToInt32(txt_id.Text);
                r.job_title = txt_title.Text;
                r.job_desc = Server.HtmlEncode(txt_desc.Text);
                r.job_require = Server.HtmlEncode(txt_requirement.Text);
                r.job_category = job_category_list.Text;
                r.job_division = job_division_list.Text;
                r.job_postdate = Convert.ToDateTime(today.ToString("yyyy-MM-dd"));
                r.insertRow();
                resetFields();
                err_msg.InnerHtml = r.err_Msg;
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job ID";
                txt_id.Focus();
            }
            else if (txt_title.Text.Length <= 0 || txt_title.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job Title";
                txt_title.Focus();
            }
            else if (txt_desc.Text.Length <= 0 || txt_desc.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job Description";
                txt_desc.Focus();
            }
            else if (txt_requirement.Text.Length <= 0 || txt_requirement.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job Requirement";
                txt_requirement.Focus();
            }
            else if (job_category_list.Text.Length <= 0 || job_category_list.Text == "")
            {
                err_msg.InnerHtml = "Please select Job Category";
                job_category_list.Focus();
            }
            else if (job_division_list.Text.Length <= 0 || job_division_list.Text == "")
            {
                err_msg.InnerHtml = "Please select Job Division";
                job_division_list.Focus();
            }
            else
            {
                r.job_id = Convert.ToInt32(txt_id.Text);
                r.job_title = txt_title.Text;
                r.job_desc = Server.HtmlEncode(txt_desc.Text);
                r.job_require = Server.HtmlEncode(txt_requirement.Text);
                r.job_category = job_category_list.Text;
                r.job_division = job_division_list.Text;
                r.job_postdate = Convert.ToDateTime(today.ToString("yyyy-MM-dd"));
                r.updateRow();
                resetFields();
                err_msg.InnerHtml = r.err_Msg;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job ID!";
                txt_id.Focus();
            }
            else
            {
                r.job_id = Convert.ToInt32(txt_id.Text);
                r.deleteRow();
                resetFields();
                err_msg.InnerHtml = r.err_Msg;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job ID";
                txt_id.Focus();
            }
            else
            {
                r.job_id = Convert.ToInt32(txt_id.Text);
                r.findJobById(txt_title, txt_desc, txt_requirement, job_division_list, job_category_list);
                err_msg.InnerHtml = r.err_Msg;
            }
        }

        protected void btnRecruitPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("recruitment_page.aspx");
        }
    }
}