using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;

namespace Texfina.DORpt.Rh
{
   /// <summary>
   /// Data Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   /// <remarks></remarks>
    public class AFPnet : DataObjectBase
   {
      #region Members

        public DataTable GetDataAFPnet(IEntityBase value)
      {

          EAFPnet objE = (EAFPnet)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, objE.IdMes));

            DataTable dt = this.ExecuteDatatable("RH_PlanresumenAfp_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      #endregion
   }
}
