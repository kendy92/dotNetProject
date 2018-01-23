using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using Temiskaming_cms.Models;

namespace faq_page.Models
{
    public class faq_feature:MasterDB
    {
        //fields
        private int _id;
        private string _question;
        private string _answer;
        public string err_Msg = "";
        HttpServerUtility serverHttp;


        //properties
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string question
        {
            get { return _question; }
            set { _question = value; }
        }
        public string answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        //method
        public bool deleteRow()
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM faq WHERE id = :i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", id));
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
                string query = "INSERT INTO faq VALUES(:i, :q, :a)";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", id));
                cmd.Parameters.Add(new OracleParameter("q", question));
                cmd.Parameters.Add(new OracleParameter("a", answer));
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
                string query = "UPDATE faq SET question = :q, answer = :a WHERE id = :i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("q", question));
                cmd.Parameters.Add(new OracleParameter("a", answer));
                cmd.Parameters.Add(new OracleParameter("i", id));
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

        public string ShowFAQData()
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM faq ORDER BY id DESC";
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
                    "<th>ID</th><th>Question</th><th>Answer</th>" +
                    "</tr>";
                    while (reader.Read())
                    {
                        result += "<tr><td>" + reader["id"] + "</td><td>" + reader["question"] + "</td>" +
                                            "<td>" + reader["answer"] + "</td>" +
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

        public string ShowFAQContent()
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM faq ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    err_Msg = "No row found!";
                }
                else
                {
                    while (reader.Read())
                    {
                        result += "<h2>"+reader["question"]+"</h2><p>"+ reader["answer"] + "</p>";
                    }
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

        public void findQuestionById(TextBox q, TextBox a)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM faq WHERE id = :i ORDER BY id DESC";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", id));
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
                        q.Text = reader["question"].ToString();
                        a.Text = reader["answer"].ToString();
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

        public string findSpecificQuestion()
        {
            try
            {
                conn.Open();
                string result = "";
                string query = "SELECT * FROM faq WHERE lower(question) LIKE :q";
                cmd = new OracleCommand(query, conn);
                string format_keyword = String.Format("%{0}%", question.ToLower());
                cmd.Parameters.Add(new OracleParameter("q", format_keyword));

                reader = cmd.ExecuteReader();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    err_Msg = "No row found!";
                }
                else
                {
                    while (reader.Read())
                    {
                        result += "<h2>" + reader["question"] + "</h2><p>" + reader["answer"] + "</p>";
                    }
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

    }
}