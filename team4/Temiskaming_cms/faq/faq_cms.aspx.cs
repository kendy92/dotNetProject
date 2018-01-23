using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using faq_page.Models;
using Oracle.ManagedDataAccess.Client;

namespace faq_page
{
    public partial class faq_cms : System.Web.UI.Page
    {
        faq_feature f = new faq_feature();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == null)
            {
                err_msg.InnerHtml = "Please enter FAQ ID";
            }
            else
            {
                f.id = Convert.ToInt32(txt_id.Text);
                f.deleteRow();
                err_msg.InnerHtml = f.err_Msg;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == null)
            {
                err_msg.InnerHtml = "Please enter an ID";
            }
            else if (txt_question.Text.Length <= 0 || txt_question.Text == null)
            {
                err_msg.InnerHtml = "Please enter a question!";
            }
            else if (text_answer.Text.Length <= 0 || text_answer.Text == null)
            {
                err_msg.InnerHtml = "Please enter an answer for the question!";
            }
            else
            {
                f.id = Convert.ToInt32(txt_id.Text);
                f.question = Server.HtmlEncode(txt_question.Text);
                f.answer = Server.HtmlEncode(text_answer.Text);
                f.updateRow();
                err_msg.InnerHtml = f.err_Msg;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == null)
            {
                err_msg.InnerHtml = "Please enter FAQ ID";
                
            }else if(txt_question.Text.Length <= 0 || txt_question.Text == null)
            {
                err_msg.InnerHtml = "Please enter a question!";
            }
            else if (text_answer.Text.Length <= 0 || text_answer.Text == null)
            {
                err_msg.InnerHtml = "Please enter an answer for the question!";
            }
            else
            {
                f.id = Convert.ToInt32(txt_id.Text);
                f.question = Server.HtmlEncode(txt_question.Text);
                f.answer = Server.HtmlEncode(text_answer.Text);
                f.insertRow();
                err_msg.InnerHtml = f.err_Msg;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            result.InnerHtml = f.ShowFAQData();
            result.Style.Add("display", "block");

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == "")
            {
                err_msg.InnerHtml = "Please enter Job ID";
                txt_id.Focus();
            }
            else
            {
                f.id = Convert.ToInt32(txt_id.Text);
                f.findQuestionById(txt_question, text_answer);
                err_msg.InnerHtml = f.err_Msg;
            }
        }

        protected void btnFAQPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("faq_page.aspx");
        }
    }
}