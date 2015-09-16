using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Core.Common;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Co
{
    /// <summary>
    /// Data Object para Mantenimiento a la Tabla: CO_BienFiscaEstable (CO_BienFiscaEstable)
    /// </summary>
    /// <remarks></remarks>

    public class BienFiscaEstable : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EBienFiscaEstable objE = (EBienFiscaEstable)value;

            //----------- Generacion de Codigos ------------------
            TablaCorre objDO = new TablaCorre();
            ETablaCorre objECorre = new ETablaCorre();

            objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
            objECorre.IdEmpresa = objE.IdEmpresa;
            objECorre.IdTabla = "CO_BienFiscaEstable";

            string strNewCode = objDO.GenNewCode(objECorre);
            objE.Id = strNewCode;

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("CO_BienFiscaEstable_mnt01", arrPrm);

                return new object[] { objE.Id };
            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        public int Update(IEntityBase value)
        {

            EBienFiscaEstable objE = (EBienFiscaEstable)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("CO_BienFiscaEstable_mnt02", arrPrm);

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

            EBienFiscaEstable objE = (EBienFiscaEstable)value;

            try
            {

                ArrayList arrPrm = new ArrayList();



                int intRes = this.ExecuteNonQuery("CO_BienFiscaEstable_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EBienFiscaEstable value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pid", SqlDbType.Char, 3, value.Id));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pnuRUC", SqlDbType.VarChar, 11, value.NuRUC));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, value.IdEstable));
            arrPrm.Add(DataHelper.CreateParameter("@pdsDireccion", SqlDbType.VarChar, 70, value.DsDireccion));
            arrPrm.Add(DataHelper.CreateParameter("@pdsDireccionDet", SqlDbType.VarChar, 50,value.DsDireccionDet));
            arrPrm.Add(DataHelper.CreateParameter("@pstZGBRE", SqlDbType.Char, 2, value.StZGBRE ));
            arrPrm.Add(DataHelper.CreateParameter("@pdsEstado", SqlDbType.VarChar, 50, value.DsEstado ));
            arrPrm.Add(DataHelper.CreateParameter("@pidFechaIniEstado", SqlDbType.DateTime, (value.IdFechaIniEstado.HasValue ? (object)value.IdFechaIniEstado : DBNull.Value)));
            arrPrm.Add(DataHelper.CreateParameter("@pidFechaFinEstado", SqlDbType.DateTime, (value.IdFechaFinEstado.HasValue ? (object)value.IdFechaFinEstado : DBNull.Value)));
            arrPrm.Add(DataHelper.CreateParameter("@pidEstado", SqlDbType.Char, 3, value.IdEstado ));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }


}
