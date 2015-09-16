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
   /// Data Object para Mantenimiento a la Tabla: RH_ProcPlaRes (RH_ProcPlaRes)
   /// </summary>
   /// <remarks></remarks>
   public class ProcPlaRes : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EProcPlaRes objE = (EProcPlaRes)value;

         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_ProcPlaRes_mnt01", arrPrm);

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

         EProcPlaRes objE = (EProcPlaRes)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_ProcPlaRes_mnt02", arrPrm);

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

         EProcPlaRes objE = (EProcPlaRes)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));

            int intRes = this.ExecuteNonQuery("RH_ProcPlaRes_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EProcPlaRes value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
         arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
         arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, DataHelper.IfNullString(value.IdMes)));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoTrab", SqlDbType.Char, 3, value.IdTipoTrab));
         arrPrm.Add(DataHelper.CreateParameter("@pidRegLaboral", SqlDbType.Char, 3, value.IdRegLaboral));
         arrPrm.Add(DataHelper.CreateParameter("@pidOcupa", SqlDbType.Char, 6, value.IdOcupa));
         arrPrm.Add(DataHelper.CreateParameter("@pidRegPensi", SqlDbType.Char, 3, value.IdRegPensi));
         arrPrm.Add(DataHelper.CreateParameter("@pfeInscRegPen", SqlDbType.DateTime, (value.FeInscRegPen.HasValue ? (object)value.FeInscRegPen : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCuspp", SqlDbType.Char, 15, value.NuCuspp));
         arrPrm.Add(DataHelper.CreateParameter("@pidSctrSalud", SqlDbType.Char, 3, value.IdSctrSalud));
         arrPrm.Add(DataHelper.CreateParameter("@pidSctrPens", SqlDbType.Char, 3, value.IdSctrPens));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCont", SqlDbType.Char, 3, value.IdTipoCont));
         arrPrm.Add(DataHelper.CreateParameter("@pidSegMedi", SqlDbType.Char, 3, value.IdSegMedi));
         arrPrm.Add(DataHelper.CreateParameter("@pidEmpEps", SqlDbType.Char, 7, value.IdEmpEps));
         arrPrm.Add(DataHelper.CreateParameter("@pidSituEmplEps", SqlDbType.Char, 3, value.IdSituEmplEps));
         arrPrm.Add(DataHelper.CreateParameter("@pidSitEsptrab", SqlDbType.Char, 3, value.IdSitEsptrab));
         arrPrm.Add(DataHelper.CreateParameter("@pfeIngPla", SqlDbType.DateTime, (value.FeIngPla.HasValue ? (object)value.FeIngPla : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pfeCese", SqlDbType.DateTime, (value.FeCese.HasValue ? (object)value.FeCese : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pidBcoAbono", SqlDbType.Char, 3, value.IdBcoAbono));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCtaAbo", SqlDbType.Char, 3, value.IdTipoCtaAbo));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCtaAbono", SqlDbType.VarChar, 30, value.NuCtaAbono));
         arrPrm.Add(DataHelper.CreateParameter("@pidBcoCts", SqlDbType.Char, 3, value.IdBcoCts));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCtaCts", SqlDbType.VarChar, 30, value.NuCtaCts));
         arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 3, value.IdCCosto));
         arrPrm.Add(DataHelper.CreateParameter("@pmtRemu", SqlDbType.Decimal, value.MtRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pmtTotRemuMn", SqlDbType.Decimal, value.MtTotRemuMn));
         arrPrm.Add(DataHelper.CreateParameter("@pmtTotDescMn", SqlDbType.Decimal, value.MtTotDescMn));
         arrPrm.Add(DataHelper.CreateParameter("@pmtTotAportMn", SqlDbType.Decimal, value.MtTotAportMn));
         arrPrm.Add(DataHelper.CreateParameter("@pmtRedAntMn", SqlDbType.Decimal, value.MtRedAntMn));
         arrPrm.Add(DataHelper.CreateParameter("@pmtRedActMn", SqlDbType.Decimal, value.MtRedActMn));
         arrPrm.Add(DataHelper.CreateParameter("@pmtNetoMn", SqlDbType.Decimal, value.MtNetoMn));
         arrPrm.Add(DataHelper.CreateParameter("@pmtTotRemuMe", SqlDbType.Decimal, value.MtTotRemuMe));
         arrPrm.Add(DataHelper.CreateParameter("@pmtTotDescMe", SqlDbType.Decimal, value.MtTotDescMe));
         arrPrm.Add(DataHelper.CreateParameter("@pmtTotAportMe", SqlDbType.Decimal, value.MtTotAportMe));
         arrPrm.Add(DataHelper.CreateParameter("@pmtRedAntMe", SqlDbType.Decimal, value.MtRedAntMe));
         arrPrm.Add(DataHelper.CreateParameter("@pmtRedActMe", SqlDbType.Decimal, value.MtRedActMe));
         arrPrm.Add(DataHelper.CreateParameter("@pmtNetoMe", SqlDbType.Decimal, value.MtNetoMe));

         return arrPrm;

      }

      #endregion

      /// <summary>
      /// Elimina los datos del Calculo Actual
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public int EliminaDatosProcActual(IEntityBase value)
      {

         EProcPlaRes objE = (EProcPlaRes)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char,7, objE.IdPersonal));

            int intRes = this.ExecuteNonQuery("RH_ProcPlaRes_mnt10", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      /// <summary>
      /// Genera los Resultados para Calculo Actual
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public int ProcResultadosCalcActual(IEntityBase value)
      {

         EProcPlaRes objE = (EProcPlaRes)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char,7, objE.IdPersonal));

            int intRes = this.ExecuteNonQuery("RH_ProcPlaRes_ope01", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

   }
}