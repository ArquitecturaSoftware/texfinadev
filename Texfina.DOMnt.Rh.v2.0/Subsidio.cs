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
    /// Data Object para Mantenimiento a la Tabla: RH_Subsidio (RH_Subsidio)
    /// </summary>
    /// <remarks></remarks>
    public class Subsidio : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            ESubsidio objE = (ESubsidio)value;

            //----------- Generacion de Codigos ------------------
            TablaCorre objDO = new TablaCorre();
            ETablaCorre objECorre = new ETablaCorre();

            objECorre.IdPeriodo = objE.IdPeriodo;
            objECorre.IdEmpresa = objE.IdEmpresa;
            objECorre.IdTabla = "RH_Subsidio";

            string strNewCode = objDO.GenNewCode(objECorre);
            objE.IdSubsidio = strNewCode;

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_Subsidio_mnt01", arrPrm);

                return new object[] { objE.IdSubsidio };

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        public int Update(IEntityBase value)
        {

            ESubsidio objE = (ESubsidio)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_Subsidio_mnt02", arrPrm);

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

            ESubsidio objE = (ESubsidio)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
                arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
                arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, objE.NuProcAnual));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidSubsidio", SqlDbType.Char, 4, objE.IdSubsidio));

                int intRes = this.ExecuteNonQuery("RH_Subsidio_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(ESubsidio value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidSubsidio", SqlDbType.Char, 4, value.IdSubsidio));
            arrPrm.Add(DataHelper.CreateParameter("@pidTipoSubsidio", SqlDbType.Char, 3, value.IdTipoSubsidio));
            arrPrm.Add(DataHelper.CreateParameter("@pfeSubsidio", SqlDbType.DateTime, value.FeSubsidio));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicioPerioIncapa", SqlDbType.DateTime, value.FeInicioPerioIncapa));
            arrPrm.Add(DataHelper.CreateParameter("@pfeFinPerioIncapa", SqlDbType.DateTime, value.FeFinPerioIncapa));
            arrPrm.Add(DataHelper.CreateParameter("@pdsObserva", SqlDbType.VarChar, 500, value.DsObserva));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }
}
