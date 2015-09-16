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
    /// Interface para Consultas personalizadas a la Tabla: RH_PlanillaDet (RH_PlanillaDet)
    /// </summary>
    [ServiceContract()]
    public interface IPlanilla
    {
        /// <summary>
        /// Obtiene las registro de la tabla RH_PlanillaDet, por su llave padre.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        DataTable GetByParentKeyPlaniDet(IEntityBase value);

        /// <summary>
        /// Metodo general para consultar datos por la llave primaria a la tabla RH_PlanillaDet
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna una Entidad Base que representa el registro requerido</returns>
        [OperationContract()]
        [NetDataContract()]
        IEntityBase GetByKeyPerPlaniDet(IEntityBase value);

        /// <summary>
        /// Metodo general para consultar datos por la llave primaria a la tabla RH_PlanillaDet
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna una Entidad Base que representa el registro requerido</returns>
        [OperationContract()]
        [NetDataContract()]
        bool ExistsPersonalPlanilla(IEntityBase value);

        /// <summary>
        /// Obtiene las registro de la tabla RH_Planilla solo para planilla tipo Vacaciones.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        DataTable GetListPlanillaVaciones(IEntityBase value);
    }


    /// <summary>
    /// Business Object para Consultas a la Tabla: Planilla (RH_Planilla)
    /// </summary>
    public class Planilla : BusinessObjectBase, IBOQuery, IPlanilla
    {

        #region IBOQuery Members

        public DataTable GetByCriteria(IEntityBase value)
        {

            IDOQuery objData = (IDOQuery)new RHDOQry.Planilla();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Planilla();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Planilla();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Planilla();

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

            IDOQuery objData = (IDOQuery)new RHDOQry.Planilla();

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

        #region IPlanilla Members

      public DataTable GetByParentKeyPlaniDet(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PlanillaDet();

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

      public IEntityBase GetByKeyPerPlaniDet(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PlanillaDet();

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

      public bool ExistsPersonalPlanilla(IEntityBase value)
      {

         RHDOQry.Planilla objData = new RHDOQry.Planilla();

         try
         {

            bool blnRes = objData.ExistsPersonalPlanilla(value);

            return blnRes;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetListPlanillaVaciones(IEntityBase value)
      {

          RHDOQry.Planilla objData = new RHDOQry.Planilla();

          try
          {

              DataTable dt = objData.GetListPlanillaVaciones(value);

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
