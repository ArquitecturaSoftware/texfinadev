﻿using System;
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
    /// Data Object para Consultas a la Tabla: Personal Remuneración (RH_PerRemu)
    /// </summary>
    /// <remarks></remarks>
    public class PerRemu : DataObjectBase, IDOQuery
    {

        #region IDOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            EPerRemu objE = (EPerRemu)value;

            try
            {

                ArrayList arrPrm = new ArrayList();

                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, objE.IdForPago));
                arrPrm.Add(DataHelper.CreateParameter("@pidTipoRemu", SqlDbType.Char, 3, objE.IdTipoRemu));

                DataTable dt = this.ExecuteDatatable("RH_PerRemu_qry01", arrPrm);

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

            EPerRemu objE = (EPerRemu)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_PerRemu_qry02", arrPrm);

                objE = null;

                foreach (DataRow dr in dt.Rows)
                    objE = DataHelper.CopyDataRowToEntity<EPerRemu>(dr, typeof(EPerRemu));

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

            EPerRemu objE = (EPerRemu)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_PerRemu_qry03", arrPrm);

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

            EPerRemu objE = (EPerRemu)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                DataTable dt = this.ExecuteDatatable("RH_PerRemu_qry04", arrPrm);

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

            EPerRemu objE = (EPerRemu)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);
                int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

                SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

                DataTable dt = this.ExecuteDatatable("RH_PerRemu_qry05", arrPrm);

                return objPrm[intIdx].Value.ToString() == "1" ? true : false;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }
        }

        private ArrayList BuildParamInterface(EPerRemu value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidForPago", SqlDbType.Char, 3, value.IdForPago));
            arrPrm.Add(DataHelper.CreateParameter("@pidTipoRemu", SqlDbType.Char, 3, value.IdTipoRemu));

            return arrPrm;

        }

        #endregion

        public IEntityBase GetPerRemuneracionActiva(IEntityBase value)
        {

           EPerRemu objE = (EPerRemu)value;

           try
           {

              ArrayList arrPrm = BuildParamInterface(objE);

              DataTable dt = this.ExecuteDatatable("RH_PerRemu_qry10", arrPrm);

              objE = null;

              foreach (DataRow dr in dt.Rows)
                 objE = DataHelper.CopyDataRowToEntity<EPerRemu>(dr, typeof(EPerRemu));

              return objE;

           }
           catch (Exception ex)
           {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

           }
        }

    }
}
