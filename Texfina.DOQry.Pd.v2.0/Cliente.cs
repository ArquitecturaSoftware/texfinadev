using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Pd;

namespace Texfina.DOQry.Pd
{
    /// <summary>
    /// Data Object para Consultas a la Tabla: Personal (RH_Personal)
    /// </summary>
    /// <remarks></remarks>
    public class Cliente : DataObjectBase, IDOQuery
    {

        #region IDOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            EClienteBandeja objE = (EClienteBandeja)value;

            try
            {

                ArrayList arrPrm = new ArrayList();
                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidCliente", SqlDbType.Char, 7, objE.IdCliente));
                arrPrm.Add(DataHelper.CreateParameter("@pnuNif", SqlDbType.VarChar, 20, objE.NuNif));
                arrPrm.Add(DataHelper.CreateParameter("@pdsRazSocial", SqlDbType.VarChar, 150, objE.DsRazSocial));

                DataTable dt = this.ExecuteDatatable("PD_Clientes_qry01", arrPrm);

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

            ECliente objE = (ECliente)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("PD_Clientes_qry02", arrPrm);

                objE = null;

                foreach (DataRow dr in dt.Rows)
                    objE = DataHelper.CopyDataRowToEntity<ECliente>(dr, typeof(ECliente));

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

            ECliente objE = (ECliente)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("PD_Clientes_qry03", arrPrm);

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

            ECliente objE = (ECliente)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("PD_Clientes_qry04", arrPrm);

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

            ECliente objE = (ECliente)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);
                int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

                SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

                DataTable dt = this.ExecuteDatatable("PD_Clientes_qry05", arrPrm);

                return objPrm[intIdx].Value.ToString() == "1" ? true : false;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        private ArrayList BuildParamInterface(ECliente value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidCliente", SqlDbType.Char, 7, value.IdCliente));

            return arrPrm;

        }

        #endregion

   
    }
}
