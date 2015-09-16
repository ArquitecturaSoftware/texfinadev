using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BDetOrdenCompra
    {
        public static void DetOrderCompra_mnt01(EDetOrdenCompra oc)
        {

            DDetOrdenCompra.OrdenCompra_mnt03(oc);

        }


        public static List<EDetProducto> mListarOcompra(EOrdenCompra oCompra)
        {
            return DDetOrdenCompra.mListarDetOrdenCompra(oCompra);
        }





        public static List<EDetProducto> mListarOcompraFac(EOrdenCompra oCompra)
        {
            return DDetOrdenCompra.mListarDetOrdenCompraFac(oCompra);
        }




        public static void DetOrderCompra_mnt02(EDetOrdenCompra oc)
        {

            DDetOrdenCompra.CO_DetOrdenCompra_mnt02(oc);

        }

    }
}
