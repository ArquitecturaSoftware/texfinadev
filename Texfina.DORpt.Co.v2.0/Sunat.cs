using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DORpt.Co
{
   /// <summary>
   /// Data Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   /// <remarks></remarks>
    public class TSunat : DataObjectBase
   {
      #region Members

        public DataTable GetDataXKey(IEntityBase value)
      {

          ESunatReporte objE = (ESunatReporte)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pid_periodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pid_empresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pid_mes", SqlDbType.Char, 3, objE.IdMes));

            //DataTable dt = this.ExecuteDatatable("RH_TRegistro_Rpt" + objE.IdStore, arrPrm);
            DataTable dt = this.ExecuteDatatable("RH_Sunat_Rpt" + objE.IdStore, arrPrm);

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
