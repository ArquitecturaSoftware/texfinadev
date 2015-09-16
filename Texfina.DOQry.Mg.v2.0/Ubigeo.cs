using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.DOQry.Mg
{
   /// <summary>
   /// Data Object para Consultas a la Tabla: Ubigeo (MG_Ubigeo)
   /// </summary>
   /// <remarks></remarks>
   public class Ubigeo : DataObjectBase, IDOQuery
   {

      #region IDOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPais", SqlDbType.Char, 4, objE.IdPais));
            arrPrm.Add(DataHelper.CreateParameter("@pidDepa", SqlDbType.Char, 2, objE.IdDepa));
            arrPrm.Add(DataHelper.CreateParameter("@pidProv", SqlDbType.Char, 2, objE.IdProv));
            arrPrm.Add(DataHelper.CreateParameter("@pidDist", SqlDbType.Char, 2, objE.IdDist));

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry01", arrPrm);

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

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry02", arrPrm);

            objE = null;

            foreach (DataRow dr in dt.Rows)
               objE = DataHelper.CopyDataRowToEntity<EUbigeo>(dr, typeof(EUbigeo));

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

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry03", arrPrm);

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

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry04", arrPrm);

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

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);
            int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

            SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry05", arrPrm);

            return objPrm[intIdx].Value.ToString() == "1" ? true : false;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      private ArrayList BuildParamInterface(EUbigeo value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidPais", SqlDbType.Char, 4, value.IdPais));
         arrPrm.Add(DataHelper.CreateParameter("@pidDepa", SqlDbType.Char, 2, value.IdDepa));
         arrPrm.Add(DataHelper.CreateParameter("@pidProv", SqlDbType.Char, 2, value.IdProv));
         arrPrm.Add(DataHelper.CreateParameter("@pidDist", SqlDbType.Char, 2, value.IdDist));

         return arrPrm;

      }

      #endregion


      public DataTable GetDsUbigeoByCriteria(IEntityBase value)
      {

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pdsNombre", SqlDbType.VarChar, 40, objE.DsNombre));

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry10", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetDsUbigeoByKey(IEntityBase value)
      {

         EUbigeo objE = (EUbigeo)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPais", SqlDbType.Char, 4, objE.IdPais));
            arrPrm.Add(DataHelper.CreateParameter("@pidDepa", SqlDbType.Char, 2, objE.IdDepa));
            arrPrm.Add(DataHelper.CreateParameter("@pidProv", SqlDbType.Char, 2, objE.IdProv));
            arrPrm.Add(DataHelper.CreateParameter("@pidDist", SqlDbType.Char, 2, objE.IdDist));

            DataTable dt = this.ExecuteDatatable("MG_Ubigeo_qry11", arrPrm);

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
