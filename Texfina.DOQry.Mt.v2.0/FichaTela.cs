using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Mt;

namespace Texfina.DOQry.Mt
{
    /// <summary>
    /// Data Object para Consultas a la Tabla: MT_FichaTela_Qry01 (MT_FichaTela)
    /// </summary>
    /// <remarks></remarks>
    public class FichaTela : DataObjectBase, IDOQuery
    {

        #region IDOQuery Members

       public DataTable GetByCriteria(IEntityBase value)
       {

          EFichaTelaBandeja objE = (EFichaTelaBandeja)value;

          try
          {

             ArrayList arrPrm = new ArrayList();

             arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
             arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
             arrPrm.Add(DataHelper.CreateParameter("@pidProducto", SqlDbType.VarChar, 12, objE.IdProducto));
             arrPrm.Add(DataHelper.CreateParameter("@pdsProducto", SqlDbType.VarChar, 50, objE.DsProducto));
             arrPrm.Add(DataHelper.CreateParameter("@pnuTF", SqlDbType.VarChar, 10, objE.NuTF));
             arrPrm.Add(DataHelper.CreateParameter("@pnuMaquina", SqlDbType.VarChar, 5, objE.NuMaquina));
             arrPrm.Add(DataHelper.CreateParameter("@pfeFinA", SqlDbType.DateTime, objE.FeFinA));
             arrPrm.Add(DataHelper.CreateParameter("@pfeFinB", SqlDbType.DateTime, objE.FeFinB));

             DataTable dt = this.ExecuteDatatable("MT_FichaTela_qry01", arrPrm);

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

           EFichaTelaBandeja objE = (EFichaTelaBandeja)value;

           try
           {

               ArrayList arrPrm = BuildParamInterface(objE);

               DataTable dt = this.ExecuteDatatable("RH_PerContrato_qry02", arrPrm);

               objE = null;

               foreach (DataRow dr in dt.Rows)
                   objE = DataHelper.CopyDataRowToEntity<EFichaTelaBandeja>(dr, typeof(EFichaTelaBandeja));

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

           EFichaTelaBandeja objE = (EFichaTelaBandeja)value;

           try
           {

               ArrayList arrPrm = BuildParamInterface(objE);

               DataTable dt = this.ExecuteDatatable("RH_PerContrato_qry03", arrPrm);

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

           EFichaTelaBandeja objE = (EFichaTelaBandeja)value;

           try
           {

               ArrayList arrPrm = BuildParamInterface(objE);

               DataTable dt = this.ExecuteDatatable("RH_PerContrato_qry04", arrPrm);

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

           EFichaTelaBandeja objE = (EFichaTelaBandeja)value;

           try
           {

               ArrayList arrPrm = BuildParamInterface(objE);
               int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

               SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

               DataTable dt = this.ExecuteDatatable("RH_PerContrato_qry05", arrPrm);

               return objPrm[intIdx].Value.ToString() == "1" ? true : false;

           }
           catch (Exception ex)
           {

               ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
               throw objEx;

           }
       }

       private ArrayList BuildParamInterface(EFichaTelaBandeja value)
       {

           ArrayList arrPrm = new ArrayList();

           //arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
           //arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
           //arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));

           return arrPrm;

       }

        #endregion



    }
}
