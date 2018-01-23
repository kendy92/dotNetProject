using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAppointment.Models;

namespace BookAppointment
{
    public partial class clientPage : System.Web.UI.Page
    {
        AppointmentFeature app_model = new AppointmentFeature();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        protected void resetFields()
        {
            fullname.Text = "";
            email.Text = "";
            phone.Text = "";
            service.Text = "";
            date.Text = "";
            message.Text = "";
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (fullname.Text.Length <= 0 || fullname.Text == "")
            {
                err_msg.InnerHtml = "Please enter your name";
                fullname.Focus();
            }
            else if (!IsValidEmail(email.Text))
            {
                err_msg.InnerHtml = "Please enter valid email";
                email.Focus();
            }
            else if (phone.Text.Length <= 0 || phone.Text == "")
            {
                err_msg.InnerHtml = "Please enter email";
                phone.Focus();
            }
            else if (service.Text.Length <= 0 || service.Text == "")
            {
                err_msg.InnerHtml = "Please select requested service";
                service.Focus();
            }
            else if (date.Text.Length <= 0 || date.Text == "")
            {
                err_msg.InnerHtml = "Please choose date";
                date.Focus();
            }
            else
            {
                app_model.Fullname = Server.HtmlEncode(fullname.Text);
                app_model.Email = Server.HtmlEncode(email.Text);
                app_model.Phone = Server.HtmlEncode(phone.Text);
                app_model.Service = Convert.ToInt32(service.Text);
                app_model.Appointment_date = Convert.ToDateTime(date.Text);
                app_model.Message = Server.HtmlEncode(message.Text);
                bool result = app_model.Insert();
                if (result)
                {
                    resetFields();
                    err_msg.InnerHtml = "Thank you, your appointment is under review";
                }
                else
                {
                    err_msg.InnerHtml = app_model.err_message;
                }
            }

        }
    }
}