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
   /// Data Object para Mantenimiento a la Tabla: Concepto de Remuneracion (RH_ConcepRemu)
   /// </summary>
   /// <remarks></remarks>
   public class ConcepRemu : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EConcepRemu objE = (EConcepRemu)value;

         //----------- Generacion de Codigos ------------------
         TablaCorre objDO = new TablaCorre();
         ETablaCorre objECorre = new ETablaCorre();
         objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
         objECorre.IdEmpresa = ConstDefaultValue.EMPRESA;
         objECorre.IdTabla = "RH_ConcepRemu";

         string strNewCode = objDO.GenNewCode(objECorre);
         objE.IdConRemu = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_ConcepRemu_mnt01", arrPrm);

            return new object[] { objE.IdConRemu };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EConcepRemu objE = (EConcepRemu)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_ConcepRemu_mnt02", arrPrm);

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

         EConcepRemu objE = (EConcepRemu)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, objE.IdConRemu));

            int intRes = this.ExecuteNonQuery("RH_ConcepRemu_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EConcepRemu value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, value.IdConRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pdsConRemu", SqlDbType.VarChar, 50, value.DsConRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipConcep", SqlDbType.Char, 3, value.IdTipConcep));
         arrPrm.Add(DataHelper.CreateParameter("@pidIngtrides", SqlDbType.Char, 4, value.IdIngtrides));
         arrPrm.Add(DataHelper.CreateParameter("@pstUsaFormu", SqlDbType.Char, 1, value.StUsaFormu));
         arrPrm.Add(DataHelper.CreateParameter("@pdsFormHra", SqlDbType.VarChar, 450, value.DsFormHra));
         arrPrm.Add(DataHelper.CreateParameter("@pdsFormula", SqlDbType.VarChar, 600, value.DsFormula));
         arrPrm.Add(DataHelper.CreateParameter("@pdsCondition", SqlDbType.VarChar, 250, value.DsCondition));
         arrPrm.Add(DataHelper.CreateParameter("@pstProcAdic", SqlDbType.Char, 1, value.StProcAdic));
         arrPrm.Add(DataHelper.CreateParameter("@pstCtaCte", SqlDbType.Char, 1, value.StCtaCte));
         arrPrm.Add(DataHelper.CreateParameter("@pstAfectaGrati", SqlDbType.Char, 1, value.StAfectaGrati));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoRemu", SqlDbType.Char, 3, value.IdTipoRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 10, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}