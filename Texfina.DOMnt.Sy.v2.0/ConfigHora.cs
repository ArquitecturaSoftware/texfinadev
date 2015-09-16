using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Sy
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: SY_ConfigHora (SY_ConfigHora)
   /// </summary>
   /// <remarks></remarks>
   public class ConfigHora : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EConfigHora objE = (EConfigHora)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("SY_ConfigHora_mnt01", arrPrm);

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

         EConfigHora objE = (EConfigHora)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("SY_ConfigHora_mnt02", arrPrm);

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

         EConfigHora objE = (EConfigHora)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidHoraExcel", SqlDbType.SmallInt, objE.IdHoraExcel));

            int intRes = this.ExecuteNonQuery("SY_ConfigHora_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EConfigHora value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidHoraExcel", SqlDbType.SmallInt, value.IdHoraExcel));
         arrPrm.Add(DataHelper.CreateParameter("@pdsHoraExcel", SqlDbType.VarChar, 50, value.DsHoraExcel));
         arrPrm.Add(DataHelper.CreateParameter("@pidHora", SqlDbType.Char, 3, value.IdHora));
         arrPrm.Add(DataHelper.CreateParameter("@pstIdPersonal", SqlDbType.Char, 1, value.StIdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}
