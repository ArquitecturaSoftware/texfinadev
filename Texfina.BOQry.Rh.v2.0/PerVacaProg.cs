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
   /// Interface para Consultas personalizadas a la Tabla: Programacion de vacaciones (RH_PerVacaProg)
   /// </summary>
   [ServiceContract()]
   public interface IPerVacaProg
   {
      /// <summary>
      /// Obtiene los registro de la tabla RH_PerVacaProg.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetProcesosXRangoFecha(IEntityBase value);

      /// <summary>
      /// Obtiene los registro de la tabla RH_PerVacaProg.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetProgVacaGrupal(IEntityBase value);

   }
   
   /// <summary>
   /// Business Object para Consultas a la Tabla: RH_PerVacaProg (RH_PerVacaProg)
   /// </summary>
   public class PerVacaProg : BusinessObjectBase, IBOQuery, IPerVacaProg
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaProg();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaProg();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaProg();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaProg();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PerVacaProg();

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

      #region IPerVacaProg Members

      public DataTable GetProcesosXRangoFecha(IEntityBase value)
      {

         RHDOQry.PerVacaProg objData = new RHDOQry.PerVacaProg();

         try
         {

            DataTable dt = objData.GetProcesosXRangoFecha(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetProgVacaGrupal(IEntityBase value)
      {

         RHDOQry.PerVacaProg objData = new RHDOQry.PerVacaProg();

         try
         {

            DataTable dt = objData.GetProgVacaGrupal(value);

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
