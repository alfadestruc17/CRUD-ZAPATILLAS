using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlConnector;
using MySqlConnection = MySqlConnector.MySqlConnection;


namespace Modelo
{
    public class ModelConnection
    {
        public static MySqlConnection getConnection() 
        {
            MySqlConnection con; 
            string server, database , user, password;
            server = "127.0.0.1";
            database = "zapatillas";
            user = "root";
            password = "";

            try
            {
                con = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                                "; uid = " + user +
                                                "; pwd = " + password);
                con.Open();
                return con;

            }
            catch (Exception)
            {
                return con = null;
            }
        }
    }
}
