using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Rh;
using Texfina.Core.Common;
using RHDOMnt = Texfina.DOMnt.Rh;

namespace Texfina.BOMnt.Rh
{
   /// <summary>
   /// Business Object para Mantenimiento a la Tabla: Hora (RH_Hora)
   /// </summary>
   public class Hora : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EHoraSet objE = (EHoraSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColHora, true);
              // objRet = this.UpdateMaster(objE.EHora);
               this.UpdateDetail(objE.ColHora, objRet);

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

         EHoraSet objE = (EHoraSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColHora, false);
               //this.DeleteMaster(objE.EHora);

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

      private object[] UpdateMaster(EHora entity)
      {

         IDOUpdate objDO = new RHDOMnt.Hora();

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

      private void UpdateDetail(IList<EHora> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.Hora();

         foreach (EHora objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdHora = primKey[0].ToString();
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

      private void DeleteMaster(EHora entity)
      {

         IDOUpdate objDO = new RHDOMnt.Hora();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EHora> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.Hora();
         IEnumerable<EHora> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<EHora>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<EHora>)deleteItems;
         }
         foreach (EHora objE in colSel)
            objDO.Delete(objE);

      }

   }
}
