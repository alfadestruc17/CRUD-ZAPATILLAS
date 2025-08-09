using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    internal class ControllerProductos
    {
        public static int ID { get; set; }
        public static string Nombre { get; set; }
        public static int id_marca { get; set; }
        public static int id_talla { get; set; }

        ControllerProductos(int pID, string pNombre, int pid_marca, int pid_talla)
        {
            ID = pID;
            Nombre = pNombre;
            id_marca = pid_marca;
            id_talla = pid_talla;
        }

        public bool Enviar_producto()
        {
            return Modelo.ModelProducto.RegistrarProducto(ID, Nombre, id_marca, id_talla);
        }
        public static DataTable CargarMarcas (string id)
        {
            return Modelo.ModelProducto.InsMarcas(id);
        }
        public static DataTable obtenerMarcas()
        {
            return Modelo.ModelProducto.obtenerMarcas
        }
    }
}
