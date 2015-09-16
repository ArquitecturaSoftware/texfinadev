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
    /// Data Object para Mantenimiento a la Tabla: Experiencia Laboral del Personal (RH_PerExpeLabo)
    /// </summary>
    /// <remarks></remarks>
    public class PerExpeLabo : DataObjectBase, IDOUpdate
    {

        #region IDOUpdate Members

        public object[] Insert(IEntityBase value)
        {

            EPerExpeLabo objE = (EPerExpeLabo)value;

            ////----------- Generacion de Codigos ------------------
            //TablaCorre objDO = new TablaCorre();
            //ETablaCorre objECorre = new ETablaCorre();

            ////objECorre.IdPeriodo = objE.IdPeriodo;
            //objECorre.IdEmpresa = objE.IdEmpresa;
            //objECorre.IdTabla = "RH_PerExpeLabo";

            //string strNewCode = objDO.GenNewCode(objECorre);
            //objE.IdEmpresa = strNewCode;

            //----------------------------------------------------
            ArrayList arrPrm = BuildParamInterface(objE);

            try
            {
                int intRes = this.ExecuteNonQuery("RH_PerExpeLabo_mnt01", arrPrm);

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

            EPerExpeLabo objE = (EPerExpeLabo)value;

            try
            {

                ArrayList arrPrm = BuildParamInterface(objE);

                int intRes = this.ExecuteNonQuery("RH_PerExpeLabo_mnt02", arrPrm);

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

            EPerExpeLabo objE = (EPerExpeLabo)value;

            try
            {

                ArrayList arrPrm = new ArrayList();


                arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
                arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
                arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

                int intRes = this.ExecuteNonQuery("RH_PerExpeLabo_mnt03", arrPrm);

                return intRes;

            }
            catch (Exception ex)
            {

                ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
                throw objEx;

            }

        }

        private ArrayList BuildParamInterface(EPerExpeLabo value)
        {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));
            arrPrm.Add(DataHelper.CreateParameter("@pdsEmpresa", SqlDbType.VarChar, 150, value.DsEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidOcupa", SqlDbType.Char, 6, value.IdOcupa));
            arrPrm.Add(DataHelper.CreateParameter("@pfeInicio", SqlDbType.DateTime, value.FeInicio));
            arrPrm.Add(DataHelper.CreateParameter("@pfeFin", SqlDbType.DateTime, value.FeFin));
            arrPrm.Add(DataHelper.CreateParameter("@pdsDescripOcupa", SqlDbType.VarChar, 200, value.DsDescripOcupa));
            arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

            return arrPrm;

        }

        #endregion

    }
}
