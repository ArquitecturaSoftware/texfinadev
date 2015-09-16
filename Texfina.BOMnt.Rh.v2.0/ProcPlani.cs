using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using System.ServiceModel;
using Texfina.Core.Data;
using Texfina.Entity.Rh;
using Texfina.Core.Common;
using Texfina.Common.Mg;
using RHDOQry = Texfina.DOQry.Rh;
using RHDOMnt = Texfina.DOMnt.Rh;

namespace Texfina.BOMnt.Rh
{
   /// <summary>
   /// Interface para Consultas personalizadas
   /// </summary>
   [ServiceContract()]
   public interface IProcPlani
   {
      /// <summary>
      /// Genera el Calculo de la Planilla
      /// </summary>
      /// <param name="value">Entidad base</param>
      [OperationContract()]
      [NetDataContract()]
      void ProcesarCalculo(IEntityBase value);

      /// <summary>
      /// Actualiza el estado CERRADO al proceso anterior.
      /// </summary>
      /// <param name="value">Entidad base</param>
      [OperationContract()]
      [NetDataContract()]
      void ActualizarEstado(EProcPlani value);

   }

   /// <summary>
   /// Business Object para Mantenimiento a la Tabla: Proceso de Planilla (RH_ProcPlani)
   /// </summary>
   public class ProcPlani : BusinessObjectBase, IBOUpdate, IProcPlani
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EProcPlani objE = (EProcPlani)value;

         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {
               if (objE.NuProcAnual != 1)
               {
                  objE.NuProcAnual = objE.NuProcAnual - 1;
                  ActualizarEstado(objE);
                  objE.NuProcAnual = objE.NuProcAnual + 1;
               }

               objRet = this.UpdateMaster(objE);
               tx.Complete();
            }

            if (objRet == null)
               return null;

