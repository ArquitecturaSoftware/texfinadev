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
   /// Business Object para Mantenimiento a la Tabla: Concepto de Remuneracion (RH_ConcepRemu)
   /// </summary>
   public class ConcepRemu : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EConRemuSet objE = (EConRemuSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetailB(objE.ConcepRemu);
               this.DeleteDetail(objE.ConRemuDet, true);

               objRet = this.UpdateMaster(objE.ConcepRemu);
               this.UpdateDetail(objE.ConRemuDet, objRet);
               this.UpdateDetailB(objE.ConRemuCampo, objRet);

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

         EConRemuSet objE = (EConRemuSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetailB(objE.ConcepRemu);
               this.DeleteDetail(objE.ConRemuDet, false);
               this.DeleteMaster(objE.ConcepRemu);

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

      private object[] UpdateMaster(EConcepRemu entity)
      {

         IDOUpdate objDO = new RHDOMnt.ConcepRemu();

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

      private void UpdateDetail(IList<EConRemuDet> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ConRemuDet();

         foreach (EConRemuDet objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdConRemu = primKey[0].ToString();
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

      private void UpdateDetailB(IList<EConRemuCampo> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ConRemuCampo();

         foreach (EConRemuCampo objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdConremu = primKey[0].ToString();
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
      private void DeleteMaster(EConcepRemu entity)
      {

         IDOUpdate objDO = new RHDOMnt.ConcepRemu();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EConRemuDet> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ConRemuDet();
         IEnumerable<EConRemuDet> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<EConRemuDet>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<EConRemuDet>)deleteItems;
         }
         foreach (EConRemuDet objE in colSel)
            objDO.Delete(objE);
      }

      private void DeleteDetailB(EConcepRemu entity)
      {

         IDOUpdate objDO = new RHDOMnt.ConRemuCampo();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         EConRemuCampo objE = new EConRemuCampo();
         objE.IdEmpresa = entity.IdEmpresa;
         objE.IdConremu = entity.IdConRemu;

         objDO.Delete(objE);

      }


   }
}
