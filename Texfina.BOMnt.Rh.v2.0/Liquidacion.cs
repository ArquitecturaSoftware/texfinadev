using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Rh;
using Texfina.Core.Common;
using RHDOMnt = Texfina.DOMnt.Rh;
using RHDOQry = Texfina.DOQry.Rh;
using Texfina.Common.Mg;

namespace Texfina.BOMnt.Rh
{
    /// <summary>
    /// Business Object para Mantenimiento a la Tabla: RH_Liquidacion (RH_Liquidacion)
    /// </summary>
    public class Liquidacion : BusinessObjectBase, IBOUpdate
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            ELiquidacionSet objE = (ELiquidacionSet)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.Liquidacion, true);
                    objRet = this.UpdateMaster(objE.Liquidacion);
                    this.UpdateDetail(objE.LiquidacionDet, objRet);



                    ProcesarCalculo(objE.Liquidacion);

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

            ELiquidacionSet objE = (ELiquidacionSet)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.Liquidacion, false);
                    this.DeleteMaster(objE.Liquidacion);

                    tx.Complete();

                }

                return 1;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        #endregion

        private object[] UpdateMaster(ELiquidacion entity)
        {

            IDOUpdate objDO = new RHDOMnt.Liquidacion();

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

        private void UpdateDetail(IList<ELiquidacionDet> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.LiquidacionDet();

            foreach (ELiquidacionDet objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdLiquidacion = primKey[0].ToString();
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

        private void DeleteMaster(ELiquidacion entity)
        {

            IDOUpdate objDO = new RHDOMnt.Liquidacion();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(ELiquidacion entity, bool filterModified)
        {

            if (entity == null)
                return;

            RHDOMnt.Liquidacion objDO = new RHDOMnt.Liquidacion();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.DeleteDetail(entity);

        }

        private void ProcesarCalculo(IEntityBase value)
        {

            ELiquidacion objE = (ELiquidacion)value;

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

            /*************** Limpiar las tablas para el proceso***************************/

            objDCta.RevierteCuotasCobradasLiquidacion(objECta);
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

            //objDCta.CobrarCuotasXPlanilla(objECta);

            /*************** Procesar Calculos Finales *************************/
            objDRes.EliminaDatosProcActual(objERes);

            objDRes.ProcResultadosCalcActual(objERes);
            
        }
        
    }
}
