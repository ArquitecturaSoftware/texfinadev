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
    /// Business Object para Mantenimiento a la Tabla: Planilla (RH_Planilla)
    /// </summary>
    public class Planilla : BusinessObjectBase, IBOUpdate
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            EPlanillaSet objE = (EPlanillaSet)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.ColPlanilla , true);

                    objRet = this.UpdateMaster(objE.Planilla);
                    this.UpdateDetail(objE.ColPlanilla, objRet);

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

            EPlanillaSet objE = (EPlanillaSet)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.ColPlanilla, false);
                    this.DeleteMaster(objE.Planilla);

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

        private object[] UpdateMaster(EPlanilla entity)
        {

            IDOUpdate objDO = new RHDOMnt.Planilla();

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

        private void UpdateDetail(IList<EPlanillaDet> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PlanillaDet();

            foreach (EPlanillaDet objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPlanilla = primKey[0].ToString();
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

        private void DeleteMaster(EPlanilla entity)
        {

            IDOUpdate objDO = new RHDOMnt.Planilla();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(IList<EPlanillaDet> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PlanillaDet();
            IEnumerable<EPlanillaDet> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPlanillaDet>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPlanillaDet>)deleteItems;
            }
            foreach (EPlanillaDet objE in colSel)
                objDO.Delete(objE);

        }

    }
}
