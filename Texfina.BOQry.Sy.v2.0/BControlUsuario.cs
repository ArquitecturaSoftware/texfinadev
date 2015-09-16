using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.DOQry.Sy;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;

namespace Texfina.BOQry.Sy
{
   public class BControlUsuario
    {

       public static List<Dato> ObtenerModulo()
       {
           return DControlUsuario.ObteneModulo();
       }

       public static List<Dato> ObtenerFormulario(string u)
       {
           return DControlUsuario.ObtenerFormulario(u);
       }

       public static void SY_ControlUsuario_mnt01(EControlUsuario U)
       {
           DControlUsuario.SY_ControlUsuario_mnt01(U);
       }


       public static List<EControlUsuario> mListarControlUsuario(EControlUsuario oCompra)
       {
           return DControlUsuario.mListarControlUsuario(oCompra);
       }



       public static List<EControlUsuario> SY_ControlFormulario_qry01(EControlUsuario obj)
       {
           return DControlUsuario.SY_ControlFormulario_qry01(obj);
       }

    }
}
