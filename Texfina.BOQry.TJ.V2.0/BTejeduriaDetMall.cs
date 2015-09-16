using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOQry.TJ;
using Texfina.Entity.TJ;

namespace Texfina.BOQry.TJ
{
   public  class BTejeduriaDetMall
    {

       public static List<ETejeduria_DetMall> mListarTejeduriaDetMall(ETejeduria_DetMall oTJD)
       {
           return DTejeduriaDetMall.TJ_TejeduriaDetMall_qry07(oTJD);
       }


       public static void TJ_Tejeduria_DetMall_mnt01(ETejeduria_DetMall TJD)
       {
           DTejeduriaDetMall.TJ_Tejeduria_DetMall_mnt01(TJD);
       }
    }
}
