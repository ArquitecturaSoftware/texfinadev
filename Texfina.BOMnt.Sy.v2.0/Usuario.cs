using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Sy;
using Texfina.Core.Common;
using SYDOMnt = Texfina.DOMnt.Sy;

namespace Texfina.BOMnt.Sy
{
   /// <summary>
   /// Business Object para mantenimiento a la Tabla SY_Usuario
   /// </summary>
   /// <remarks></remarks>
   public class Usuario : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EUsuarioSet objE = (EUsuarioSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.Usuario);

               objRet = this.UpdateMaster(objE.Usuario);
               this.UpdateDetail(objE.UsuMenu, objRet);

               tx.Complete();

            }

            if (objRet == null)
               return null;

            return new String[] { objRet[0].ToString() };

         }
         catch (Exception ex)
         {

            throw ex;

         }
      }

      public int DeleteData(IEntityBase value)
      {

         EUsuarioSet objE = (EUsuarioSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.Usuario);
               this.DeleteMaster(objE.Usuario);

               tx.Complete();

            }

            return 1;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      #endregion

      private object[] UpdateMaster(EUsuario entity)
      {

         IDOUpdate objDO = new SYDOMnt.Usuario();

         if (entity.EntityState == EntityState.Unchanged)
            return null;

         object[] objRet = null;

         switch (entity.EntityState)
         {

            case EntityState.Added:
               objRet = objDO.Insert(entity);
               break;

            case EntityState.Modified:
               if (entity.StAnulado == ConstFlagEstado.DESACTIVADO)
                  objDO.Update(entity);
               else
                  objDO.Delete(entity);
               break;

            case EntityState.Deleted:
               objDO.Delete(entity);
               break;

         }

         return objRet;
      }

      private void UpdateDetail(IList<EUsuMenu> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new SYDOMnt.UsuMenu();

         foreach (EUsuMenu objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
               objE.IdUser = primKey[0].ToString();

            objRet = objDO.Insert(objE);
         }

      }

      private void DeleteMaster(EUsuario entity)
      {

         IDOUpdate objDO = new SYDOMnt.Usuario();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(EUsuario entity)
      {

         IDOUpdate objDO = new SYDOMnt.UsuMenu();
         EUsuMenu objE = new EUsuMenu();

         objE.IdUser = entity.IdUser;

         objDO.Delete(objE);

      }

   }
}