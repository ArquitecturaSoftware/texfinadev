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
   /// Business Object para Mantenimiento a la Tabla: RH_DiaDescanso (RH_DiaDescanso)
   /// </summary>
   public class DiaDescanso : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EDiaDescansoSet objE = (EDiaDescansoSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               //this.DeleteDetail(objE.EDiaDescanso, true);

               //objRet = this.UpdateMaster(objE.EDiaDescanso);
               this.UpdateDetail(objE.ColDiaDescanso, objRet);

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

         EDiaDescansoSet objE = (EDiaDescansoSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColDiaDescanso, false);
               //this.DeleteMaster(objE.EDiaDescanso);

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

      private object[] UpdateMaster(EDiaDescanso entity)
      {

         IDOUpdate objDO = new RHDOMnt.DiaDescanso();

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

      private void UpdateDetail(IList<EDiaDescanso> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.DiaDescanso();

         foreach (EDiaDescanso objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdPeriodo = primKey[0].ToString();
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

      private void DeleteMaster(EDiaDescanso entity)
      {

         IDOUpdate objDO = new RHDOMnt.DiaDescanso();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EDiaDescanso> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.DiaDescanso();
         IEnumerable<EDiaDescanso> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<EDiaDescanso>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<EDiaDescanso>)deleteItems;
         }
         foreach (EDiaDescanso objE in colSel)
            objDO.Delete(objE);

      }

   }
}
