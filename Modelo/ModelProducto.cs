using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelProducto
    {
        public static bool RegistrarProducto(string CodigoProducto,int Existencias,string Producto,
               decimal Precio,string Descripcion,int IdMarca,string fecha) 
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO Productos(CodigoProducto,Existencias,Producto,Precio,Descripcion,IdMarca,fecha)  VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", CodigoProducto,Existencias,Producto,Precio,Descripcion,IdMarca,fecha), ModelConnection.getConnection());
                retorno = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        public static DataTable InsMarcas (string id) 
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM Marcas WHERE IdMarca = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModelConnection.getConnection());
                cmd.Parameters.Add(new MySqlParameter("?param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable obtenerMarcas()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM Marcas";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModelConnection.getConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
    }
}
