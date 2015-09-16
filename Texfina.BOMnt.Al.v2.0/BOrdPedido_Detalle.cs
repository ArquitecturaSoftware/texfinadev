using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Al;
using Texfina.Entity.Al;

namespace Texfina.BOMnt.Al
{
    public class BOrdPedido_Detalle
    {


        public static void VE_OrdPedido_Detalle_mnt01(EOrdPedido_Detalle obj)
        {
            DOrdPedido_Detalle.VE_OrdPedido_Detalle_mnt01(obj);
        }

        public static DataSet VE_OrdPedido_Detalle_qry01(EParametros obj)
        {

            return DOrdPedido_Detalle.VE_OrdPedido_Detalle_qry01(obj);
        }

        public static List<EOrdPedido_Detalle> VE_OrdPedido_Detalle_qry02(EOrdPedido_Detalle obj)
        {
            return DOrdPedido_Detalle.VE_OrdPedido_Detalle_qry02(obj);
        }

        public static void VE_OrdPedido_Detalle_mnt03(EOrdPedido_Detalle obj)
        {
            DOrdPedido_Detalle.VE_OrdPedido_Detalle_mnt03(obj);

        }


        public static void VE_OrdPedido_Detalle_mnt05(EOrdPedido_Detalle obj)
        {
            DOrdPedido_Detalle.VE_OrdPedido_Detalle_mnt05(obj);
        }

    }
}
