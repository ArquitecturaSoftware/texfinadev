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
   /// Business Object para Mantenimiento a la Tabla: RH_VarCalc (RH_VarCalc)
   /// </summary>
   public class VarCalc : BusinessObjectBase, IBOUpdate
   {

      #region IBOUpdate Members

      public string[] UpdateData(IEntityBase value)
      {

         EVarCalcSet objE = (EVarCalcSet)value;
         object[] objRet = null;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.VarCalc, false);

               objRet = this.UpdateMaster(objE.VarCalc);

               this.UpdateDetail(objE.VarCalcDet, objRet);

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

         EVarCalcSet objE = (EVarCalcSet)value;

         try
         {

            using (TransactionScope tx = new TransactionScope())
            {

               this.DeleteDetail(objE.VarCalc, false);
               this.DeleteMaster(objE.VarCalc);

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

      private object[] UpdateMaster(EVarCalc entity)
      {

         IDOUpdate objDO = new RHDOMnt.VarCalc();

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

      private void UpdateDetail(IList<EVarCalcDet> col, object[] primKey)
      {

         if (col == null)
            return;

         IDOUpdate objDO = new RHDOMnt.VarCalcDet();

         foreach (EVarCalcDet objE in col)
         {

            object[] objRet = null;

            if (primKey != null)
            {
               objE.IdVarCalc = primKey[0].ToString();
            }

            switch (objE.EntityState)
            {

               case EntityState.Added:
                  objRet = objDO.Insert(objE);
                  break;

            }

         }

      }

      private void DeleteMaster(EVarCalc entity)
      {

         IDOUpdate objDO = new RHDOMnt.VarCalc();

         if (entity.EntityState == EntityState.Unchanged)
            return;

         objDO.Delete(entity);

      }

      private void DeleteDetail(EVarCalc entity, bool filterModified)
      {

         if (entity == null)
            return;

         IDOUpdate objDO = new RHDOMnt.VarCalcDet();
         EVarCalcDet objE = new EVarCalcDet();
         objE.IdVarCalc = entity.IdVarCalc;
         objDO.Delete(objE);

      }

   }
}