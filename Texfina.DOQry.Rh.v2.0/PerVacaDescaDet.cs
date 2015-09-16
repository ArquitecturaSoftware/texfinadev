using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;

namespace Texfina.DOQry.Rh
{
    /// <summary>
    /// Data Object para Consultas a la Tabla: RH_PerVacaDescaDet (RH_PerVacaDescaDet)
    /// </summary>
    /// <remarks></remarks>
    public class PerVacaDescaDet : DataObjectBase, IDOQuery
    {

        #region IDOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
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

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDescaDet_qry01", arrPrm);

                return dt;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        public IEntityBase GetByKey(IEntityBase value)
        {

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDescaDet_qry02", arrPrm);

                objE = null;

                foreach (DataRow dr in dt.Rows)
                    objE = DataHelper.CopyDataRowToEntity<EPerVacaDescaDet>(dr, typeof(EPerVacaDescaDet));

                return objE;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        public DataTable GetByParentKey(IEntityBase value)
        {

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDescaDet_qry03", arrPrm);

                return dt;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        public DataTable GetList(IEntityBase value)
        {

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDescaDet_qry04", arrPrm);

                return dt;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        public bool Exists(IEntityBase value)
        {

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);
                int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

                SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDescaDet_qry05", arrPrm);

                return objPrm[intIdx].Value.ToString() == "1" ? true : false;

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

            return arrPrm;

        }


        public DataTable GetMontoRemuTotal(IEntityBase value)
        {

            EPerVacaDescaDet objE = (EPerVacaDescaDet)value;

            try
            {

                ArrayList arrPrm = new ArrayList();

                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pfeInicio", SqlDbType.DateTime, objE.FeVaca));

                DataTable dt = this.ExecuteDatatable("RH_PerVacaDesca_qry10", arrPrm);

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
