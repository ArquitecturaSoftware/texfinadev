using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOQry.TJ;
using Texfina.Entity.TJ;

namespace Texfina.BOQry.TJ
{
    public class BTejeduriaDet
    {

        public static List<ETejeduriaDet> mListarTejeduriaDet(ETejeduriaDet oTJD)
        {
            return DTejeduriaDet.TJ_Tejeduria_qry07(oTJD);
        }



        public static void TJ_TejeduriaDet_mnt01(ETejeduriaDet TJD)
        {
            DTejeduriaDet.TJ_TejeduriaDet_mnt01(TJD);
        }


        public static void TJ_TejeduriaDet_mnt03(ETejeduriaDet TJD)
        {
            DTejeduriaDet.TJ_TejeduriaDet_mnt03(TJD);
        }



    }
}
