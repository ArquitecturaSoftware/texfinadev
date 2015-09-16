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
using RHDOQry = Texfina.DOQry.Rh;

namespace Texfina.BOMnt.Rh
{
   /// <summary>
   /// Business Object para Mantenimiento a la Tabla: Proceso Planilla Regimen (RH_ProcPlaReg)
   /// </summary>
   public class ProcPlaReg : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EProcPlaRegSet objE = (EProcPlaRegSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.EProcPlaReg, true);

               //objRet = this.UpdateMaster(objE.EProcPlaReg);
               this.UpdateDetail(objE.EProcPlaReg, objRet);

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

         EProcPlaRegSet objE = (EProcPlaRegSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.EProcPlaReg, false);
               //this.DeleteMaster(objE.EProcPlaReg);

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

      private object[] UpdateMaster(EProcPlaReg entity)
      {

         IDOUpdate objDO = new RHDOMnt.ProcPlaReg();

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

      private void UpdateDetail(IList<EProcPlaReg> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ProcPlaReg();
         IDOQuery objDOQry = new RHDOQry.ProcPlaReg();

         foreach (EProcPlaReg objE in col)
         {


            if (objDOQry.Exists(objE))
               objE.EntityState = EntityState.Modified;  
            
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

      private void DeleteMaster(EProcPlaReg entity)
      {

         IDOUpdate objDO = new RHDOMnt.ProcPlaReg();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EProcPlaReg> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.ProcPlaReg();
         IEnumerable<EProcPlaReg> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<EProcPlaReg>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<EProcPlaReg>)deleteItems;
         }
         foreach (EProcPlaReg objE in colSel)
            objDO.Delete(objE);

      }

   }
}
