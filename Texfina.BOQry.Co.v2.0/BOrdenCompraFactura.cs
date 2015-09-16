using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;
using System.Data;

namespace Texfina.BOQry.Co
{
    public class BOrdenCompraFactura
    {
        public static List<EOrdenCompraFactura> mListarOcompraFactura(EOrdenCompraFactura oCompra)
        {
            return DOrdenCompraFactura.mListarOrdenCompraFact(oCompra);
        }

        public static List<EOrdenCompraFactura> mListarOcompraFactura2(EOrdenCompraFactura oCompra)
        {
            return DOrdenCompraFactura.mListarOrdenCompraFact2(oCompra);
        }

        public static void OrderCompraFact_mnt01(EOrdenCompraFactura oc)
        {
            DOrdenCompraFactura.CO_DetOrdenCompraFact_mnt01(oc);
        }
        
        /// <summary>
        /// Anular la factura
        /// </summary>
        /// <param name="oc"></param>
        public static void OrderCompraFact_mnt02(EOrdenCompraFactura oc)
        {
            DOrdenCompraFactura.CO_DetOrdenCompraFact_mnt02(oc);
        }


        public static IDataReader GenOCFac(string idperiodo, string idEmpresa,string oc)
        {
            return DOrdenCompraFactura.GEN_OC_FAC(idperiodo, idEmpresa,oc);
        }
    }
}
