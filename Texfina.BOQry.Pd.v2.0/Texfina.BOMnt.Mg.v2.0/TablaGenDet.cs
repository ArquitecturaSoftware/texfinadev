using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Mg;
using Texfina.Core.Common;
using MGDOMnt = Texfina.DOMnt.Mg;

namespace Texfina.BOMnt.Mg
{
   /// <summary>
   /// Business Object para Mantenimiento a la Tabla: Tabla General Detalle (MG_TablaGenDet)
   /// </summary>
   public class TablaGenDet : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         ETablaGenSet objE = (ETablaGenSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               //this.DeleteDetail(objE.ETablaGenDet, true);

               //objRet = this.UpdateMaster(objE.ETablaGenDet);
               //this.UpdateDetail(objE.ETablaGenDet, objRet);

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

         ETablaGenSet objE = (ETablaGenSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               //this.DeleteDetail(objE.ETablaGenDet, false);
               //this.DeleteMaster(objE.ETablaGenDet);

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

      private object[] UpdateMaster(ETablaGenDet entity)
      {

         IDOUpdate objDO = new MGDOMnt.TablaGenDet();

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

      private void UpdateDetail(IList<ETablaGenDet> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new MGDOMnt.TablaGenDet();

         foreach (ETablaGenDet objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdTabla = primKey[0].ToString();
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

      private void DeleteMaster(ETablaGenDet entity)
      {

         IDOUpdate objDO = new MGDOMnt.TablaGenDet();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<ETablaGenDet> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new MGDOMnt.TablaGenDet();
         IEnumerable<ETablaGenDet> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<ETablaGenDet>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<ETablaGenDet>)deleteItems;
         }
         foreach (ETablaGenDet objE in colSel)
            objDO.Delete(objE);

      }

   }
}
