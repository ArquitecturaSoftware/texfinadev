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
   public interface ITablaVC
   {
      /// <summary>
      /// Obtiene las Tablas de acuerdo su visibilidad (VA o SM)
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetListXVisibleEn(IEntityBase value);

      /// <summary>
      /// Obtiene los Acumuladores
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetAcumuladores(IEntityBase value);

      /// <summary>
      /// Obtiene los Campos por Acumulador
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetAcumuladorColumnas(IEntityBase value);
 
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Tabla Origen para la Variable de Calculo (RH_TablaVC)
   /// </summary>
   public class TablaVC : BusinessObjectBase, IBOQuery, ITablaVC
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaVC();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaVC();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaVC();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaVC();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.TablaVC();

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

      #region ITablaVC Members

      public DataTable GetListXVisibleEn(IEntityBase value)
      {
         RHDOQry.TablaVC objData = new RHDOQry.TablaVC();

         try
         {

            DataTable dt = objData.GetListXVisibleEn(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetAcumuladores(IEntityBase value)
      {
         IDOQuery objData = (IDOQuery) new RHDOQry.TablaVCAcum();

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

      public DataTable GetAcumuladorColumnas(IEntityBase value)
      {
         IDOQuery objData = (IDOQuery)new RHDOQry.TablaVCAcumDet();

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

      #endregion
   }
}