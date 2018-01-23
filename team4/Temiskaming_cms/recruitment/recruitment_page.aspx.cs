using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using recruitment.Models;

namespace recruitment
{
    public partial class recruitment_page : System.Web.UI.Page
    {
        recruitment_feature r = new recruitment_feature();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if(txt_keyword.Text.Length <= 0 || txt_keyword.Text == null) //if no keyword enter then filter by dropbox
            {
                if (job_category_list.Items.FindByText("All Categories").Selected && job_division_list.Items.FindByText("All Division").Selected)
                {
                    result.InnerHtml = Server.HtmlDecode(r.findSpecificJob());
                    result.Style.Add("display", "block");
                }else if (job_category_list.Items.FindByText("All Categories").Selected == false && job_division_list.Items.FindByText("All Division").Selected == false)
                {
                    r.job_category = job_category_list.Text;
                    r.job_division = job_division_list.Text;
                    result.InnerHtml = Server.HtmlDecode(r.findSpecificJob("both"));
                    result.Style.Add("display", "block");
                }
                else if (job_division_list.Items.FindByText("All Division").Selected && job_category_list.Items.FindByText("All Categories").Selected == false)
                {
                    r.job_category = job_category_list.Text;
                    result.InnerHtml = Server.HtmlDecode(r.findSpecificJob("division"));
                    result.Style.Add("display", "block");
                }
                else if (job_category_list.Items.FindByText("All Categories").Selected && job_division_list.Items.FindByText("All Division").Selected == false)
                {
                    r.job_division = job_division_list.Text;
                    result.InnerHtml = Server.HtmlDecode(r.findSpecificJob("category"));
                    result.Style.Add("display", "block");
                }
            }
            else //if keyword found then search by keyword
            {
                r.job_title = txt_keyword.Text;
                result.InnerHtml = Server.HtmlDecode(r.findSpecificJob("keyword"));
                txt_keyword.Text = "";
                result.Style.Add("display", "block");
                
            }
            err_msg.InnerHtml = r.err_Msg;
        }
    }
}