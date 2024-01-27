using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Configuration;

namespace FlightBooking  //DO NOT change the namespace name
{
    public class DBConnection  //DO NOT change the class name
    {
        //Implement code here

        public SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}