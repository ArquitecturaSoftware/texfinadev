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
    /// Data Object para Consultas a la Tabla: Planilla (RH_Planilla)
    /// </summary>
    /// <remarks></remarks>
    public class Planilla : DataObjectBase, IDOQuery
    {

        #region IDOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            EPlanilla objE = (EPlanilla)value;

            try
            {

                ArrayList arrPrm = new ArrayList();

                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
                arrPrm.Add(DataHelper.CreateParameter("@pdsPlanilla", SqlDbType.Char, 50, objE.DsPlanilla));

                DataTable dt = this.ExecuteDatatable("RH_Planilla_qry01", arrPrm);

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

            EPlanilla objE = (EPlanilla)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_Planilla_qry02", arrPrm);

                objE = null;

                foreach (DataRow dr in dt.Rows)
                    objE = DataHelper.CopyDataRowToEntity<EPlanilla>(dr, typeof(EPlanilla));

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

            EPlanilla objE = (EPlanilla)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_Planilla_qry03", arrPrm);

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

            EPlanilla objE = (EPlanilla)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_Planilla_qry04", arrPrm);

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

            EPlanilla objE = (EPlanilla)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);
                int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

                SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

                DataTable dt = this.ExecuteDatatable("RH_Planilla_qry05", arrPrm);

                return objPrm[intIdx].Value.ToString() == "1" ? true : false;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        private ArrayList BuildParamInterface(EPlanilla value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, value.IdPlanilla));

            return arrPrm;

        }

        #endregion


        public bool ExistsPersonalPlanilla(IEntityBase value)
        {

           EPersonalPlanilla objE = (EPersonalPlanilla)value;

           try
           {

              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));

              int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

              SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

              DataTable dt = this.ExecuteDatatable("RH_Planilla_qry10", arrPrm);

              return objPrm[intIdx].Value.ToString() == "1" ? true : false;

           }
           catch (Exception ex)
           {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

           }
        }

        public DataTable GetListPlanillaVaciones(IEntityBase value)
        {

            EPlanilla objE = (EPlanilla)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_Planilla_qry11", arrPrm);

                return dt;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }
    }
}
