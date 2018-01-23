using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAppointment.Models;
using Oracle.ManagedDataAccess.Client;


namespace BookAppointment
{
    public partial class appointment_list : System.Web.UI.Page
    {
        AppointmentFeature app_model = new AppointmentFeature();
        protected void Page_Load(object sender, EventArgs e)
        {
            int appointment_id;
            int.TryParse(Request.QueryString["id"], out appointment_id);
            if (Request.QueryString["delete"] == "true" 
                && Request.QueryString["id"]!=""&& appointment_id > 0)
            {
                if (app_model.DeleteById(appointment_id)) {
                    Response.Redirect("appointment_list.aspx");
                }
                else
                {
                    a_table.InnerHtml = "<tr><td colspan='7'>" + app_model.err_message + "</td></tr>";
                }
                
            }
            else
            {
                a_table.InnerHtml = app_model.Search("", "");
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            
            a_table.InnerHtml = app_model.Search(fullname.Text, service.Text);
        }
        
    }
}