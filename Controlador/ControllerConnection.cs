using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Controlador
{ 
    public class ControllerConnection
    {
        public static MySqlConnection getControllerConnection()
        {
            return Modelo.ModelConnection.getConnection();
        }
    }
}

