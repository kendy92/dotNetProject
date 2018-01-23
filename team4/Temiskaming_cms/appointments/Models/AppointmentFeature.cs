using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Temiskaming_cms.Models;

namespace BookAppointment.Models
{
    public class AppointmentFeature : MasterDB
    {
        //properties
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Service { get; set; }
        public DateTime Appointment_date { get; set; }
        public string Message { get; set; }
        public string err_message { get; set; }

        //methods
        public bool Insert()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO hospital_appointments" +
                    "(fullname,email,phone,service_id,appointment_date,message)" +
                    " VALUES(:fullname, :email, :phone, :service_id, :a_date, :message)";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("fullname", Fullname));
                cmd.Parameters.Add(new OracleParameter("email", Email));
                cmd.Parameters.Add(new OracleParameter("phone", Phone));
                cmd.Parameters.Add(new OracleParameter("service_id", Service));
                cmd.Parameters.Add(new OracleParameter("a_date", Appointment_date));
                cmd.Parameters.Add(new OracleParameter("message", Message));
                int row = cmd.ExecuteNonQuery();
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {

                err_message = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public bool Update()
        {
            try
            {
                conn.Open();
                string query = "UPDATE hospital_appointments SET " +
                    "fullname = :fullname, email = :email, phone = :phone, " +
                    "service_id = :service_id, appointment_date = :a_date, message = :message " +
                    "WHERE id = :id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("fullname", Fullname));
                cmd.Parameters.Add(new OracleParameter("email", Email));
                cmd.Parameters.Add(new OracleParameter("phone", Phone));
                cmd.Parameters.Add(new OracleParameter("service_id", Service));
                cmd.Parameters.Add(new OracleParameter("a_date", Appointment_date));
                cmd.Parameters.Add(new OracleParameter("message", Message));
                cmd.Parameters.Add(new OracleParameter("id", Id));

                int row = cmd.ExecuteNonQuery();
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {

                err_message = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public bool DeleteById(int id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM hospital_appointments WHERE id = :id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", id));
                int row = cmd.ExecuteNonQuery();
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {

                err_message = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public string[] GetById(int id)
        {
            string[] content = new string[6];
            try
            {
                conn.Open();
                string query = "SELECT fullname,email,phone,service_id,appointment_date,message FROM hospital_appointments WHERE id=:id ";

                cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(new OracleParameter("id", id));
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        content[0] = reader["FULLNAME"].ToString();
                        content[1] = reader["EMAIL"].ToString();
                        content[2] = reader["PHONE"].ToString();
                        content[3] = reader["SERVICE_ID"].ToString();
                        content[4] = Convert.ToDateTime(reader["APPOINTMENT_DATE"].ToString()).ToShortDateString();
                        content[5] = reader["MESSAGE"].ToString();
                    }
                }                
            }
            catch (Exception e)
            {
                return content;

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return content;
        }
        public string Search(string fullname, string service_string_id)
        {
            string content = "";
            try
            {
                conn.Open();
                string query = "SELECT a.*,s.service_name as service_name FROM hospital_appointments a " +
                    "JOIN hospital_services s on a.service_id=s.service_id WHERE 1=1 ";
                int service_id;
                int.TryParse(service_string_id, out service_id);
                if (fullname.Length > 0)
                {
                    query += "and a.fullname LIKE '%'||:fullname||'%' ";
                }
                if (service_id > 0)
                {
                    query += "and s.service_id=:service_id ";
                }
                query += " ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                if (fullname.Length > 0)
                {
                    cmd.Parameters.Add(new OracleParameter("fullname", fullname));
                }
                if (service_id > 0)
                {
                    cmd.Parameters.Add(new OracleParameter("service_id", service_id));
                }
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string row = "";
                        row += "<tr>";
                        row += "<td>" + reader["ID"].ToString() + "</td>";
                        row += "<td>" + reader["FULLNAME"].ToString() + "</td>";
                        row += "<td>" + reader["EMAIL"].ToString() + "</td>";
                        row += "<td>" + reader["PHONE"].ToString() + "</td>";
                        row += "<td>" + reader["SERVICE_NAME"].ToString() + "</td>";
                        row += "<td>" + Convert.ToDateTime(reader["APPOINTMENT_DATE"].ToString()).ToShortDateString() + "</td>";
                        row += "<td class='actions'>" +
                            "<a href = 'editAppointment.aspx?view=true&id=" + reader["ID"].ToString() + "' >" +
                            "<i class='fa fa-eye' aria-hidden='true' title='view'></i></a>" +
                            "<a href = 'editAppointment.aspx?id=" + reader["ID"].ToString() + "' >" +
                            "<i class='fa fa-pencil-square-o' aria-hidden='true' title='edit'></i></a>" +
                            "<a href = '?delete=true&id=" + reader["ID"].ToString() + "' >" +
                            "<i class='fa fa-times' aria-hidden='true' title='delete'></i></a>"
                        + "</td>";
                        row += "</tr>";
                        content += row;
                    }
                }
                else
                {
                    content += "<tr><td colspan='7'>No appointments found</td></tr>";
                }
            }
            catch (Exception e)
            {
                return "<tr><td colspan='7'>" + e.Message.ToString() + "</td></tr>";

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return content;
        }
    }
}