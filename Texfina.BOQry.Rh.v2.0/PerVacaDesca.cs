using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using RHDOQry = Texfina.DOQry.Rh;

namespace Texfina.BOQry.Rh
{
        /// <summary>
    /// Interface para Consultas personalizadas a la Tabla: RH_PerDepen,RH_PerFoto,RH_PerContrato,
    ///  RH_PerPlanilla,RH_Planilla,RH_PerExpeLabo,RH_PerEducacion,RH_Personal,MG_CliProv
    /// </summary>
    [ServiceContract()]
    public interface IPerVacaDesca
    {
        /// <summary>
        /// Obtiene las registro de la tabla RH_PerDepen, por su llave padre.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        DataTable GetByParentKeyVacaDesca(IEntityBase value);

        /// <summary>
        /// Obtiene las registro de la tabla RH_PerDepen, por su llave padre.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        DataTable GetMontoRemuTotal(IEntityBase value);

    }

    /// <summary>
    /// Business Object para Consultas a la Tabla: RH_PerVacaDesca (RH_PerVacaDesca)
    /// </summary>
    public class PerVacaDesca : BusinessObjectBase, IBOQuery, IPerVacaDesca
    {

        #region IBOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaDesca();

            try
            {

                DataTable dt = objData.GetByCriteria(value);

                return dt;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public IEntityBase GetByKey(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaDesca();

            try
            {

                IEntityBase objE = objData.GetByKey(value);

                return objE;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public DataTable GetByParentKey(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaDesca();

            try
            {

                DataTable dt = objData.GetByParentKey(value);

                return dt;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public DataTable GetList(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaDesca();

            try
            {

                DataTable dt = objData.GetList(value);

                return dt;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public bool Exists(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaDesca();

            try
            {

                bool blnRes = objData.Exists(value);

                return blnRes;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        #endregion

        #region IPerVacadesca

        public DataTable GetByParentKeyVacaDesca(IEntityBase value)
        {
            IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaDescaDet();

            try
            {

                DataTable dt = objData.GetByParentKey(value);

                return dt;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        public DataTable GetMontoRemuTotal(IEntityBase value)
        {
            RHDOQry.PerVacaDescaDet objData = new RHDOQry.PerVacaDescaDet();

            try
            {

                DataTable dt = objData.GetMontoRemuTotal(value);

                return dt;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        #endregion
    }
}
