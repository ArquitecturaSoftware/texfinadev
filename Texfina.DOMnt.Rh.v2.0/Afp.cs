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
    /// Data Object para Mantenimiento a la Tabla: Afp (RH_Afp)
    /// </summary>
    /// <remarks></remarks>
    public class Afp : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EAfp objE = (EAfp)value;

            //----------- Generacion de Codigos ------------------
            TablaCorre objDO = new TablaCorre();
            ETablaCorre objECorre = new ETablaCorre();

            objECorre.IdPeriodo = "0000";
            objECorre.IdEmpresa = "000";
            objECorre.IdTabla = "RH_Afp";

            string strNewCode = objDO.GenNewCode(objECorre);
            objE.IdAfp = strNewCode;

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_Afp_mnt01", arrPrm);

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

            EAfp objE = (EAfp)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_Afp_mnt02", arrPrm);

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

            EAfp objE = (EAfp)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidAfp", SqlDbType.Char, 3, objE.IdAfp));

                int intRes = this.ExecuteNonQuery("RH_Afp_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EAfp value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidAfp", SqlDbType.Char, 3, value.IdAfp));
            arrPrm.Add(DataHelper.CreateParameter("@pdsAfp", SqlDbType.VarChar, 80, value.DsAfp));
            arrPrm.Add(DataHelper.CreateParameter("@pdsAbrev", SqlDbType.VarChar, 30, value.DsAbrev));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }
}
