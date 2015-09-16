using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BProducto
    {

        public static DataSet GetListFill(EProducto prod)
        {
            return DProducto.ProductoFill(prod);
        }

        public static DataSet GetListFill_(EProducto prod) //llenar la bandeja de productos para su actualizacion respectiva
        {
            return DProducto.ProductoFill_(prod);
        }


        public static IDataReader getCodigo(EProducto prod)
        {
            return DProducto.GenCodProducto_qry01(prod);
        }

        /// <summary>
        /// codigo para generar codigo del maestro de productos
        /// </summary>

        public static List<Dato> getCodigo_(EProducto prod)
        {
            return DProducto.GenCodProducto_qry01_(prod);
        }


        public static void ProductoInsert(EProducto prod)
        {
              DProducto.Producto_Insert(prod);
        }

        public static List<EProdXUnd> mListarProducto(EProdXUnd oprod)
        {
            return DProdXUnd.GetListProducto_sql01(oprod);
        }    


        public static EProducto mObtenerPROD(EProducto oCompra)
        {
            return DProducto.mObtenerProducto(oCompra);
        }


        public static EDetProducto mListarProductoDG(EDetProducto eprod)
        {
            return DProducto.mListarProductoDGen(eprod);
        }


        public static List<EProducto> MG_Producto_qry06(EProducto oprod)
        {
            return DProducto.MG_Producto_qry06(oprod);
        }

    }
}
