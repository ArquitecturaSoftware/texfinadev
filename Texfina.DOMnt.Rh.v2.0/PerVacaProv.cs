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
    /// Data Object para Mantenimiento a la Tabla: RH_PerVacaProv (RH_PerVacaProv)
    /// </summary>
    /// <remarks></remarks>
    public class PerVacaProv : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EPerVacaProv objE = (EPerVacaProv)value;

            //----------- Generacion de Codigos ------------------

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_PerVacaProv_mnt01", arrPrm);

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

            EPerVacaProv objE = (EPerVacaProv)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_PerVacaProv_mnt02", arrPrm);

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

            EPerVacaProv objE = (EPerVacaProv)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidPeriVac", SqlDbType.Char, 4, objE.IdPeriVac));

                int intRes = this.ExecuteNonQuery("RH_PerVacaProv_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EPerVacaProv value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriVac", SqlDbType.Char, 4, value.IdPeriVac));
            arrPrm.Add(DataHelper.CreateParameter("@pnuDiasVaca", SqlDbType.SmallInt, value.NuDiasVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pmtVaca", SqlDbType.Decimal, value.MtVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pnuDiasPagado", SqlDbType.Decimal, value.NuDiasPagado));
            arrPrm.Add(DataHelper.CreateParameter("@pnuDiasGozado", SqlDbType.Decimal, value.NuDiasGozado));
            arrPrm.Add(DataHelper.CreateParameter("@pstVaca", SqlDbType.Char, 3, value.StVaca));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }
}
