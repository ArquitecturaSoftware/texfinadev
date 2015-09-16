﻿using System;
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
   public interface ITablaGen
   {

      [OperationContract()]
      [NetDataContract()]
      DataTable GetDetailByList(IEntityBase value);

      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetDetailByKey(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de la tabla MG_TablaGenDet, por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyTablaGenDet(IEntityBase value);


   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Tabla General (MG_TablaGen)
   /// </summary>
   public class TablaGen : BusinessObjectBase, IBOQuery,ITablaGen
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGen();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGen();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGen();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGen();

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

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGen();

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

      #region ITablaGen Members


      public DataTable GetDetailByList(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGenDet();

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

      public IEntityBase GetDetailByKey(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGenDet();

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


      public DataTable GetByParentKeyTablaGenDet(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new MGDOQry.TablaGenDet();

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