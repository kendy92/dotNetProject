using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;

namespace ContactUs.Models
{
    public class contact_feature : MasterDB
    {
        //fields
        private int _ID;
        private string _PROVINCE;
        private string _ADDRESS;
        public string err_msg = "";

        //properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string PROVINCE
        {
            get { return _PROVINCE; }
            set { _PROVINCE = value; }
        }

        public string ADDRESS
        {
            get { return _ADDRESS; }
            set { _ADDRESS = value; }
        }

        //method
        public bool AddRecord()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO CONTACT_US VALUES(:id, :province, :address)";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", ID));
                cmd.Parameters.Add(new OracleParameter("province", PROVINCE));
                cmd.Parameters.Add(new OracleParameter("address", ADDRESS));
                int row = cmd.ExecuteNonQuery();
                err_msg = "Record added Successfully";
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


        public bool UpdateRecord()
        {
            try
            {
                conn.Open();
                string query = "Update CONTACT_US set PROVINCE=:province, ADDRESS=:address where ID=:id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("province", PROVINCE));
                cmd.Parameters.Add(new OracleParameter("address", ADDRESS));
                cmd.Parameters.Add(new OracleParameter("id", ID));
                int row = cmd.ExecuteNonQuery();
                err_msg = "Record Updated Successfully";
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public string viewAllRecord()
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM CONTACT_US ORDER BY ID DESC";
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    result = "<table><tbody><tr>" +
                    "<th>ID</th><th>Province</th><th>Address</th>" +
                    "</tr>"+
                    "<tr><td colspan='3' style='text-align:center;'> No Record Found </td></tr>"+
                    "</tbody></table>";
                }
                else
                {
                    result = "<table><tbody><tr>" +
                    "<th>ID</th><th>Province</th><th>Address</th>" +
                    "</tr>";
                    while (reader.Read())
                    {
                        result += "<tr><td>" + reader["ID"] + "</td><td>" + reader["PROVINCE"] + "</td>" +
                                            "<td>" + reader["ADDRESS"] + "</td>" +
                                            "</tr>";
                    }
                    result += "</tbody></table>";
                }

                return result;
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
                return err_msg;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


        public void SearchRecordById(TextBox province_name, TextBox txt_address)
        {
            try
            {
                conn.Open();
                
                string query = "SELECT * FROM CONTACT_US where ID =:id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", ID));
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    err_msg = "No record found!";
                }
                else
                {
                    while (reader.Read())
                    {
                        province_name.Text = reader["PROVINCE"].ToString();
                        txt_address.Text = reader["ADDRESS"].ToString();
                    }
                }
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


        public bool DeleteRecord()
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM CONTACT_US WHERE ID = :id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", ID));
                int row = cmd.ExecuteNonQuery();
                err_msg = "Record deleted Successfully";
                return row > 0 ? true : false;
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


        public void provinceList(DropDownList provinceList)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM CONTACT_US ORDER BY ID ASC";
                cmd = new OracleCommand(query, conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
               // DataTable dt = new DataTable();

                DataSet ds = new DataSet();

                oda.Fill(ds);
                provinceList.DataSource = ds;
                provinceList.DataBind();
                provinceList.DataTextField = "PROVINCE";
                provinceList.DataValueField = "ID";
                provinceList.DataBind();
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public string SearchAddressById()
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM CONTACT_US where ID =:id";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", ID));
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    err_msg = "No Address found!";
                    return err_msg;
                }
                else
                {
                    string address = "";

                    if (reader.Read())
                    {
                       // province_name.Text = reader["PROVINCE"].ToString();
                        address = reader["ADDRESS"].ToString();
                        
                    }
                    return address;
                }
            }
            catch (OracleException oe)
            {
                err_msg = oe.Message.ToString();
                return err_msg;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

    }
}