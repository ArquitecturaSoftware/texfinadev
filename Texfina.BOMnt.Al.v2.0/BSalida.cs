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
   public class BSalida
    {
       public static List<Texfina.Entity.Co.Dato> Al_Salida_GenCod(string idperiodo, string idEmpresa)
        {
            return DSalida.Al_Salida_GenCod(idperiodo, idEmpresa);

        }

       public static void AL_Salida_mnt01(ESalida obj)
        {
            DSalida.AL_Salida_mnt01(obj);
        }

       public static List<ESalida> Al_Salida_qry05(ESalida obj)
        {
            return DSalida.Al_Salida_qry05(obj);
        }

       public static ESalida AL_Salida_qry01(ESalida obj)
       {

           return DSalida.AL_Salida_qry01(obj);
       }


       public DataTable AL_Salida_rpt01(ESalida obj)
       {

           DSalida objS = new DSalida();

           DataTable dt = objS.AL_Salida_rpt01(obj);
           return dt;
       }

    }
}
