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
    /// Interface para Consultas personalizadas a la Tabla: RH_Liquidacion
    /// </summary>
    [ServiceContract()]
    public interface ILiquidacion
    {
        /// <summary>
        /// Obtiene las registro de la tabla RH_PerDepen, por su llave padre.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        DataTable GetCTSVacaGratiTruncas(IEntityBase value);
       
    }

    /// <summary>
    /// Business Object para Consultas a la Tabla: RH_Liquidacion (RH_Liquidacion)
    /// </summary>
    public class Liquidacion : BusinessObjectBase, IBOQuery, ILiquidacion
    {

        #region IBOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.Liquidacion();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Liquidacion();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Liquidacion();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Liquidacion();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Liquidacion();

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

        #region ILiquidacion

        public DataTable GetCTSVacaGratiTruncas(IEntityBase value)
        {

            RHDOQry.Liquidacion objData = new RHDOQry.Liquidacion();

            try
            {

                DataTable dt = objData.GetCTSVacaGratiTruncas(value);

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