            return new String[] { objRet[0].ToString() };

         }
         catch (Exception ex)
         {
            throw ex;
         }
      }

      public int DeleteData(IEntityBase value)
      {

         EProcPlani objE = (EProcPlani)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               //this.DeleteDetail(objE.EProcPlani, false);
               this.DeleteMaster(objE);

               tx.Complete();

            }

            return 1;

         }
         catch
         {
            return 0;
         }

      }

      #endregion

      private object[] UpdateMaster(EProcPlani entity)
      {

         IDOUpdate objDO = new RHDOMnt.ProcPlani();

         if (entity.EntityState == EntityState.Unchanged)
            return null;

         object[] objRet = null;

         switch (entity.EntityState)
         {

            case EntityState.Added:
               objRet = objDO.Insert(entity);
               break;

            case EntityState.Modified:
               if (entity.StAnulado == ConstFlagEstado.DESACTIVADO)
                  objDO.Update(entity);
               else
                  objDO.Delete(entity);
               break;

            case EntityState.Deleted:
               objDO.Delete(entity);
               break;

         }

         return objRet;
      }

      private void UpdateDetail(IList<EProcPlani> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ProcPlani();

         foreach (EProcPlani objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdPeriodo = primKey[0].ToString();
            }

            switch (objE.EntityState)
            {

               case EntityState.Added:
                  objRet = objDO.Insert(objE);
                  break;

               case EntityState.Modified:
                  if (objE.StAnulado == ConstFlagEstado.DESACTIVADO)
                     objDO.Update(objE);
                  else
                     objDO.Delete(objE);
                  break;

            }

         }

      }

      private void DeleteMaster(EProcPlani entity)
      {

         IDOUpdate objDO = new RHDOMnt.ProcPlani();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EProcPlani> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ProcPlani();
         IEnumerable<EProcPlani> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<EProcPlani>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<EProcPlani>)deleteItems;
         }
         foreach (EProcPlani objE in colSel)
            objDO.Delete(objE);

      }

      #region IProcPlani Members

      public void ProcesarCalculo(IEntityBase value)
      {

         EProcPlaniProcCalc objE = (EProcPlaniProcCalc)value;
         EPlanilla objEPla = new EPlanilla();
         EProcPlaCalc objECal = new EProcPlaCalc();
         EProcPlaReg objEReg = new EProcPlaReg();
         EPrestaCuota objECta = new EPrestaCuota();
         EProcPlaRes objERes = new EProcPlaRes();

         RHDOQry.PlanillaDet objDPla = new RHDOQry.PlanillaDet();
         RHDOMnt.ProcPlaCalc objDProc = new RHDOMnt.ProcPlaCalc();
         RHDOQry.ProcPlaReg objDReg = new RHDOQry.ProcPlaReg();
         RHDOMnt.ProcPlaReg objDRegMnt = new RHDOMnt.ProcPlaReg();
         RHDOMnt.PrestaCuota objDCta = new RHDOMnt.PrestaCuota();
         RHDOMnt.ProcPlaRes objDRes = new RHDOMnt.ProcPlaRes();

         objEPla.IdEmpresa = objE.IdEmpresa;
         objEPla.IdPlanilla = objE.IdPlanilla;

         objECal.IdPeriodo = objE.IdPeriodo;
         objECal.IdEmpresa = objE.IdEmpresa;
         objECal.IdForPago = objE.IdForPago;
         objECal.IdPlanilla = objE.IdPlanilla;
         objECal.NuProcAnual = objE.NuProcAnual;
         objECal.StOrigen = ConstTipoRegularizacion.NINGUNO;
         objECal.IdMes = objE.IdMes;
         objECal.IdPersonal = objE.IdPersonal;

         objEReg.IdPeriodo = objE.IdPeriodo;
         objEReg.IdEmpresa = objE.IdEmpresa;
         objEReg.IdForPago = objE.IdForPago;
         objEReg.IdPlanilla = objE.IdPlanilla;
         objEReg.NuProcAnual = objE.NuProcAnual;
         objEReg.IdTipRegula = ConstTipoRegularizacion.REGULARIZACION;
         objEReg.IdPersonal = objE.IdPersonal;

         objECta.IdPeriProc = objE.IdPeriodo;
         objECta.IdEmpresa = objE.IdEmpresa;
         objECta.IdForPago = objE.IdForPago;
         objECta.IdPlanilla = objE.IdPlanilla;
         objECta.NuProcAnual = objE.NuProcAnual;
         objECta.IdPersonal = objE.IdPersonal;

         objERes.IdPeriodo = objE.IdPeriodo;
         objERes.IdEmpresa = objE.IdEmpresa;
         objERes.IdForPago = objE.IdForPago;
         objERes.IdPlanilla = objE.IdPlanilla;
         objERes.NuProcAnual = objE.NuProcAnual;
         objERes.IdPersonal = objE.IdPersonal;

         DataTable dt = objDPla.GetConceptosHabilitados(objEPla);
         DataView dv = new DataView(dt);

         DataTable dtReg = objDReg.GetConceptoRegula(objEReg);

         try
         {
            using (TransactionScope tx = new TransactionScope())
            {
               /*************** PROCESOS ADICIONALES ***************************/

                switch (objE.IdPlanilla)
                {
                    case ConstPlanilla.GRATIFICACION_EMPLEADO:
                    case ConstPlanilla.GRATIFICACION_OBRERO:
                        /*************** CREAR HORA GRATIFICAICONES ***************************/
                        objDProc.CrearHorasGratificacion(objECal);
                        break;
                    case ConstPlanilla.SUBSIDIO_EMPLEADO:
                    case ConstPlanilla.SUBSIDIO_OBRERO:
                        /*************** CREAR HORA Subsidio ***************************/
                        objDProc.CrearHorasSubsidio(objECal);
                        break;
                }
                              

               /*************** Limpiar las tablas para el proceso***************************/
               objDCta.RevierteCuotasCobradas(objECta);
               objDProc.EliminaDatosProcActual(objECal);
               objDProc.EliminaTablasTemp(objECal);

               /*************** Procesar Remuneraciones ***********************************/
               objDProc.CrearTablasTemp(objECal);

               dv.RowFilter = "idTipConcep='" + ConstTipoConcepPlanilla.REMUNERACION + "'";
               dv.Sort = "nuSecuen ASC";
               foreach (DataRowView drv in dv)
               {
                  objECal.IdConRemu = drv["idConRemu"].ToString();
                  objDProc.ProcCalculoXConcepto(objECal);
               }

               /*************** Procesar Regularizaciones *********************************/
               objDProc.EliminaTablasTemp(objECal);

               objECal.StOrigen = ConstTipoRegularizacion.REGULARIZACION;
               objDProc.CrearTablasTemp(objECal);

               foreach (DataRow dr in dtReg.Rows)
               {
                  objECal.IdConRemu = dr["idConRemu"].ToString();
                  objDProc.ProcCalculoXConcepto(objECal);
               }

               objDRegMnt.ProcRegulaXMonto(objEReg);

               /*************** Procesar Retenciones/Aportaciones *************************/
               objDProc.EliminaTablasTemp(objECal);

               objECal.StOrigen = ConstTipoRegularizacion.NINGUNO;
               objDProc.CrearTablasTemp(objECal);

               dv.RowFilter = "idTipConcep='" + ConstTipoConcepPlanilla.RETENCION + "'";
               foreach (DataRowView drv in dv)
               {
                  objECal.IdConRemu = drv["idConRemu"].ToString();
                  objDProc.ProcCalculoXConcepto(objECal);
               }

               dv.RowFilter = "idTipConcep='" + ConstTipoConcepPlanilla.APORTACION + "'";
               foreach (DataRowView drv in dv)
               {
                  objECal.IdConRemu = drv["idConRemu"].ToString();

                  objDProc.ProcCalculoXConcepto(objECal);
               }

               objDProc.EliminaTablasTemp(objECal);

               /********************* Procesar Prestamos **************************/
               objDCta.CobrarCuotasXPlanilla(objECta);

               /*************** Procesar Calculos Finales *************************/
               objDRes.EliminaDatosProcActual(objERes);

               objDRes.ProcResultadosCalcActual(objERes);

               tx.Complete();

            }
         }
         catch (Exception ex)
         {
            throw ex;
         }

      }

      public void ActualizarEstado(EProcPlani value)
      {
         IDOUpdate objDO = new RHDOMnt.ProcPlani();
         IDOQuery objDOQ = new RHDOQry.ProcPlani();

         if (value.EntityState == EntityState.Unchanged)
            return;

         value = (EProcPlani)objDOQ.GetByKey(value);
         if (value != null)
         {
            value.StProceso = ConstEstadoProcePlani.CERRADA;
            objDO.Update(value);
         }

      }


      #endregion

   }
}
