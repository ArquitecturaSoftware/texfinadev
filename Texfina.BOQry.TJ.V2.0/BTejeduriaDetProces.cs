using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOQry.TJ;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace Texfina.BOQry.TJ
{
   public  class BTejeduriaDetProces
    {
       public static List<ETejeduria_DetProces> mListarTejeduriaDetProces(ETejeduria_DetProces oTJD)
       {
           return DTejeduriaDetProces.TJ_TejeduriaDetProces_qry07(oTJD);
       }


       public static List<Dato> ObtenerDatoProces()
       {
           return DTejeduriaDetProces.ObtenerDato();
       }


       public static List<Dato> MG_RutaProceso_qry03()
       {
           return DTejeduriaDetProces.MG_RutaProceso_qry03();
       }


       public static void TJ_TejeduriaRutaProces_mnt01(ETejeduria_DetProces TJDP)
       {
           DTejeduriaDetProces.TJ_TejeduriaRutaProces_mnt01(TJDP);
       }

       public static void TJ_TejeduriaRutaProces_mnt03(ETejeduria_DetProces TJDP)
       {
           DTejeduriaDetProces.TJ_TejeduriaRutaProces_mnt03(TJDP);
       }

    }
}
