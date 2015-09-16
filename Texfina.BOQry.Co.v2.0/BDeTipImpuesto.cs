using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;
namespace Texfina.BOQry.Co
{
   public class BDeTipImpuesto
    {
       public static IDataReader GetListFill_Qry01(EDTipImpuesto dti)
       {
           return  DDeTipImpuesto.Impuesto_qry01(dti);
       }

   

       public static List<Dato> ObtenerImpuesto(EDTipImpuesto dti)
       {
           return DDeTipImpuesto._Impuesto_qry01("MG_Impuesto_qry01", "mtIgv", "mtIgv", dti);
       }

    }
}
