using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using faq_page.Models;

namespace faq_page
{
    public partial class faq_page : System.Web.UI.Page
    {
        faq_feature f = new faq_feature();
        protected void Page_Load(object sender, EventArgs e)
        {
            faq_content.InnerHtml = f.ShowFAQContent();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            if (txt_keyword.Text.Length <= 0 || txt_keyword.Text == "")
            {
                err_msg.InnerHtml = "Please enter question to search!";
            }
            else //if keyword found then search by keyword
            {
                f.question = txt_keyword.Text;
                result.InnerHtml = f.findSpecificQuestion();
                result.Style.Add("display", "block");

            }
            err_msg.InnerHtml = f.err_Msg;

        }
    }
}