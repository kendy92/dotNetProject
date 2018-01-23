using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace Donation.Models
{
    public class MasterDB
    {
        private static string host = "calvin.humber.ca";
        private static string port = "1521";
        private static string sid = "grok";
        private static string user = "n01248070";
        private static string pass = "oracle";
        public OracleConnection conn = new OracleConnection(OracleConnString(host, port, sid, user, pass));
        public OracleCommand cmd;
        public OracleDataReader reader;


        public static string OracleConnString(string host, string port, string servicename, string user, string pass)
        {
            return String.Format(
              "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
              "(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
              host,
              port,
              servicename,
              user,
              pass);
        }
    }
}