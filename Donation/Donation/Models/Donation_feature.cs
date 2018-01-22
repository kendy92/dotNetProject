using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using Donation.Models;

namespace Donation.Models
{
    public class Donation_feature:MasterDB
    {
        //fields
        private string _don_amt;
        private string _title_name;
        private string _f_name;
        private string _l_name;
        private string _e_mail;
        private string _country_name;
        private string _address1;
        private string _address2;
        private string _city_n;
        private string _pr_st;
        private string _pcode;
        private string _pnumber;
        private string _don_desc_text;
        private string _cred_number;
        private string _cred_name;
        private string _cred_exp_date;
        private string _cred_sec_code;
        private int _id_val;
        public string err_Msg;
        
        public string don_amt
        {
            get { return _don_amt; }
            set { _don_amt = value; }
        }
        public string title_name
        {
            get { return _title_name; }
            set { _title_name = value; }
        }
        public string f_name
        {
            get { return _f_name; }
            set { _f_name = value; }
        }
        public string l_name
        {
            get { return _l_name; }
            set { _l_name = value; }
        }
        public string e_mail
        {
            get { return _e_mail; }
            set { _e_mail = value; }
        }
        public string country_name
        {
            get { return _country_name; }
            set { _country_name = value; }
        }
        public string address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        public string address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string city_n
        {
            get { return _city_n; }
            set { _city_n = value; }
        }
        public string pr_st
        {
            get { return _pr_st; }
            set { _pr_st = value; }
        }
        public string pcode
        {
            get { return _pcode; }
            set { _pcode = value; }
        }
        public string pnumber
        {
            get { return _pnumber; }
            set { _pnumber = value; }
        }
        public string don_desc_text
        {
            get { return _don_desc_text; }
            set { _don_desc_text = value; }
        }
        public string cred_number
        {
            get { return _cred_number; }
            set { _cred_number = value; }
        }
        public string cred_name
        {
            get { return _cred_name; }
            set { _cred_name = value; }
        }
        public string cred_exp_date
        {
            get { return _cred_exp_date; }
            set { _cred_exp_date = value; }
        }
        public string cred_sec_code
        {
            get { return _cred_sec_code; }
            set { _cred_sec_code = value; }
        }
        public int id_val
        {
            get { return _id_val; }
            set { _id_val = value; }
        }
        //methods

