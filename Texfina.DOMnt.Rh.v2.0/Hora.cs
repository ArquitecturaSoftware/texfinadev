using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Core.Common;
using Texfina.Entity.Rh;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Rh
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: Hora (RH_Hora)
   /// </summary>
   /// <remarks></remarks>
   public class Hora : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EHora objE = (EHora)value;

         //----------- Generacion de Codigos ------------------
         TablaCorre objDO = new TablaCorre();
         ETablaCorre objECorre = new ETablaCorre();

         objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
         objECorre.IdEmpresa = ConstDefaultValue.EMPRESA;
         objECorre.IdTabla = "RH_Hora";

         string strNewCode = objDO.GenNewCode(objECorre);
         objE.IdHora = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_Hora_mnt01", arrPrm);

            return new object[] { objE.IdHora};

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EHora objE = (EHora)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_Hora_mnt02", arrPrm);

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

         EHora objE = (EHora)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidHora", SqlDbType.Char, 3, objE.IdHora));

            int intRes = this.ExecuteNonQuery("RH_Hora_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EHora value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidHora", SqlDbType.Char, 3, value.IdHora));
         arrPrm.Add(DataHelper.CreateParameter("@pdsHora", SqlDbType.VarChar, 50, value.DsHora));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAbrev", SqlDbType.VarChar, 25, value.DsAbrev));
         arrPrm.Add(DataHelper.CreateParameter("@pidVar", SqlDbType.VarChar, 15, value.IdVar));
         arrPrm.Add(DataHelper.CreateParameter("@pnuValHora", SqlDbType.Decimal, value.NuValHora));
         arrPrm.Add(DataHelper.CreateParameter("@pstEventual", SqlDbType.Char, 1, value.StEventual));
         arrPrm.Add(DataHelper.CreateParameter("@pnuOrden", SqlDbType.SmallInt, value.NuOrden));
         arrPrm.Add(DataHelper.CreateParameter("@pstImportar", SqlDbType.Char, 1, value.StImportar));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}
