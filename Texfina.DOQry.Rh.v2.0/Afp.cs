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
   /// Data Object para Consultas a la Tabla: Afp (RH_Afp)
   /// </summary>
   /// <remarks></remarks>
   public class Afp : DataObjectBase, IDOQuery
   {

      #region IDOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         EAfpBandeja objE = (EAfpBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidAfp", SqlDbType.Char, 3, objE.IdAfp ));
            arrPrm.Add(DataHelper.CreateParameter("@pdsAfp", SqlDbType.VarChar, 80, objE.DsAfp));
            DataTable dt = this.ExecuteDatatable("RH_Afp_qry01", arrPrm);

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

          EAfp objE = (EAfp)value;

          try
          {

              ArrayList arrPrm = BuildParamInterface(objE);

              DataTable dt = this.ExecuteDatatable("RH_Afp_qry02", arrPrm);

              objE = null;

              foreach (DataRow dr in dt.Rows)
                  objE = DataHelper.CopyDataRowToEntity<EAfp>(dr, typeof(EAfp));

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

          EAfp objE = (EAfp)value;

          try
          {

              ArrayList arrPrm = BuildParamInterface(objE);

              DataTable dt = this.ExecuteDatatable("RH_Afp_qry03", arrPrm);

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

          EAfp objE = (EAfp)value;

          try
          {

              ArrayList arrPrm = BuildParamInterface(objE);

              DataTable dt = this.ExecuteDatatable("RH_Afp_qry04", arrPrm);

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

          EAfp objE = (EAfp)value;

          try
          {

              ArrayList arrPrm = BuildParamInterface(objE);
              int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

              SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

              DataTable dt = this.ExecuteDatatable("RH_Afp_qry05", arrPrm);

              return objPrm[intIdx].Value.ToString() == "1" ? true : false;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      private ArrayList BuildParamInterface(EAfp value)
      {

          ArrayList arrPrm = new ArrayList();

          arrPrm.Add(DataHelper.CreateParameter("@pidAfp", SqlDbType.Char, 3, value.IdAfp));

          return arrPrm;

      }

      #endregion

   }
}
