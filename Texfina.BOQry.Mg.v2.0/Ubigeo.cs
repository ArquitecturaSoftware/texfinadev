using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using MGDOQry = Texfina.DOQry.Mg;



namespace Texfina.BOQry.Mg
{

   /// <summary>
   /// Business Object para Consultas a la Tabla: Ubigeo (MG_Ubigeo)
   /// </summary>
   [ServiceContract()]
   public interface IUbigeo
   {

   [OperationContract()]
   [NetDataContract()]
   DataTable GetDsUbigeoByCriteria(IEntityBase value);

   [OperationContract()]
   [NetDataContract()]
   DataTable GetDsUbigeoByKey(IEntityBase value); 
   
   }
   
   /// <summary>
   /// Business Object para Consultas a la Tabla: Ubigeo (MG_Ubigeo)
   /// </summary>
   public class Ubigeo : BusinessObjectBase, IBOQuery,IUbigeo 
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new MGDOQry.Ubigeo();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.Ubigeo();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.Ubigeo();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.Ubigeo();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.Ubigeo();

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

      #region IUbigeo Members

      public DataTable GetDsUbigeoByCriteria(IEntityBase value)
      {

         MGDOQry.Ubigeo objData = new MGDOQry.Ubigeo();

         try
         {

            DataTable dt = objData.GetDsUbigeoByCriteria(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetDsUbigeoByKey(IEntityBase value)
      {

         MGDOQry.Ubigeo objData = new MGDOQry.Ubigeo();

         try
         {

            DataTable dt = objData.GetDsUbigeoByKey(value);

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
