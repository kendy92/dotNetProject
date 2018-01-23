using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactUs.Models;

namespace ContactUs
{
    public partial class Contact_page : System.Web.UI.Page
    {
        contact_feature c = new contact_feature();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
               c.provinceList(province_list);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            c.ID = Convert.ToInt32(province_list.SelectedValue);
            string address = c.SearchAddressById();
            result_text.InnerHtml = Server.HtmlDecode(address);
        }
    }
}