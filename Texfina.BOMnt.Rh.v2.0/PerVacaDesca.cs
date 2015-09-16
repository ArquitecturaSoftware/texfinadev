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
    /// Business Object para Mantenimiento a la Tabla: RH_PerVacaDesca (RH_PerVacaDesca)
    /// </summary>
    public class PerVacaDesca : BusinessObjectBase, IBOUpdate
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            EPerVacaDescaSet objE = (EPerVacaDescaSet)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.ColVacaDescanso, true);

                    objRet = this.UpdateMaster(objE.PerVacaDesca);
                    this.UpdateDetail(objE.ColVacaDescanso, objRet);

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

            EPerVacaDescaSet objE = (EPerVacaDescaSet)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.ColVacaDescanso, false);
                    this.DeleteMaster(objE.PerVacaDesca);

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

        private object[] UpdateMaster(EPerVacaDesca entity)
        {

            IDOUpdate objDO = new RHDOMnt.PerVacaDesca();

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

        private void UpdateDetail(IList<EPerVacaDescaDet> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerVacaDescaDet();

            foreach (EPerVacaDescaDet objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdVacaDesca = primKey[0].ToString();
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

        private void DeleteMaster(EPerVacaDesca entity)
        {

            IDOUpdate objDO = new RHDOMnt.PerVacaDesca();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(IList<EPerVacaDescaDet> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerVacaDescaDet();
            IEnumerable<EPerVacaDescaDet> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerVacaDescaDet>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerVacaDescaDet>)deleteItems;
            }
            foreach (EPerVacaDescaDet objE in colSel)
                objDO.Delete(objE);

        }

    }
}
