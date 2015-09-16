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
   public interface IPeriodoPlani
   {
      /// <summary>
      /// Obtiene los registro de la tabla RH_ConRemuDet, por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetByRowMax(IEntityBase value);

      /// <summary>
      /// Obtiene los registro de la tabla RH_ConRemuDet, por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByXPersonal(IEntityBase value);

   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: RH_PeriodoPlani (RH_PeriodoPlani)
   /// </summary>
   public class PeriodoPlani : BusinessObjectBase, IBOQuery, IPeriodoPlani
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PeriodoPlani();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PeriodoPlani();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PeriodoPlani();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PeriodoPlani();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.PeriodoPlani();

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

      #region IPeriodoPlani Members

      public IEntityBase GetByRowMax(IEntityBase value)
      {

         RHDOQry.PeriodoPlani objData = new RHDOQry.PeriodoPlani();

         try
         {

            IEntityBase objE = objData.GetByRowMax(value);

            return objE;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByXPersonal(IEntityBase value)
      {

         RHDOQry.PeriodoPlani objData = new RHDOQry.PeriodoPlani();

         try
         {

            DataTable dt = objData.GetByXPersonal(value);

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
