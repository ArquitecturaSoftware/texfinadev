using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;
namespace Texfina.BOQry.Co
{
   public  class BTablaGeneral
    {
       //web
       public static IDataReader TablaGeneralFill(String codigo)
       {
           return DTablaGeneral.TablaGeneralFill(codigo);
       }

       //desktop

       public static List<Dato> tablaGeneral(String codigo)
       {
           return DTablaGeneral.tablaGeneral(codigo);
       }

       public static List<Dato> tablaGeneral_2(String codigo)
       {
           return DTablaGeneral.tablaGeneral_2(codigo);
       }


       public static IDataReader TablaGeneral_qry02(String id)
       {
           return DTablaGeneral.TablaGeneral_qry02(id);
       }

       public static IDataReader MG_TablaGenDet_qry04(String idtabla, String codigo)
       {
           return DTablaGeneral.MG_TablaGenDet_qry04(idtabla,codigo);
       }
       
    }
}
