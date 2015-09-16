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
   /// Data Object para Mantenimiento a la Tabla: RH_DiaDescanso (RH_DiaDescanso)
   /// </summary>
   /// <remarks></remarks>
   public class DiaDescanso : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EDiaDescanso objE = (EDiaDescanso)value;

         ////----------- Generacion de Codigos ------------------
         //TablaCorre objDO = new TablaCorre();
         //ETablaCorre objECorre = new ETablaCorre();

         //objECorre.IdPeriodo = objE.IdPeriodo;
         //objECorre.IdEmpresa = objE.IdEmpresa;
         //objECorre.IdTabla = "RH_DiaDescanso";

         //string strNewCode = objDO.GenNewCode(objECorre);
         //objE.IdPeriodo = strNewCode;

         ////----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_DiaDescanso_mnt01", arrPrm);

            return new object[] { objE.IdPeriodo };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_DiaDescanso_mnt02", arrPrm);

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

         EDiaDescanso objE = (EDiaDescanso)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pfeDiaDescanso", SqlDbType.DateTime, objE.FeDiaDescanso));

            int intRes = this.ExecuteNonQuery("RH_DiaDescanso_mnt03", arrPrm);

            return intRes;

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
         arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, value.IdMes));

         return arrPrm;

      }

      #endregion

   }
}
