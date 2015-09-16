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
    /// Data Object para Mantenimiento a la Tabla: Proceso de Planilla (RH_ProcPlani)
    /// </summary>
    /// <remarks></remarks>
    public class ProcPlani : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EProcPlani objE = (EProcPlani)value;

            ////----------- Generacion de Codigos ------------------
            //TablaCorre objDO = new TablaCorre();
            //ETablaCorre objECorre = new ETablaCorre();

            //objECorre.IdPeriodo = objE.IdPeriodo;
            //objECorre.IdEmpresa = objE.IdEmpresa;
            //objECorre.IdTabla = "RH_ProcPlani";

            //string strNewCode = objDO.GenNewCode(objECorre);
            //objE.IdPeriodo = strNewCode;

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_ProcPlani_mnt01", arrPrm);

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

            EProcPlani objE = (EProcPlani)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_ProcPlani_mnt02", arrPrm);

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

            EProcPlani objE = (EProcPlani)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
                arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
                arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));

                int intRes = this.ExecuteNonQuery("RH_ProcPlani_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EProcPlani value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, value.IdMes));
            arrPrm.Add(DataHelper.CreateParameter("@pidMoneda", SqlDbType.Char, 3, value.IdMoneda));
            arrPrm.Add(DataHelper.CreateParameter("@pmtTC", SqlDbType.Decimal, value.MtTC));
            arrPrm.Add(DataHelper.CreateParameter("@pfeDesde", SqlDbType.DateTime, value.FeDesde));
            arrPrm.Add(DataHelper.CreateParameter("@pfeHasta", SqlDbType.DateTime, value.FeHasta));
            arrPrm.Add(DataHelper.CreateParameter("@pfeProceso", SqlDbType.DateTime, (value.FeProceso.HasValue ? (object)value.FeProceso : DBNull.Value)));
            arrPrm.Add(DataHelper.CreateParameter("@pstProceso", SqlDbType.Char, 3, value.StProceso));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));


            return arrPrm;

        }

        #endregion

    }
}
