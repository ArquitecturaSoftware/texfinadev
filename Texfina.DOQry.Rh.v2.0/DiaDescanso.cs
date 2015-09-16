﻿using System;
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
   /// Data Object para Consultas a la Tabla: RH_DiaDescanso (RH_DiaDescanso)
   /// </summary>
   /// <remarks></remarks>
   public class DiaDescanso : DataObjectBase, IDOQuery
   {

      #region IDOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pfeDiaDescanso", SqlDbType.DateTime, objE.FeDiaDescanso));

            DataTable dt = this.ExecuteDatatable("RH_DiaDescanso_qry01", arrPrm);

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

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_DiaDescanso_qry02", arrPrm);

            objE = null;

            foreach (DataRow dr in dt.Rows)
               objE = DataHelper.CopyDataRowToEntity<EDiaDescanso>(dr, typeof(EDiaDescanso));

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

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_DiaDescanso_qry03", arrPrm);

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

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_DiaDescanso_qry04", arrPrm);

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

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);
            int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

            SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

            DataTable dt = this.ExecuteDatatable("RH_DiaDescanso_qry05", arrPrm);

            return objPrm[intIdx].Value.ToString() == "1" ? true : false;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      private ArrayList BuildParamInterface(EDiaDescanso value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
         arrPrm.Add(DataHelper.CreateParameter("@pfeDiaDescanso", SqlDbType.DateTime, value.FeDiaDescanso));

         return arrPrm;

      }

      #endregion

   }
}
