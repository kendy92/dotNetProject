using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using recruitment.Models;

namespace recruitment
{
    public partial class recruitment_content : System.Web.UI.Page
    {
        recruitment_feature r = new recruitment_feature();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["position"] != null || Request.QueryString["position"] != "")
            {
                int job_id = Convert.ToInt32(Request.QueryString["position"]);
                r.job_id = job_id;
                string[] data = r.showRecruitmentContent();
                h_title.InnerHtml = data[0];
                h_category.InnerHtml = "Category: " + data[4];
                h_division.InnerHtml = "Division: " + data[3];
                c_desc.InnerHtml = Server.HtmlDecode(data[1]);
                c_require.InnerHtml = Server.HtmlDecode(data[2]);
                
            }
        }
    }
}