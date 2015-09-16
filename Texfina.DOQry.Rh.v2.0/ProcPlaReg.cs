using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;

namespace Texfina.DOQry.Rh
{
   /// <summary>
   /// Data Object para Consultas a la Tabla: Proceso Planilla Regimen (RH_ProcPlaReg)
   /// </summary>
   /// <remarks></remarks>
   public class ProcPlaReg : DataObjectBase, IDOQuery
   {

      #region IDOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         EProcPlaReg objE = (EProcPlaReg)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, objE.IdConRemu));

            DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_qry01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public IEntityBase GetByKey(IEntityBase value)
      {

         EProcPlaReg objE = (EProcPlaReg)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_qry02", arrPrm);

            objE = null;

            foreach (DataRow dr in dt.Rows)
               objE = DataHelper.CopyDataRowToEntity<EProcPlaReg>(dr, typeof(EProcPlaReg));

            return objE;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetByParentKey(IEntityBase value)
      {

         EProcPlaReg objE = (EProcPlaReg)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_qry03", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetList(IEntityBase value)
      {

         EProcPlaReg objE = (EProcPlaReg)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_qry04", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public bool Exists(IEntityBase value)
      {

         EProcPlaReg objE = (EProcPlaReg)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);
            int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

            SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

            DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_qry05", arrPrm);

            return objPrm[intIdx].Value.ToString() == "1" ? true : false;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      private ArrayList BuildParamInterface(EProcPlaReg value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
         arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
         arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, value.IdConRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipRegula", SqlDbType.Char, 3, value.IdTipRegula));

          return arrPrm;

      }

      #endregion

      /// <summary>
      /// Recupera los Conceptos a Regularizar(solo los que tienen formula).
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public DataTable GetConceptoRegula(IEntityBase value)
      {

         EProcPlaReg objE = (EProcPlaReg)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidTipRegula", SqlDbType.Char, 3, objE.IdTipRegula));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));

            DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_qry10", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

   }
}
