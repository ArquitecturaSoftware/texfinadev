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
    /// Business Object para Mantenimiento a la Tabla: RH_Subsidio (RH_Subsidio)
    /// </summary>
    public class Subsidio : BusinessObjectBase, IBOUpdate
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            ESubsidio objE = (ESubsidio)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    //this.DeleteDetail(objE.ESubsidio, true);

                    objRet = this.UpdateMaster(objE);
                    //this.UpdateDetail(objE.ESubsidio, objRet);

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

            ESubsidio objE = (ESubsidio)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    //this.DeleteDetail(objE.ESubsidio, false);
                    this.DeleteMaster(objE);

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

        private object[] UpdateMaster(ESubsidio entity)
        {

            IDOUpdate objDO = new RHDOMnt.Subsidio();

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

        private void UpdateDetail(IList<ESubsidio> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.Subsidio();

            foreach (ESubsidio objE in col)
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

        private void DeleteMaster(ESubsidio entity)
        {

            IDOUpdate objDO = new RHDOMnt.Subsidio();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(IList<ESubsidio> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.Subsidio();
            IEnumerable<ESubsidio> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<ESubsidio>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<ESubsidio>)deleteItems;
            }
            foreach (ESubsidio objE in colSel)
                objDO.Delete(objE);

        }

    }
}
