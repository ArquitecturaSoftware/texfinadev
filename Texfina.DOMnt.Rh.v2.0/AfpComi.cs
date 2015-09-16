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
    /// Data Object para Mantenimiento a la Tabla: Afp - Comision (RH_AfpComi)
    /// </summary>
    /// <remarks></remarks>
    public class AfpComi : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EAfpComi objE = (EAfpComi)value;

            //----------- Generacion de Codigos ------------------
            //TablaCorre objDO = new TablaCorre();
            //ETablaCorre objECorre = new ETablaCorre();

            //objECorre.IdPeriodo = objE.IdPeriodo;
            //objECorre.IdEmpresa = ""; //objE.IdEmpresa;
            //objECorre.IdTabla = "RH_AfpComi";

            //string strNewCode = objDO.GenNewCode(objECorre);
            //objE.IdAfp = strNewCode;

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_AfpComi_mnt01", arrPrm);

                return new object[] { objE.IdAfp };

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        public int Update(IEntityBase value)
        {

            EAfpComi objE = (EAfpComi)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_AfpComi_mnt02", arrPrm);

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

            EAfpComi objE = (EAfpComi)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidAfp", SqlDbType.Char, 3, objE.IdAfp));
                arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
                arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, objE.IdMes));
                arrPrm.Add(DataHelper.CreateParameter("@pidTipoComi", SqlDbType.Char, 3, objE.IdTipoComi));

                int intRes = this.ExecuteNonQuery("RH_AfpComi_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EAfpComi value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidAfp", SqlDbType.Char, 3, value.IdAfp));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, value.IdMes));
            arrPrm.Add(DataHelper.CreateParameter("@pidTipoComi", SqlDbType.Char, 3, value.IdTipoComi));
            arrPrm.Add(DataHelper.CreateParameter("@pidTipoValor", SqlDbType.Char, 3, value.IdTipoValor));
            arrPrm.Add(DataHelper.CreateParameter("@pnuValor", SqlDbType.Decimal, value.NuValor));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }
}
