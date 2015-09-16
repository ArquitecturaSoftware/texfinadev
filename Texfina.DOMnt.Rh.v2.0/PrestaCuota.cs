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
   /// Data Object para Mantenimiento a la Tabla: Prestamo-Cuota (RH_PrestaCuota)
   /// </summary>
   /// <remarks></remarks>
   public class PrestaCuota : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EPrestaCuota objE = (EPrestaCuota)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_PrestaCuota_mnt01", arrPrm);

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

         EPrestaCuota objE = (EPrestaCuota)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_PrestaCuota_mnt02", arrPrm);

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

         EPrestaCuota objE = (EPrestaCuota)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidPrestamo", SqlDbType.Char, 4, objE.IdPrestamo));
            arrPrm.Add(DataHelper.CreateParameter("@pnuCuota", SqlDbType.SmallInt, objE.NuCuota));

            int intRes = this.ExecuteNonQuery("RH_PrestaCuota_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EPrestaCuota value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pidPrestamo", SqlDbType.Char, 4, value.IdPrestamo));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCuota", SqlDbType.SmallInt, value.NuCuota));
         arrPrm.Add(DataHelper.CreateParameter("@pmtCuota", SqlDbType.Decimal, value.MtCuota));
         arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
         arrPrm.Add(DataHelper.CreateParameter("@pidPeriProc", SqlDbType.Char, 4, value.IdPeriProc));
         arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
         arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
         arrPrm.Add(DataHelper.CreateParameter("@pfeCancela", SqlDbType.DateTime, (value.FeCancela.HasValue ? (object)value.FeCancela : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCance", SqlDbType.Char, 3, value.IdTipoCance));
         arrPrm.Add(DataHelper.CreateParameter("@pstCuota", SqlDbType.Char, 3, value.StCuota));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

      /// <summary>
      /// Revierte las cuotas cobradas para reprocesarlas
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public int RevierteCuotasCobradas(IEntityBase value)
      {

         EPrestaCuota objE = (EPrestaCuota)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriProc", SqlDbType.Char, 4, objE.IdPeriProc));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
             
            int intRes = this.ExecuteNonQuery("RH_PrestaCuota_mnt10", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }


      /// <summary>
      /// Revierte las cuotas cobradas por Liquidacion para reprocesarlas
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public int RevierteCuotasCobradasLiquidacion(IEntityBase value)
      {

          EPrestaCuota objE = (EPrestaCuota)value;

          try
          {

              ArrayList arrPrm = new ArrayList();

              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pidPeriProc", SqlDbType.Char, 4, objE.IdPeriProc));
              arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
              arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
              arrPrm.Add(DataHelper.CreateParameter("@pidLiquidacion", SqlDbType.Char,4, objE.IdLiquidacion));


              int intRes = this.ExecuteNonQuery("RH_PrestaCuota_mnt11", arrPrm);

              return intRes;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }

      }


      /// <summary>
      /// Cobra las cuotas que son descontadas por planilla
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public int CobrarCuotasXPlanilla(IEntityBase value)
      {

         EPrestaCuota objE = (EPrestaCuota)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriProc", SqlDbType.Char, 4, objE.IdPeriProc));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));

            int intRes = this.ExecuteNonQuery("RH_PrestaCuota_ope01", arrPrm);

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
