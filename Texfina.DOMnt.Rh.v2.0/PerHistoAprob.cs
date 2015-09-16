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
   /// Data Object para Mantenimiento a la Tabla: RH_PerHistoAprob (RH_PerHistoAprob)
   /// </summary>
   /// <remarks></remarks>
   public class PerHistoAprob : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EPerHistoAprob objE = (EPerHistoAprob)value; 
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_PerHistoAprob_mnt01", arrPrm);
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

         EPerHistoAprob objE = (EPerHistoAprob)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_PerHistoAprob_mnt02", arrPrm);

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

         EPerHistoAprob objE = (EPerHistoAprob)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));

            int intRes = this.ExecuteNonQuery("RH_PerHistoAprob_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EPerHistoAprob value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));
         arrPrm.Add(DataHelper.CreateParameter("@pidEstado", SqlDbType.Char, 3, value.IdEstado));
         arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char, 5, value.IdUser));
         arrPrm.Add(DataHelper.CreateParameter("@pfeAccion", SqlDbType.DateTime, value.FeAccion));
         arrPrm.Add(DataHelper.CreateParameter("@pdsObservacion", SqlDbType.VarChar, 250, value.DsObservacion));

         return arrPrm;

      }

      #endregion

   }
}
