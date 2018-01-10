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
            faq_content.InnerHtml = f.displayAllFAQ();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            result.Style.Add("display", "block");
            f.search_string = txt_search.Text;
            result.InnerHtml = f.findFAQ();
            
        }
    }
}