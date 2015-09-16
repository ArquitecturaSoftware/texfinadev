using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Al;
using Texfina.Entity.Al;
using Texfina.Entity.Co;

namespace Texfina.BOMnt.Al
{
    public class BVendedor
    {
        public static DataSet MG_Vendedor_qry01(EVendedor vn)
        {
            return DVendedor.MG_Vendedor_qry01(vn);
        }


        public static List<Dato> ObtenerDatoProveedor(EVendedor v)
        {
            return DVendedor.ObtenerDatoVendedor(v);
        }

        public static List<Dato> MG_Vendedor_qry02(String obj)
        {
            return DVendedor.MG_Vendedor_qry02(obj);
        }
    }
}
