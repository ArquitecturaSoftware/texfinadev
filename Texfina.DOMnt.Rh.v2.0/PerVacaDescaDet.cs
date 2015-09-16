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
    /// Data Object para Mantenimiento a la Tabla: RH_PerVacaDescaDet (RH_PerVacaDescaDet)
    /// </summary>
    /// <remarks></remarks>
    public class PerVacaDescaDet : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;
            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_PerVacaDescaDet_mnt01", arrPrm);

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

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_PerVacaDescaDet_mnt02", arrPrm);

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

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidVacaDesca", SqlDbType.Char, 4, objE.IdVacaDesca));
                arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

                int intRes = this.ExecuteNonQuery("RH_PerVacaDescaDet_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EPerVacaDescaDet value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidVacaDesca", SqlDbType.Char, 4, value.IdVacaDesca));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriVac", SqlDbType.Char, 4, value.IdPeriVac));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pnuProcAnual", SqlDbType.SmallInt, value.NuProcAnual));
            arrPrm.Add(DataHelper.CreateParameter("@pidConRemu", SqlDbType.Char, 3, value.IdConRemu));
            arrPrm.Add(DataHelper.CreateParameter("@pnuDiasVaca", SqlDbType.Decimal, value.NuDiasVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pmtVaca", SqlDbType.Decimal, value.MtVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pfeVaca", SqlDbType.DateTime, value.FeVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pstVaca", SqlDbType.Char, 3, value.StVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }
}
