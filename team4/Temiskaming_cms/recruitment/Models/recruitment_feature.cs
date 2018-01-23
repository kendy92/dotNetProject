using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using Temiskaming_cms.Models;

namespace recruitment.Models
{
    public class recruitment_feature:MasterDB
    {
        //fields
        private int _job_id;
        private string _job_title;
        private string _job_desc;
        private string _job_require;
        private string _job_category;
        private string _job_division;
        private DateTime _job_postdate;
        public string err_Msg = "";
        public bool redirect = false;


        //properties
        public int job_id
        {
            get { return _job_id; }
            set { _job_id = value; }
        }
        public string job_title
        {
            get { return _job_title; }
            set { _job_title = value; }
        }
        public string job_desc
        {
            get { return _job_desc; }
            set { _job_desc = value; }
        }
        public string job_require
        {
            get { return _job_require; }
            set { _job_require = value; }
        }
        public string job_category
        {
            get { return _job_category; }
            set { _job_category = value; }
        }
        public string job_division
        {
            get { return _job_division; }
            set { _job_division = value; }
        }
        public DateTime job_postdate
        {
            get { return _job_postdate; }
            set { _job_postdate = value; }
        }


        //method
        public bool deleteRow()
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM recruitment WHERE id = :i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", job_id));
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

        public bool insertRow()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO recruitment VALUES(:j_i, :j_title, :j_desc, : j_require, :j_cate, :j_div, :j_date)";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("j_i", job_id));
                cmd.Parameters.Add(new OracleParameter("j_title", job_title));
                cmd.Parameters.Add(new OracleParameter("j_desc", job_desc));
                cmd.Parameters.Add(new OracleParameter("j_require", job_require));
                cmd.Parameters.Add(new OracleParameter("j_cate", job_category));
                cmd.Parameters.Add(new OracleParameter("j_div", job_division));
                cmd.Parameters.Add(new OracleParameter("j_date", job_postdate));
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

        public bool updateRow()
        {
            try
            {
                conn.Open();
                string query = "UPDATE recruitment SET job_title = :j_title, job_description = :j_desc, job_requirement = :j_require, job_category = :j_cate, job_division = :j_div , job_postdate = :j_date WHERE id = :j_i";
                cmd = new OracleCommand(query, conn);    
                cmd.Parameters.Add(new OracleParameter("j_title", job_title));
                cmd.Parameters.Add(new OracleParameter("j_desc", job_desc));
                cmd.Parameters.Add(new OracleParameter("j_require", job_require));
                cmd.Parameters.Add(new OracleParameter("j_cate", job_category));
                cmd.Parameters.Add(new OracleParameter("j_div", job_division));
                cmd.Parameters.Add(new OracleParameter("j_date", job_postdate));
                cmd.Parameters.Add(new OracleParameter("j_i", job_id));
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

        public string showRecruitmentData()
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM recruitment ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count <= 0)
                {
                    err_Msg = "No row found!";
                }else
                {
                    result += "<table><tbody><tr>" +
                    "<th>ID</th><th>Title</th><th>Description</th>" +
                    "<th>Requirement</th><th>Category</th><th>Division</th><th>Postdate</th>" +
                    "</tr>";
                    while (reader.Read())
                    {
                        result += "<tr><td>" + reader["id"] + "</td><td>" + reader["job_title"] + "</td>" +
                                            "<td>" + reader["job_description"] + "</td>" +
                                            "<td>" + reader["job_requirement"] + "</td>" +
                                            "<td>" + reader["job_category"] + "</td>" +
                                            "<td>" + reader["job_division"] + "</td>" +
                                            "<td>" + reader["job_postdate"].ToString().Substring(0, 10) + "</td>" +
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

        public void findJobById(TextBox title, TextBox desc, TextBox requirement, DropDownList div, DropDownList cate)
        {
            try
            {   
                conn.Open();
                string query = "SELECT * FROM recruitment WHERE id = :j_i ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("j_i", job_id));
                int row = cmd.ExecuteNonQuery();
                err_Msg = "1 rows found!";
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count <= 0)
                {
                    err_Msg = "No data found!";
                }else
                {
                    while (reader.Read())
                    {
                        title.Text = reader["job_title"].ToString();
                        desc.Text = reader["job_description"].ToString();
                        requirement.Text = reader["job_requirement"].ToString();
                        cate.ClearSelection();
                        cate.Items.FindByText(reader["job_category"].ToString()).Selected = true;
                        div.ClearSelection();
                        div.Items.FindByText(reader["job_division"].ToString()).Selected = true;
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

        public string findSpecificJob(string search_mode = "all") //"all" | default
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM recruitment ";
                if (search_mode == "all")
                {
                    query += "ORDER BY id DESC";
                }
                else if (search_mode == "both") {
                    query += "WHERE job_category = :j_cate AND job_division = :j_div";
                }
                else if (search_mode == "category")
                {
                    query += "WHERE job_division = :j_div ORDER BY id DESC";

                }
                else if (search_mode == "division")
                {
                    query += "WHERE job_category = :j_cate ORDER BY id DESC";

                } else
                {
                    query += "WHERE lower(job_title) LIKE :j_title";
                }

                cmd = new OracleCommand(query, conn);
                if (search_mode == "all")
                {
                    //no passing value
                }
                else if (search_mode == "both")
                {
                    cmd.Parameters.Add(new OracleParameter("j_cate", job_category));
                    cmd.Parameters.Add(new OracleParameter("j_div", job_division));
                }
                else if (search_mode == "category")
                {
                    cmd.Parameters.Add(new OracleParameter("j_div", job_division));
                }
                else if (search_mode == "division")
                {
                    cmd.Parameters.Add(new OracleParameter("j_cate", job_category));
                }
                else
                {
                    string format_keyword = String.Format("%{0}%", job_title.ToLower());
                    cmd.Parameters.Add(new OracleParameter("j_title", format_keyword));
                }

                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count <= 0)
                {
                    err_Msg = "No job found!";
                }else
                {
                    result += "<table><tbody><tr>" +
                    "<th>Job Title</th><th>Division</th>" +
                    "<th>Category</th><th>Postdate</th><th>Link</th>" +
                    "</tr>";
                    while (reader.Read())
                    {
                        
                        result += "<tr><td>" + reader["job_title"] + "</td>" +
                                            "<td>" + reader["job_division"] + "</td>" +
                                            "<td>" + reader["job_category"] + "</td>" +
                                            "<td>" + reader["job_postdate"].ToString().Substring(0,10) + "</td>" +
                                             "<td><a href='recruitment_content.aspx?position="+reader["id"]+ "'>View</a></td>" +
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

        public string[] showRecruitmentContent()
        {
            string[] data = new string[6];
            try
            {
                conn.Open();
                string query = "SELECT * FROM recruitment WHERE id = :job_i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("job_i",job_id));
                reader = cmd.ExecuteReader();
                if (reader.HasRows) //check if the job id is valid otherwise redirect user back to recruitment page
                {
                    while (reader.Read())
                    {

                        data[0] = reader["job_title"].ToString();
                        data[1] = reader["job_description"].ToString();
                        data[2] = reader["job_requirement"].ToString();
                        data[3] = reader["job_division"].ToString();
                        data[4] = reader["job_category"].ToString();
                    }
                }else
                { redirect = true; }
            }
            catch (OracleException oe)
            {
                data[5] = oe.Message.ToString();
                return data;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return data;
        }

    }
}