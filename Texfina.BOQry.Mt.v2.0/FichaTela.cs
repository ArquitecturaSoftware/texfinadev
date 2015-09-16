using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using MTDOQry = Texfina.DOQry.Mt;

namespace Texfina.BOQry.Mt
{

    /// <summary>
    /// Interface para Consultas personalizadas a la Tabla: MT_FichaTela
    /// </summary>
    [ServiceContract()]
    public interface IFichaTela
    {

        /// <summary>
        /// Obtiene los registros de la Tabla MT_FichaTela(Ficha de Telas).
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        DataTable GetByCriteriaFichaTela(IEntityBase value);

    }


    /// <summary>
    /// Business Object para Consultas a la Tabla: Personal (RH_Personal)
    /// </summary>
    public class FichaTela : BusinessObjectBase, IBOQuery, IFichaTela
    {

        #region IBOQuery Members


        public DataTable GetByCriteria(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new MTDOQry.FichaTela();

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

            IDOQuery objData = (IDOQuery)new MTDOQry.FichaTela();

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

            IDOQuery objData = (IDOQuery)new MTDOQry.FichaTela();

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

            IDOQuery objData = (IDOQuery)new MTDOQry.FichaTela();

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

            IDOQuery objData = (IDOQuery)new MTDOQry.FichaTela();

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


        #region IPersonal Members


        public DataTable GetByCriteriaFichaTela(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new MTDOQry.FichaTela();

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


        #endregion

    }
}
