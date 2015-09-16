using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;
namespace Texfina.BOQry.Co
{
    public class BProveedor
    {

        public static DataSet ProveedorFill(EProveedor prov)
        {
            return DProveedor.ProveedorFill(prov);
        }

        public static List<Dato> ObtenerDatoProveedor(EProveedor prov)
        {
            return DProveedor.ObtenerDatoProveedor("MG_Tercero_qry01", "Codigo", "Razon Social", prov);
        }


        public static DataSet Proveedor_qry03(ETerceros prov)
        {
            return DProveedor.Proveedor_qry03(prov);
        }

        public static IDataReader Proveedor_qry02(EProveedor prov)
        {
            return DProveedor.Proveedor_qry02(prov);
        }

        public static ETerceros mObtenerCliProv_(ETerceros oCliProv)
        {
            return DProveedor.mObtenerProveedor(oCliProv);
        }

        public static List<ETerceros> MG_Tercero_qry05(ETerceros oCliProv)
        {
            return DProveedor.MG_Tercero_qry05(oCliProv);
        }

        public static DataSet DeleteCliProv(ETerceros oCliProv)
        {
            return DProveedor.Proveedor_mnt02(oCliProv);
        }

    }
}
