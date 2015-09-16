using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BDetFactura
    {

        public static void DetFactura_mnt01(EDetFactura dfac)
        {

            DDetFactura.DetFact_mnt01(dfac);

        }



        public static List<EDetProducto> mListarFact(EFactura ofac)
        {
            return DDetFactura.mListarDetFac(ofac);
        }


    }
}
