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
   public class Personal : DataObjectBase
   {
      #region Members

      public DataTable GetPerContrato(IEntityBase value)
      {

         EPerContrato objE = (EPerContrato)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

            DataTable dt = this.ExecuteDatatable("RH_PerContrato_rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetPersonal(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
        
            DataTable dt = this.ExecuteDatatable("RH_Personal_rpt01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

        }

      public DataTable GetContratosMasivamente(IEntityBase value)
      {

         EPerContratoBandeja objE = (EPerContratoBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioA", SqlDbType.DateTime, objE.FeInicioA));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioB", SqlDbType.DateTime, objE.FeInicioB));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
           

            DataTable dt = this.ExecuteDatatable("RH_PerContrato_rpt02", arrPrm);

            return dt;
         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }
      public DataTable GetByCriteriaImpreContra(IEntityBase value)
      {

         EPerContratoBandeja objE = (EPerContratoBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioA", SqlDbType.DateTime, objE.FeInicioA));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioB", SqlDbType.DateTime, objE.FeInicioB));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_PerContrato_rpt10", arrPrm);

            return dt;
         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }


      public DataTable GetByCriteriaExpConMinTrab(IEntityBase value)
      {

         EPerContratoBandeja objE = (EPerContratoBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioA", SqlDbType.DateTime, objE.FeInicioA));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioB", SqlDbType.DateTime, objE.FeInicioB));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_PerContrato_qry10", arrPrm);

            return dt;
         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }


      public DataTable GetByCriteriaExpConMinCon(IEntityBase value)
      {

         EPerContratoBandeja objE = (EPerContratoBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioA", SqlDbType.DateTime, objE.FeInicioA));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioB", SqlDbType.DateTime, objE.FeInicioB));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
            arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));

            DataTable dt = this.ExecuteDatatable("RH_PerContrato_qry11", arrPrm);

            return dt;
         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }
      public DataTable GetByCriteriaPerRemu(IEntityBase value)
      {

          EPerRemuBandeja objE = (EPerRemuBandeja)value;

          try
          {
              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
              arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
              arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
              arrPrm.Add(DataHelper.CreateParameter("@pidTipoTrab", SqlDbType.Char, 3, objE.IdTipoTrab));
              arrPrm.Add(DataHelper.CreateParameter("@pfeIngplaA", SqlDbType.DateTime, objE.feIngplaA));
              arrPrm.Add(DataHelper.CreateParameter("@pfeIngplaB", SqlDbType.DateTime, objE.feIngplaB));
              arrPrm.Add(DataHelper.CreateParameter("@pstContrato", SqlDbType.Char, 1, objE.StContrato));



              DataTable dt = this.ExecuteDatatable("RH_PerRemu_rpt01", arrPrm);

              return dt;
          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      public DataTable GetByCriteriaPrestamo(IEntityBase value)
      {

          EPrestamo objE = (EPrestamo)value;

          try
          {
              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pidPrestamo", SqlDbType.Char, 4, objE.IdPrestamo));

              DataTable dt = this.ExecuteDatatable("RH_Prestamo_rpt01", arrPrm);

              return dt;
          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      public DataTable GetByCriteriaPrestaCuota(IEntityBase value)
      {

          EPrestamo objE = (EPrestamo)value;

          try
          {
              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pidPrestamo", SqlDbType.Char, 4, objE.IdPrestamo));

              DataTable dt = this.ExecuteDatatable("RH_PrestaCuota_rpt01", arrPrm);

              return dt;
          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      public DataTable GetByCriteriaProcPlaReg(IEntityBase value)
      {

          EProcPlaReg objE = (EProcPlaReg)value;

          try
          {
              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, objE.IdConRemu));
              arrPrm.Add(DataHelper.CreateParameter("@pidTipRegula", SqlDbType.Char, 3, objE.IdTipRegula));

              DataTable dt = this.ExecuteDatatable("RH_ProcPlaReg_rpt01", arrPrm);

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
