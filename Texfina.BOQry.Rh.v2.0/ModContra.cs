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
   /// Interface para Consultas personalizadas a la Tabla: RH_ModContra (RH_ModContra)
   /// </summary>
   [ServiceContract()]
   public interface IModContra
   {
      /// <summary>
      /// Obtiene las registro de la tabla RH_ModContraDet, por su llave padre.
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetDetailByParentKey(IEntityBase value);
      
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: RH_ModContra (RH_ModContra)
   /// </summary>
   public class ModContra : BusinessObjectBase, IBOQuery, IModContra
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.ModContra();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ModContra();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ModContra();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ModContra();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.ModContra();

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

      #region IModalidadContra Members

      public DataTable GetDetailByParentKey(IEntityBase value)
         {

            IDOQuery objData = (IDOQuery)new RHDOQry.ModContraDet();

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

      #endregion

   }
}
