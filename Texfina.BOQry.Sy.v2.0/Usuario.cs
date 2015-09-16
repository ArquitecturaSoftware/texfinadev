using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using Texfina.Core.Common;
using Texfina.Entity.Sy;
using SYDOQry = Texfina.DOQry.Sy;

namespace Texfina.BOQry.Sy
{
   /// <summary>
   /// Interface para Consultas personalizadas
   /// </summary>
   [ServiceContract()]
   public interface IUsuario
   {
      /// <summary>
      /// Verifica si el Usuario es Administrador
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      bool EsAdministrador(IEntityBase value);

      /// <summary>
      /// Recupera el Menu asignado para el Usuario
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetMenuAsignado(IEntityBase value);

      /// <summary>
      ///Recupera el Menu y sus Derechos, para configurarlo
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetConfigMenu(IEntityBase value);

   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Usuario (SY_Usuario)
   /// </summary>
   /// 
   public class Usuario : BusinessObjectBase, IBOQuery, IUsuario
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new SYDOQry.Usuario();

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

         IDOQuery objData = (IDOQuery)new SYDOQry.Usuario();

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

         IDOQuery objData = (IDOQuery)new SYDOQry.Usuario();

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

         IDOQuery objData = (IDOQuery)new SYDOQry.Usuario();

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

         IDOQuery objData = (IDOQuery)new SYDOQry.Usuario();

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

      #region IUsuario Members
      public bool EsAdministrador(IEntityBase value)
      {
         IDOQuery objData = (IDOQuery)new SYDOQry.UsuGrupo();
         EUsuario objE = (EUsuario)value;

         try
         {

            EUsuGrupo objUsrGrp = new EUsuGrupo();

            objUsrGrp.IdUsuario = objE.IdUser;
            objUsrGrp.IdGrupo = ConstSeguridadGrupo.ADMINS;
            bool blnRes = objData.Exists(objUsrGrp);

            return blnRes;

         }
         catch (Exception ex)
         {

            throw ex;

         }
      }




      public DataTable GetMenuAsignado(IEntityBase value)
      {
         SYDOQry.UsuMenu objData = new SYDOQry.UsuMenu();

         try
         {

            DataTable dt = objData.GetMenuAsignado(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }
      }

      public DataTable GetConfigMenu(IEntityBase value)
      {
         SYDOQry.UsuMenu objData = new SYDOQry.UsuMenu();

         try
         {

            DataTable dt = objData.GetConfigMenu(value);

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