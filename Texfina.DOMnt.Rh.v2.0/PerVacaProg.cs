using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Rh
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: RH_PerVacaProg (RH_PerVacaProg)
   /// </summary>
   /// <remarks></remarks>
   public class PerVacaProg : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EPerVacaProg objE = (EPerVacaProg)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_PerVacaProg_mnt01", arrPrm);

            return new object[] { objE.NuSecuen };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EPerVacaProg objE = (EPerVacaProg)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_PerVacaProg_mnt02", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Delete(IEntityBase value)
      {

         EPerVacaProg objE = (EPerVacaProg)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriVac", SqlDbType.Char, 4, objE.IdPeriVac));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

            int intRes = this.ExecuteNonQuery("RH_PerVacaProg_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EPerVacaProg value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pidPeriVac", SqlDbType.Char, 4, value.IdPeriVac));
         arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));
         arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
         arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
         arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, value.IdConRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDiasVaca", SqlDbType.SmallInt, value.NuDiasVaca));
         arrPrm.Add(DataHelper.CreateParameter("@pmtVaca", SqlDbType.Decimal, value.MtVaca));
         arrPrm.Add(DataHelper.CreateParameter("@pidPeriAnualIni", SqlDbType.Char, 4, value.IdPeriAnualIni));
         arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualIni", SqlDbType.SmallInt, value.NuProcAnualIni));
         arrPrm.Add(DataHelper.CreateParameter("@pfeVacaIni", SqlDbType.DateTime, (value.FeVacaIni.HasValue ? (object)value.FeVacaIni : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pidPeriAnualFin", SqlDbType.Char, 4, value.IdPeriAnualFin));
         arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, value.NuProcAnualFin));
         arrPrm.Add(DataHelper.CreateParameter("@pfeVacaFin", SqlDbType.DateTime, (value.FeVacaFin.HasValue ? (object)value.FeVacaFin : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDiasGozado", SqlDbType.Decimal, value.NuDiasGozado));
         arrPrm.Add(DataHelper.CreateParameter("@pstVaca", SqlDbType.Char, 3, value.StVaca));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}
