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
using System.ServiceModel;

namespace Texfina.BOMnt.Rh
{

    /// <summary>
    /// Interface para Consultas personalizadas a la Tabla: RH_PlanillaDet (RH_PlanillaDet)
    /// </summary>
    [ServiceContract()]
    public interface IProcPlaHora
    {
        /// <summary>
        /// Obtiene las registro de la tabla RH_PlanillaDet, por su llave padre.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un DataTable</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        void ExportarVacaciones(IEntityBase value);
    }
    /// <summary>
    /// Business Object para Mantenimiento a la Tabla: RH_ProcPlaHora (RH_ProcPlaHora)
    /// </summary>
    public class ProcPlaHora : BusinessObjectBase, IBOUpdate, IProcPlaHora
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            EProcPlaHoraSet objE = (EProcPlaHoraSet)value;
            object[] objRet = null;
            string strRet = "";

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.EProcPlaHora, true);
                    strRet = this.UpdateDetail(objE.EProcPlaHora, objRet);

                    tx.Complete();
                }

                if (strRet == null || strRet == "")
                    return null;

                return new String[] { strRet };

            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public int DeleteData(IEntityBase value)
        {

            EProcPlaHoraSet objE = (EProcPlaHoraSet)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetail(objE.EProcPlaHora, false);
                    //this.DeleteMaster(objE.EProcPlaHora);

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

        private object[] UpdateMaster(EProcPlaHora entity)
        {

            IDOUpdate objDO = new RHDOMnt.ProcPlaHora();

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

        private string UpdateDetail(IList<EProcPlaHora> col, object[] primKey)
        {

            if (col == null)
                return "";

            IDOUpdate objDO = new RHDOMnt.ProcPlaHora();
            string strRet = "";

            string idPerson = "";

            foreach (EProcPlaHora objE in col)
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
                        if (int.Parse(objRet[0].ToString()) < 1)
                            if (objE.IdPersonal != idPerson && idPerson != "")
                                strRet += objE.IdPersonal + "\n";
                        break;

                    case EntityState.Modified:
                        if (objE.StAnulado == ConstFlagEstado.DESACTIVADO)
                            objDO.Update(objE);
                        else
                            objDO.Delete(objE);
                        break;

                }

                idPerson = objE.IdPersonal;
            }

            return strRet;
        }

        private void DeleteMaster(EProcPlaHora entity)
        {

            IDOUpdate objDO = new RHDOMnt.ProcPlaHora();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(IList<EProcPlaHora> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.ProcPlaHora();
            IEnumerable<EProcPlaHora> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EProcPlaHora>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EProcPlaHora>)deleteItems;
            }
            foreach (EProcPlaHora objE in colSel)
                objDO.Delete(objE);

        }

        public void ExportarVacaciones(IEntityBase entity)
        {
            RHDOMnt.ProcPlaHora objDO = new RHDOMnt.ProcPlaHora();
            objDO.ExportarVacaciones(entity);
        }

    }
}
