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
   public class BTejeduria
    {

       public static DataSet TJ_Tejeduria_qry05(ETejeduria TJ)
       {
           return DTejeduria.TJ_tejeduria_qry05(TJ);
       }
       public static List<ETejeduria> TJ_Tejeduria_qry06(ETejeduria oTJ)
       {
           return DTejeduria.TJ_tejeduria_qry06(oTJ);
       }

       public static ETejeduria TJ_Tejeduria_qry07(ETejeduria oTJ)
       {
      
           return DTejeduria.TJ_Tejeduria_qry07(oTJ);
       }

       public static void TJ_Tejeduria_mnt02(ETejeduria tj)
       {
           DTejeduria.TJ_Tejeduria_mnt02(tj);
       }

       public static List<Dato> TJ_TejeduriaGenCod(string idEmpresa, string idProducto)
       {

           return DTejeduria.TJ_TejeduriaGenCod(idEmpresa, idProducto);
       }


       public static void TJ_Tejeduria_mnt04(ETejeduria tj)
       {
           DTejeduria.TJ_Tejeduria_mnt04(tj);
       }

       //GetFichaTejeduria_rpt01

      
        public DataTable GetFichaTejeduria_rpt01(ETejeduria tj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DTejeduria objTJ = new DTejeduria();

            DataTable dt = objTJ.GetFichaTejeduria_rpt01(tj);
            return dt;
        }

    }
}
