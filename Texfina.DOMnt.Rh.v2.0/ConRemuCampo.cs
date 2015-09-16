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
   /// Data Object para Mantenimiento a la Tabla: Campos Usados en el Concepto Remunerativo (RH_ConRemuCampo)
   /// </summary>
   /// <remarks></remarks>
   public class ConRemuCampo : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EConRemuCampo objE = (EConRemuCampo)value;

         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_ConRemuCampo_mnt01", arrPrm);

            return new object[] { objE.IdEmpresa };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EConRemuCampo objE = (EConRemuCampo)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_ConRemuCampo_mnt02", arrPrm);

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

         EConRemuCampo objE = (EConRemuCampo)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidConremu", SqlDbType.Char, 3, objE.IdConremu));
            arrPrm.Add(DataHelper.CreateParameter("@pidCampo", SqlDbType.VarChar, 15, objE.IdCampo));
            arrPrm.Add(DataHelper.CreateParameter("@pnuNivel", SqlDbType.SmallInt, objE.NuNivel));

            int intRes = this.ExecuteNonQuery("RH_ConRemuCampo_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EConRemuCampo value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidConremu", SqlDbType.Char, 3, value.IdConremu));
         arrPrm.Add(DataHelper.CreateParameter("@pidCampo", SqlDbType.VarChar, 15, value.IdCampo));
         arrPrm.Add(DataHelper.CreateParameter("@pnuNivel", SqlDbType.SmallInt, value.NuNivel));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipo", SqlDbType.Char, 2, value.IdTipo));

         return arrPrm;

      }

      #endregion

   }
}