using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControllerProductos
    {
        public static int IdProducto { get; set; }
        public static string CodigoProducto { get; set; }
        public static int Existencias { get; set; }
        public static string Producto { get; set; }
        public static decimal Precio { get; set; }
        public static string Descripcion { get; set; }
        public static int IdMarca { get; set; }
        public static string fecha { get; set; }


        ControllerProductos(string pCodigoProducto, int pExistencias, string pProducto,
               decimal pPrecio, string pDescripcion, int pIdMarca, string pfecha)
        {
            CodigoProducto = pCodigoProducto;
            Existencias = pExistencias;
            Producto = pProducto;
            Precio = pPrecio;
            Descripcion = pDescripcion;
            IdMarca = pIdMarca;
            fecha = pfecha;
        }

        public bool Enviar_producto()
        {
            return Modelo.ModelProducto.RegistrarProducto(CodigoProducto, Existencias, Producto,
               Precio, Descripcion, IdMarca, fecha);
        }
        public static DataTable CargarMarcas (string id)
        {
            return Modelo.ModelProducto.InsMarcas(id);
        }
        public static DataTable obtenerMarcas()
        {
            return Modelo.ModelProducto.obtenerMarcas();
        }

        public static DataTable CargarMarcas()
        {
            throw new NotImplementedException();
        }
    }
}
