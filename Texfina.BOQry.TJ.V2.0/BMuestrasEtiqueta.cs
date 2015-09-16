using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOQry.TJ;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace Texfina.BOQry.TJ
{
   public class BMuestrasEtiqueta
    {
       public static DataSet MS_MuestraEtiquetaTela_qry02(ETejeduria TJ)
       {
           return DMuestrasEtiqueta.MS_MuestraEtiquetaTela_qry02(TJ);
       }

       public static ETejeduria MS_MuestraEtiquetaTela_qry01(ETejeduria oTJ)
       {

           return DMuestrasEtiqueta.TJ_MuestrasEtiqueta_qry01(oTJ);
       }



       public static List<ETejeduria_DetProces> MS_MuestrasEtiquetaDet_qry03(ETejeduria_DetProces oTJD)
       {
           return DMuestrasEtiqueta.MS_MuestrasEtiquetaDet_qry03(oTJD);
       }



       public DataTable GetMuestraEtiqueta_rpt01(ETejeduria oc)
       {

           //return DOrdenCompra.OrdenCompra_rpt01(oc);
           DMuestrasEtiqueta objtj = new DMuestrasEtiqueta();

           DataTable dt = objtj.GetMuestraEtiqueta_rpt01(oc);
           return dt;
       }

       public DataTable GetMuestraEtiqueta_rpt02(ETejeduria oc)
       {

           //return DOrdenCompra.OrdenCompra_rpt01(oc);
           DMuestrasEtiqueta objtj = new DMuestrasEtiqueta();

           DataTable dt = objtj.GetMuestraEtiqueta_rpt02(oc);
           return dt;
       }


       public static void MS_MuestrasEtiqueta_mnt01(EEtiqueta_tela ms)
       {
           DMuestrasEtiqueta.MS_MuestraEtiqueta_mnt01(ms);
       }

       public static List<Dato> MuestraEtiquetaCodBar_qry01(string idEmpresa,string idperiodo, string nutf)
       {

           return DMuestrasEtiqueta.MuestraEtiquetaCodBar_qry01(idEmpresa,idperiodo,nutf);
       }
    }
}
