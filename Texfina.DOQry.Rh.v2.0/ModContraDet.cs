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
   /// Data Object para Consultas a la Tabla: RH_ModalidadContraDet (RH_ModalidadContraDet)
   /// </summary>
   /// <remarks></remarks>
   public class ModContraDet : DataObjectBase, IDOQuery
   {

      #region IDOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         EModContraDet objE = (EModContraDet)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidModalidad", SqlDbType.Char, 3, objE.IdModalidad));
            arrPrm.Add(DataHelper.CreateParameter("@pidSubModalidad", SqlDbType.Char, 3, objE.IdSubModalidad));

            DataTable dt = this.ExecuteDatatable("RH_ModContraDet_qry01", arrPrm);

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

         EModContraDet objE = (EModContraDet)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_ModContraDet_qry02", arrPrm);

            objE = null;

            foreach (DataRow dr in dt.Rows)
               objE = DataHelper.CopyDataRowToEntity<EModContraDet>(dr, typeof(EModContraDet));

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

         EModContraDet objE = (EModContraDet)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_ModContraDet_qry03", arrPrm);

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

         EModContraDet objE = (EModContraDet)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_ModContraDet_qry04", arrPrm);

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

         EModContraDet objE = (EModContraDet)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);
            int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

            SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

            DataTable dt = this.ExecuteDatatable("RH_ModContraDet_qry05", arrPrm);

            return objPrm[intIdx].Value.ToString() == "1" ? true : false;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      private ArrayList BuildParamInterface(EModContraDet value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidModalidad", SqlDbType.Char, 3, value.IdModalidad));
         arrPrm.Add(DataHelper.CreateParameter("@pidSubModalidad", SqlDbType.Char, 3, value.IdSubModalidad));

         return arrPrm;

      }

      #endregion

   }
}
