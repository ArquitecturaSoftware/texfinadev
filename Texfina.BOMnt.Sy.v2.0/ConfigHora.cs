using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Sy;
using Texfina.Core.Common;
using SYDOMnt = Texfina.DOMnt.Sy;

namespace Texfina.BOMnt.Sy
{
   /// <summary>
   /// Business Object para Mantenimiento a la Tabla: SY_ConfigHora (SY_ConfigHora)
   /// </summary>
   public class ConfigHora : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EConfigHoraSet objE = (EConfigHoraSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColConfigHora, true);

               //objRet = this.UpdateMaster(objE.EConfigHora);

               this.UpdateDetail(objE.ColConfigHora, objRet);

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

         EConfigHoraSet objE = (EConfigHoraSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColConfigHora, false);
               //this.DeleteMaster(objE.EConfigHora);

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

      private object[] UpdateMaster(EConfigHora entity)
      {

         IDOUpdate objDO = new SYDOMnt.ConfigHora();

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

      private void UpdateDetail(IList<EConfigHora> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new SYDOMnt.ConfigHora();

         foreach (EConfigHora objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdEmpresa = primKey[0].ToString();
            }

            switch (objE.EntityState)
            {

               case EntityState.Added:
                  objRet = objDO.Insert(objE);
                  break;

               case EntityState.Modified:
                  if (objE.StAnulado == ConstFlagEstado.DESACTIVADO)
                     objDO.Update(objE);
                  else
                     objDO.Delete(objE);
                  break;

            }

         }

      }

      private void DeleteMaster(EConfigHora entity)
      {

         IDOUpdate objDO = new SYDOMnt.ConfigHora();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EConfigHora> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new SYDOMnt.ConfigHora();

         //if (filterModified)
         //{
         //   var deleteItems = from itm in col
         //                     where itm.EntityState == EntityState.Deleted
         //                     select itm;

         //   colSel = (IEnumerable<EConfigHora>)deleteItems;
         //}
         //else
         //{
         //   var deleteItems = from itm in col
         //                     select itm;

         //   colSel = (IEnumerable<EConfigHora>)deleteItems;
         //}

         foreach (EConfigHora objE in col)
         {
            objDO.Delete(objE);
            break;
         }

      }

   }
}
