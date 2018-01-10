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
                f.faq_id = txt_id.Text;
                if (f.DeleteRow())
                {
                    err_msg.InnerHtml = "1 row deleted!";
                }else
                {
                    err_msg.InnerHtml = "0 row deleted!";
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length <= 0 || txt_id.Text == null)
            {
                err_msg.InnerHtml = "Please enter FAQ ID";
            }
            else if (txt_question.Text.Length <= 0 || txt_question.Text == null)
            {
                err_msg.InnerHtml = "Please enter a question!";
            }
            else if (txt_answer.Value.Length <= 0 || txt_answer.Value == null)
            {
                err_msg.InnerHtml = "Please enter an answer for the question!";
            }
            else
            {
                f.faq_id = txt_id.Text;
                f.question = txt_question.Text;
                f.answer = txt_answer.Value;
                if (f.UpdateRow())
                {
                    err_msg.InnerHtml = "1 row updated!";
                }else
                {
                    err_msg.InnerHtml = "No row updated!";
                }
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
            else if (txt_answer.Value.Length <= 0 || txt_answer.Value == null)
            {
                err_msg.InnerHtml = "Please enter an answer for the question!";
            }
            else
            {
                f.faq_id = txt_id.Text;
                f.question = txt_question.Text;
                f.answer = txt_answer.Value;
                if (f.InsertRow())
                {
                    err_msg.InnerHtml = "1 row inserted!";
                }
                else
                {
                    err_msg.InnerHtml = "0 row inserted!";
                }
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            result.InnerHtml = f.showFAQ();

        }

    }
}