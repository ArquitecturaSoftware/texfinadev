using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BProdXUnd
    {
        public static void ProdXUnd_mmt01(EProdXUnd prod)
        {
            DProdXUnd.ProdXUnd_mnt01(prod);

        }

        public static void ProdXUnd_mmt03(EProdXUnd prod)
        {
            DProdXUnd.ProdXUnd_mnt03(prod);

        }
    }
}
