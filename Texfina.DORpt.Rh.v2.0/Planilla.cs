using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;

namespace Texfina.DORpt.Rh
{
   /// <summary>
   /// Data Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   /// <remarks></remarks>
   public class Planilla : DataObjectBase
   {
      #region Members

      public DataTable GetBoletaTrabajador(IEntityBase value)
      {

         EProcPlaRes objE = (EProcPlaRes)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char,3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt , objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char,7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_PlanBolPago_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetBoletaTrabajadorDet(IEntityBase value)
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
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_PlanBolPago_Rpt02", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetBoletaTrabajadorPrint(IEntityBase value)
      {

         EBoletaPago objE = (EBoletaPago)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualIni", SqlDbType.SmallInt, objE.NuProcAnualIni));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, objE.NuProcAnualFin));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonalIni", SqlDbType.Char, 7, objE.IdPersonalIni));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonalFin", SqlDbType.Char, 7, objE.IdPersonalFin));

            DataTable dt = this.ExecuteDatatable("RH_PlanBolPago_Rpt03", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetResumenPlanilla(IEntityBase value)
      {

         EPlaniResu objE = (EPlaniResu)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, objE.NuProcAnualFin));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_Planresumen_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetDistribuciónBillete(IEntityBase value)
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
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_DisHorasExt_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetConsoPlanilla(IEntityBase value)
      {

         EPlanillaBandeja objE = (EPlanillaBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, objE.NuProcAnualFin));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidTipGasto", SqlDbType.Char, 3, objE.IdTipGasto));
             
            DataTable dt = this.ExecuteDatatable("RH_ConsoPlanilla_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetConsoPlanillaVaca(IEntityBase value)
      {

          EPlanillaBandeja objE = (EPlanillaBandeja)value;

          try
          {

              ArrayList arrPrm = new ArrayList();

              arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, objE.NuProcAnualFin));
              arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
              arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
              arrPrm.Add(DataHelper.CreateParameter("@pidTipGasto", SqlDbType.Char, 3, objE.IdTipGasto));

              DataTable dt = this.ExecuteDatatable("RH_ConsoPlanilla_Rpt02", arrPrm);

              return dt;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }
      
      public DataTable GetProcPlaHora(IEntityBase value)
      {

          EProcPlaHora objE = (EProcPlaHora)value;

          try
          {

              ArrayList arrPrm = new ArrayList();

              arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4,objE.IdPeriodo));
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));

              DataTable dt = this.ExecuteDatatable("RH_ProcPlaHora_rpt01", arrPrm);

              return dt;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      ///Mi Reporte Resumen de Banco BIF
      public DataTable GetBancoResu(IEntityBase value)
      {

          EBancoResu objE = (EBancoResu)value;

          try
          {

              ArrayList arrPrm = new ArrayList();

              arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, objE.NuProcAnualFin));

              DataTable dt = this.ExecuteDatatable("RH_ResumenBanco", arrPrm);

              return dt;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      ///Mi Reporte de Certificado de 5ta
      public DataTable GetCertificadoTrabajador(IEntityBase value)
      {

         ECertificado5ta objE = (ECertificado5ta)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));


            DataTable dt = this.ExecuteDatatable("RH_Certificado5ta", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      //Reporte de Dias de Vacaciones
      public DataTable GetVacaDiasPrint(IEntityBase value)
      {

         EVacaDias objE = (EVacaDias)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));


            DataTable dt = this.ExecuteDatatable("RH_PerVacaDias_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      //Reporte de Contratos Vencidos
      public DataTable GetVencimientoContrato(IEntityBase value)
      {

         EContratoVenci objE = (EContratoVenci)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 15, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 15, objE.IdMes));

            DataTable dt = this.ExecuteDatatable("RH_PerContrato_rpt03", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetResumenConcepto(IEntityBase value)
      {

         EPlaniConRemu objE = (EPlaniConRemu)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnualFin", SqlDbType.SmallInt, objE.NuProcAnualFin));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 15, objE.IdConRemu));

            DataTable dt = this.ExecuteDatatable("RH_PlanConRemu_Rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetConstanciaCTS(IEntityBase value)
      {

         EConstCTS objE = (EConstCTS)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidCTS", SqlDbType.Char, 3, objE.IdCTS));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));


            DataTable dt = this.ExecuteDatatable("RH_REPORTE_CTS", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      #endregion
   }
}
