using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using PDDOQry = Texfina.DOQry.Pd;

namespace Texfina.BOQry.Pd
{
    /// <summary>
    /// Business Object para Consultas a la Tabla: PD_Maquinas (PD_Maquinas)
    /// </summary>
    public class Maquinas : BusinessObjectBase, IBOQuery
    {

        #region IBOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new PDDOQry.Maquinas();

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

            IDOQuery objData = (IDOQuery)new PDDOQry.Maquinas();

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

            IDOQuery objData = (IDOQuery)new PDDOQry.Maquinas();

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

            IDOQuery objData = (IDOQuery)new PDDOQry.Maquinas();

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

            IDOQuery objData = (IDOQuery)new PDDOQry.Maquinas();

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

    }
}
