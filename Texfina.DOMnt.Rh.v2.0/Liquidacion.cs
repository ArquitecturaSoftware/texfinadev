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
    /// Data Object para Mantenimiento a la Tabla: RH_Liquidacion (RH_Liquidacion)
    /// </summary>
    /// <remarks></remarks>
    public class Liquidacion : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            ELiquidacion objE = (ELiquidacion)value;

            //----------- Generacion de Codigos ------------------
            //----------- Generacion de Codigos ------------------
            TablaCorre objDO = new TablaCorre();
            ETablaCorre objECorre = new ETablaCorre();

            objECorre.IdPeriodo = "0000";
            objECorre.IdEmpresa = objE.IdEmpresa;
            objECorre.IdTabla = "RH_Liquidacion";

            string strNewCode = objDO.GenNewCode(objECorre);
            objE.IdLiquidacion = strNewCode;

            //----------------------------------------------------
            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_Liquidacion_mnt01", arrPrm);

                return new object[] { objE.IdLiquidacion };

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        public int Update(IEntityBase value)
        {

            ELiquidacion objE = (ELiquidacion)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_Liquidacion_mnt02", arrPrm);

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

            ELiquidacion objE = (ELiquidacion)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
                arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
                arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidLiquidacion", SqlDbType.Char, 4, objE.IdLiquidacion));

                int intRes = this.ExecuteNonQuery("RH_Liquidacion_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(ELiquidacion value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidLiquidacion", SqlDbType.Char, 4, value.IdLiquidacion));
            arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, value.IdMes));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuenContra", SqlDbType.SmallInt, value.NuSecuenContra));
            arrPrm.Add(DataHelper.CreateParameter("@pfeIngreso", SqlDbType.DateTime, value.FeIngreso));
            arrPrm.Add(DataHelper.CreateParameter("@pfeCese", SqlDbType.DateTime, value.FeCese));
            arrPrm.Add(DataHelper.CreateParameter("@pidCargo", SqlDbType.Char, 3, value.IdCargo));
            arrPrm.Add(DataHelper.CreateParameter("@pidMotivoCese", SqlDbType.Char, 3, value.IdMotivoCese));
            arrPrm.Add(DataHelper.CreateParameter("@pmtAPagar", SqlDbType.Decimal, value.MtAPagar));
            arrPrm.Add(DataHelper.CreateParameter("@pdsObserva", SqlDbType.VarChar, 200, value.DsObserva));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        public int DeleteDetail(IEntityBase value)
        {

            ELiquidacion objE = (ELiquidacion)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
                arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
                arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidLiquidacion", SqlDbType.Char, 4, objE.IdLiquidacion));

                int intRes = this.ExecuteNonQuery("RH_Liquidacion_mnt10", arrPrm);

                return intRes;

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
