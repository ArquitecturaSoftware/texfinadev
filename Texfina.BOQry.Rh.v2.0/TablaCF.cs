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
   public interface ITablaCF
   {
      /// <summary>
      /// Recupera la lista de campos dispobibles por seccion
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetCamposXSeccion(IEntityBase value);
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Campos disponibles en el Editor de Formulas (RH_TablaCF)
   /// </summary>
   public class TablaCF : BusinessObjectBase, IBOQuery, ITablaCF
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaCF();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaCF();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaCF();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaCF();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaCF();

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

      #region ITablaCF Members

      public DataTable GetCamposXSeccion(IEntityBase value)
      {
         RHDOQry.TablaCFDet objData = new RHDOQry.TablaCFDet();

         try
         {

            DataTable dt = objData.GetCamposXSeccion(value);

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
