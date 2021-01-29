using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace forest
{
    class DB
    {
        static string host = "localhost";
        static int port = 3306;
        static string database = "simple_database";
        static string username = "root";
        static string password = "root";
        // Connection String.
        static string connectionString = "Server=" + host + ";Database=" + database
            + ";port=" + port + ";User Id=" + username + ";password=" + password;
        MySqlConnection connection;


        public DB()
        {
            connection = new MySqlConnection(connectionString);
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