        public bool insertRow()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO DONATION_SECTION (DONATION_AMOUNT,TITLE,FIRST_NAME,LAST_NAME,EMAIL,COUNTRY,ADDRESS_1,ADDRESS_2,CITY,PROVINCE_STATE,POSTAL_ZIP_CODE,PHONE,DESCRIPTION, CREDIT_CARD_NUMBER, CARDHOLDERS_NAME, EXPIRATION_DATE, CARD_SECURITY_CODE) VALUES(:d_a, :t_n, :f_n, :l_n, :e_m, :c_n, :a_1, :a_2, :city_n, :p_s, :p_c, :p_n, :d_d_t, :cr_num, :cr_name, :cr_e_d, :cr_s_c)";
                cmd = new OracleCommand(query, conn); 
                cmd.Parameters.Add(new OracleParameter("d_a", don_amt));
                cmd.Parameters.Add(new OracleParameter("t_n", title_name));
                cmd.Parameters.Add(new OracleParameter("f_n", f_name));
                cmd.Parameters.Add(new OracleParameter("l_n", l_name));
                cmd.Parameters.Add(new OracleParameter("e_m", e_mail));
                cmd.Parameters.Add(new OracleParameter("c_n", country_name));
                cmd.Parameters.Add(new OracleParameter("a_1", address1));
                cmd.Parameters.Add(new OracleParameter("a_2", address2));
                cmd.Parameters.Add(new OracleParameter("city_n", city_n));
                cmd.Parameters.Add(new OracleParameter("p_s", pr_st));
                cmd.Parameters.Add(new OracleParameter("p_c", pcode));
                cmd.Parameters.Add(new OracleParameter("p_n", pnumber));
                cmd.Parameters.Add(new OracleParameter("d_d_t", don_desc_text));
                cmd.Parameters.Add(new OracleParameter("cr_num", cred_number));
                cmd.Parameters.Add(new OracleParameter("cr_name", cred_name));
                cmd.Parameters.Add(new OracleParameter("cr_e_d", cred_exp_date));
                cmd.Parameters.Add(new OracleParameter("cr_s_c", cred_sec_code));
                int row = cmd.ExecuteNonQuery();
                err_Msg = row.ToString() + " row inserted";
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {
                err_Msg = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public bool deleteRow()
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM DONATION_SECTION WHERE id = :i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", id_val));
                int row = cmd.ExecuteNonQuery();
                err_Msg = row.ToString() + " row deleted";
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {
                err_Msg = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public string showDonationData()
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM DONATION_SECTION ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    err_Msg = "No row found!";
                }
                else
                {
                    result += "<table><tbody><tr>" +
                    "<th>ID</th><th>Donation Amount</th><th>Title</th><th>First name</th><th>Last name</th>" +
                    "<th>Email</th><th>Country</th><th>Address 1</th><th>Address 2</th><th>City</th><th>Province/State</th>" +
                    "<th>Postal code</th><th>Phone</th><th>Description</th></tr>"; 
                    while (reader.Read())
                    {
                        result += "<tr><td>" + reader["id"] + "</td><td>" + reader["DONATION_AMOUNT"] + "</td>" +
                                            "<td>" + reader["TITLE"] + "</td>" +
                                            "<td>" + reader["FIRST_NAME"] + "</td>" +
                                            "<td>" + reader["LAST_NAME"] + "</td>" +
                                            "<td>" + reader["EMAIL"] + "</td>" +
                                            "<td>" + reader["COUNTRY"] + "</td>" +
                                            "<td>" + reader["ADDRESS_1"] + "</td>" +
                                            "<td>" + reader["ADDRESS_2"] + "</td>" +
                                            "<td>" + reader["CITY"] + "</td>" +
                                            "<td>" + reader["PROVINCE_STATE"] + "</td>" +
                                            "<td>" + reader["POSTAL_ZIP_CODE"] + "</td>" +
                                            "<td>" + reader["PHONE"] + "</td>" +
                                            "<td>" + reader["DESCRIPTION"] + "</td>" +
                                            "</tr>";
                    }
                    result += "</tbody></table>";
                }
                return result;
            }
            catch (OracleException oe)
            {
                err_Msg = oe.Message.ToString();
                return err_Msg;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public void findById(TextBox id, DropDownList title, TextBox fname, TextBox lname, 
            TextBox email, TextBox country, TextBox add1, TextBox add2, TextBox city, TextBox prst,
            TextBox postzip, TextBox phone, DropDownList tod) 
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM DONATION_SECTION WHERE id = :i ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", id_val));
                int row = cmd.ExecuteNonQuery();
                err_Msg = "1 rows found!";
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    err_Msg = "No data found!";
                }
                else
                {
                    while (reader.Read())
                    {
                        id.Text = reader["ID"].ToString();
                        title.ClearSelection();
                        title.Items.FindByText(reader["TITLE"].ToString()).Selected = true;
                        fname.Text = reader["FIRST_NAME"].ToString();
                        lname.Text = reader["LAST_NAME"].ToString();
                        email.Text = reader["EMAIL"].ToString();
                        country.Text = reader["COUNTRY"].ToString();
                        add1.Text = reader["ADDRESS_1"].ToString();
                        add2.Text = reader["ADDRESS_2"].ToString();
                        city.Text = reader["CITY"].ToString();
                        prst.Text = reader["PROVINCE_STATE"].ToString();
                        postzip.Text = reader["POSTAL_ZIP_CODE"].ToString();
                        phone.Text = reader["PHONE"].ToString();
                        tod.ClearSelection();
                        tod.Items.FindByText(reader["DESCRIPTION"].ToString()).Selected = true;
                    }
                }
            }
            catch (OracleException oe)
            {
                err_Msg = oe.Message.ToString();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public bool updateRow()
        {
            try
            {
                conn.Open();
                string query = "UPDATE DONATION_SECTION SET TITLE = :p_title, FIRST_NAME = :p_f_name, LAST_NAME = :p_l_name, EMAIL = :p_email, COUNTRY = :p_country, ADDRESS_1 = :p_addr1, ADDRESS_2 = :p_addr2, CITY = :p_city, PROVINCE_STATE = :p_pr_st, POSTAL_ZIP_CODE = :p_post_zip, PHONE = :p_phone, DESCRIPTION = :p_desc WHERE ID = :p_id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("p_title", title_name));
                cmd.Parameters.Add(new OracleParameter("p_f_name", f_name));
                cmd.Parameters.Add(new OracleParameter("p_l_name", l_name));
                cmd.Parameters.Add(new OracleParameter("p_email", e_mail));
                cmd.Parameters.Add(new OracleParameter("p_country", country_name));
                cmd.Parameters.Add(new OracleParameter("p_addr1", address1));
                cmd.Parameters.Add(new OracleParameter("p_addr2", address2));
                cmd.Parameters.Add(new OracleParameter("p_city", city_n));
                cmd.Parameters.Add(new OracleParameter("p_pr_st", pr_st));
                cmd.Parameters.Add(new OracleParameter("p_post_zip", pcode));
                cmd.Parameters.Add(new OracleParameter("p_phone", pnumber));
                cmd.Parameters.Add(new OracleParameter("p_desc", don_desc_text));
                cmd.Parameters.Add(new OracleParameter("p_id", id_val));
                int row = cmd.ExecuteNonQuery();
                err_Msg = row.ToString() + " row updated";
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {
                err_Msg = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}