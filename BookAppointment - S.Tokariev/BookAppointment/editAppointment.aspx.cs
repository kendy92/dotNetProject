using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAppointment.Models;

namespace BookAppointment
{
    public partial class editAppointment : System.Web.UI.Page
    {
        AppointmentFeature app_model = new AppointmentFeature();
        protected int appointment_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request.QueryString["id"], out appointment_id);
            if (IsPostBack)
            {
                return;
            }          
            if (appointment_id > 0)
            {
                string[] content = app_model.GetById(appointment_id);
                fullname.Text = content[0];
                email.Text = content[1];
                phone.Text = content[2];
                service.SelectedValue = content[3];
                a_date.Text = content[4];
                message.Text = content[5];
                if (Request.QueryString["view"] == "true")
                {
                    fullname.ReadOnly = true;
                    email.ReadOnly = true;
                    phone.ReadOnly = true;
                    service.Enabled = false;
                    a_date.ReadOnly = true;
                    message.ReadOnly = true;
                    submit.Enabled = false;
                    heading.InnerHtml = "View appointment";
                }
            }
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (fullname.Text.Length <= 0 || fullname.Text == "")
            {
                err_msg.InnerHtml = "Please enter patient's name";
                fullname.Focus();
            }
            else
            {
                app_model.Id = appointment_id;
                app_model.Fullname = Server.HtmlEncode(fullname.Text);
                app_model.Email = Server.HtmlEncode(email.Text);
                app_model.Phone = Server.HtmlEncode(phone.Text);
                app_model.Service = Convert.ToInt32(service.Text);
                app_model.Appointment_date = Convert.ToDateTime(a_date.Text);
                app_model.Message = Server.HtmlEncode(message.Text);
                bool result = app_model.Update();
                if (result)
                {
                    server_output.InnerHtml = "Appointment updated successfully";
                }
                else
                {
                    server_output.InnerHtml = app_model.err_message;
                }
            }
        }
    }
}