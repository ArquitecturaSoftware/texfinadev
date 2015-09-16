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
    public class PerVacaDesca : DataObjectBase
    {
        #region Members

        public DataTable GetSolicitudVacaciones(IEntityBase value)
        {

            EPerVacaDesca objE = (EPerVacaDesca)value;

            try
            {

                ArrayList arrPrm = new ArrayList();
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidVacaDesca", SqlDbType.Char, 4, objE.IdVacaDesca));

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDesca_rpt01", arrPrm);

                return dt;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        public DataTable GetPlanillaVacaciones(IEntityBase value)
        {

            EPerVacaDesca objE = (EPerVacaDesca)value;

            try
            {

                ArrayList arrPrm = new ArrayList();
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidVacaDesca", SqlDbType.Char, 4, objE.IdVacaDesca));

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDesca_rpt02", arrPrm);

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
