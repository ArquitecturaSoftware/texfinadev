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
   public interface IUNegocio
   {

      [OperationContract()]
      [NetDataContract()]
      DataTable GetCCostoXUNegocio(IEntityBase value);
         
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: MG_UNegocio (MG_UNegocio)
   /// </summary>
   public class UNegocio : BusinessObjectBase, IBOQuery, IUNegocio
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new MGDOQry.UNegocio();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.UNegocio();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.UNegocio();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.UNegocio();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.UNegocio();

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


      #region IUNegocio Members
      
      public DataTable GetCCostoXUNegocio(IEntityBase value)
      {

         MGDOQry.UNegocio objData = new MGDOQry.UNegocio();

         try
         {

            DataTable dt = objData.GetCCostoXUNegocio(value);

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
