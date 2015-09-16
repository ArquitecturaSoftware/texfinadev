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
   /// Business Object para Mantenimiento a la Tabla: RH_PerVacaProg (RH_PerVacaProg)
   /// </summary>
   public class PerVacaProg : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EPerVacaSet objE = (EPerVacaSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColVacaProg, true);
               //objRet = this.UpdateMaster(objE.EPerVacaProg);
               this.UpdateDetail(objE.ColVacaProg, objRet);
               this.UpdateDetailB(objE.ColVacaProg, objRet);
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

         EPerVacaSet objE = (EPerVacaSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.ColVacaProg, false);
               //this.DeleteMaster(objE.EPerVacaProg);

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

      private object[] UpdateMaster(EPerVacaProg entity)
      {

         IDOUpdate objDO = new RHDOMnt.PerVacaProg();

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

      private void UpdateDetail(IList<EPerVacaProg> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.PerVacaProg();

         foreach (EPerVacaProg objE in col)
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

      private void UpdateDetailB(IList<EPerVacaProg> col, object[] primKey)
      {

          if (col == null)
              return;

          RHDOMnt.PerVacaProv objDO = new RHDOMnt.PerVacaProv();

          foreach (EPerVacaProg objE in col)
          {
              EPerVacaProv objEProv = new EPerVacaProv();
              objEProv.IdEmpresa = objE.IdEmpresa;
              objEProv.IdPersonal = objE.IdPersonal;
              objEProv.IdPeriVac = objE.IdPeriVac;

              objDO.Update(objEProv);
          }

      }


      private void DeleteMaster(EPerVacaProg entity)
      {

         IDOUpdate objDO = new RHDOMnt.PerVacaProg();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(IList<EPerVacaProg> col, bool filterModified)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.PerVacaProg();
         IEnumerable<EPerVacaProg> colSel = null;

         if (filterModified)
         {
            var deleteItems = from itm in col
                              where itm.EntityState == EntityState.Deleted
                              select itm;

            colSel = (IEnumerable<EPerVacaProg>)deleteItems;
         }
         else
         {
            var deleteItems = from itm in col
                              select itm;

            colSel = (IEnumerable<EPerVacaProg>)deleteItems;
         }
         foreach (EPerVacaProg objE in colSel)
            objDO.Delete(objE);

      }

   }
}
