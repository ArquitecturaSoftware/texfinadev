using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Co;
using Texfina.Core.Common;
using System.ServiceModel;
using CODOMnt = Texfina.DOMnt.Co;

namespace Texfina.BOMnt.Co
{


    /// <summary>
    /// Business Object para Mantenimiento a la Tabla: Personal (RH_Personal)
    /// </summary>/// 
    public class BienFiscaEstable : BusinessObjectBase, IBOUpdate
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            EBienFiscaEstableSet objE = (EBienFiscaEstableSet)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    //this.DeleteDetail(objE.EBienFiscaEstable, true);

                    objRet = this.UpdateMaster(objE.BienFiscaEstable);
                    //this.UpdateDetail(objE.EBienFiscaEstable, objRet);

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

            EBienFiscaEstableSet objE = (EBienFiscaEstableSet)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    //this.DeleteDetail(objE.EBienFiscaEstable, false);
                    this.DeleteMaster(objE.BienFiscaEstable);

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

        private object[] UpdateMaster(EBienFiscaEstable entity)
        {

            IDOUpdate objDO = new CODOMnt.BienFiscaEstable();

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

        private void UpdateDetail(IList<EBienFiscaEstable> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new CODOMnt.BienFiscaEstable();

            foreach (EBienFiscaEstable objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
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

        private void DeleteMaster(EBienFiscaEstable entity)
        {

            IDOUpdate objDO = new CODOMnt.BienFiscaEstable();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(IList<EBienFiscaEstable> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new CODOMnt.BienFiscaEstable();
            IEnumerable<EBienFiscaEstable> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EBienFiscaEstable>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EBienFiscaEstable>)deleteItems;
            }
            foreach (EBienFiscaEstable objE in colSel)
                objDO.Delete(objE);

        }

    }

}
