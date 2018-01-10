using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace faq_page.Models
{
    public class faq_feature:MasterDB
    {
        private string _faq_id;
        private string _question;
        private string _answer;
        private string _search_string;
        public string err_Msg = "";

        public string faq_id
        {
            get { return _faq_id; }
            set { _faq_id = value; }
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

        public string search_string
        {
            get { return _search_string; }
            set { _search_string = value; }
        }

        public bool DeleteRow()
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM faq WHERE id = :i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", Convert.ToInt32(faq_id)));
                int row = cmd.ExecuteNonQuery();
                return row > 0 ? true : false;
            }
            catch (OracleException)
            {

                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool InsertRow()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO faq VALUES(:i, :q, :a)";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("i", Convert.ToInt32(faq_id)));
                cmd.Parameters.Add(new OracleParameter("q", question));
                cmd.Parameters.Add(new OracleParameter("a", answer));
                int row = cmd.ExecuteNonQuery();
                return row > 0 ? true : false;
            }
            catch (OracleException)
            {

                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool UpdateRow()
        {
            try
            {
                conn.Open();
                string query = "UPDATE faq SET question= :q, answer= :a WHERE id= :i";
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("q", question));
                cmd.Parameters.Add(new OracleParameter("a", answer));
                cmd.Parameters.Add(new OracleParameter("i", Convert.ToInt32(faq_id)));
                int row = cmd.ExecuteNonQuery();
                return row > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            
        }

        public string showFAQ() //Show all content
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM faq ORDER BY id DESC";
                string result = "";
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                result += "<table><tbody><tr><th>ID</th><th>Question</th><th>Answer</th></tr>";
                while (reader.Read())
                {
                    result += "<tr><td>" + reader["id"] + "</td><td>" + reader["question"] + "</td>" +
                                        "<td>" + reader["answer"] + "</td></tr>";

                }
                result += "</tbody></table>";
                return result;
            }
            catch (OracleException oe)
            {

                throw oe;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public string displayAllFAQ() //Show all content
        {
            try
            {
                conn.Open();
                string query = "SELECT question,answer FROM faq ORDER BY id DESC";
                string result = "";
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
           
                while (reader.Read())
                {
                    result += "<h2>"+reader["question"]+"</h2><p>"+reader["answer"]+"</p>";

                }
                return result;
            }
            catch (OracleException oe)
            {

                throw oe;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public string findFAQ()
        {
            try
            {
                string result = "";
                conn.Open();
                string query = "SELECT * FROM faq WHERE question LIKE :q";
                string search = String.Format("%{0}%", search_string.ToLower());
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("q", search));
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result += "<h2>"+reader["question"]+"</h2><p>"+reader["answer"]+"</p>";
                }
                return result;
            }
            catch (OracleException oe)
            {
                throw oe; 

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }




    }
}