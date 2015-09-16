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
    /// Business Object para Consultas a la Tabla: Afp (RH_Afp)
    /// </summary>
    [ServiceContract()]
    public interface IAfp
    {
        [OperationContract()]
        [NetDataContract()]
        DataTable GetByParentKeyAfpComi(IEntityBase value);

    }
   /// <summary>
   /// Business Object para Consultas a la Tabla: Afp (RH_Afp)
   /// </summary>
    public class Afp : BusinessObjectBase, IBOQuery, IAfp 

   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Afp();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Afp();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Afp();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Afp();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Afp();

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

      #region IAfp Members

      public DataTable GetByParentKeyAfpComi(IEntityBase value)
      {

          IDOQuery objData = (IDOQuery)new RHDOQry.AfpComi();

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
