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
   /// Interface para Consultas personalizadas
   /// </summary>
   [ServiceContract()]
   public interface IConcepRemu
   {
      /// <summary>
      /// Obtiene los registro de la tabla RH_ConRemuDet, por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetDetailByParentKey(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla Campos.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetCamposParentKey(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla por tipo de concepto.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetListXTipConce(IEntityBase value);

   }


   /// <summary>
   /// Business Object para Consultas a la Tabla: Concepto de Remuneracion (RH_ConcepRemu)
   /// </summary>
   public class ConcepRemu : BusinessObjectBase, IBOQuery, IConcepRemu
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.ConcepRemu();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ConcepRemu();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ConcepRemu();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ConcepRemu();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ConcepRemu();

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

      #region IConcepRemu Members

      public DataTable GetDetailByParentKey(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.ConRemuDet();

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

      public DataTable GetCamposParentKey(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.ConRemuCampo();

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

      public DataTable GetListXTipConce(IEntityBase value)
      {

         RHDOQry.ConcepRemu objData = new RHDOQry.ConcepRemu();

         try
         {

            DataTable dt = objData.GetListXTipConce(value);

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