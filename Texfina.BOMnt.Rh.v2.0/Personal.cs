using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Rh;
using Texfina.Entity.Mg;
using Texfina.Core.Common;
using RHDOQry = Texfina.DOQry.Rh;
using RHDOMnt = Texfina.DOMnt.Rh;
using MGDOMnt = Texfina.DOMnt.Mg;
using System.ServiceModel;
using Texfina.Common.Mg;

namespace Texfina.BOMnt.Rh
{

    /// <summary>
    /// Interface para Consultas personalizadas a la Tabla: RH_PerContrato
    /// </summary>
    [ServiceContract()]
    public interface IPersonal
    {
        /// <summary>
        /// Graba y actualiza los contratos de forma masiva.
        /// </summary>
        /// <param name="value">Entidad base</param>
        /// <returns>Retorna un array de tipo string</returns>
        /// 
        [OperationContract()]
        [NetDataContract()]
        string[] UpdateDataPerContrato(IEntityBase value);

    }

    /// <summary>
    /// Business Object para Mantenimiento a la Tabla: Personal (RH_Personal)
    /// </summary>
    public class Personal : BusinessObjectBase, IBOUpdate, IPersonal
    {

        #region IBOUpdate Members

        public string[] UpdateData(IEntityBase value)
        {

            EPersonalSet objE = (EPersonalSet)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.DeleteDetailD(objE.ColPerPlanilla, true);
                    this.DeleteDetailB(objE.ColPerContrato, true);
                    this.DeleteDetail(objE.ColPerDepen, true);
                    this.DeleteDetailE(objE.ColPerExpeLabo, true);
                    this.DeleteDetailF(objE.ColPerEducacion, true);
                    this.DeleteDetailG(objE.ColPerRemu, true);

                    objRet = this.UpdateMasterB(objE.CliProv);
                    if (objRet != null)
                        objE.Personal.IdCliProv = objRet[0].ToString();
                    objRet = this.UpdateMaster(objE.Personal);

                    this.UpdateDetail(objE.ColPerDepen, objRet);
                    this.UpdateDetailB(objE.ColPerContrato, objRet);
                    this.UpdateDetailC(objE.PerFoto, objRet);
                    this.UpdateDetailD(objE.ColPerPlanilla, objRet);
                    this.UpdateDetailE(objE.ColPerExpeLabo, objRet);
                    this.UpdateDetailF(objE.ColPerEducacion, objRet);
                    this.UpdateDetailG(objE.ColPerRemu, objRet);
                    this.UpdateDetailH(objE.HistoAprob, objRet);
                    this.UpdateDetailI(objE.ColContraArch, objRet);
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

            EPersonalSet objE = (EPersonalSet)value;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {
                    this.DeleteDetailB(objE.ColPerContrato, true);
                    this.DeleteDetail(objE.ColPerDepen, true);
                    this.UpdateMasterB(objE.CliProv);
                    this.UpdateMaster(objE.Personal);
                    this.DeleteDetailE(objE.ColPerExpeLabo, true);
                    this.DeleteDetailF(objE.ColPerEducacion, true);
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

        #region IPersonal Members

        public string[] UpdateDataPerContrato(IEntityBase value)
        {

            EPersonalSet objE = (EPersonalSet)value;
            object[] objRet = null;

            try
            {

                using (TransactionScope tx = new TransactionScope())
                {

                    this.UpdateDetailB(objE.ColPerContrato, objRet);
                    IDOUpdate objDO = new RHDOMnt.PerContrato();
                    RHDOQry.PerContrato objEPC = new RHDOQry.PerContrato();

                    foreach (EPerContrato colobjE in objE.ColPerContrato)
                    {
                        EPerContrato colobjENew = new EPerContrato();
                        colobjE.NuSecuen = colobjE.NuSecuen - 1;
                        colobjENew = (EPerContrato)objEPC.GetByKey(colobjE);
                        if (colobjENew != null)
                        {
                            colobjENew.StContrato = ConstFlagEstado.ACTIVADO;
                            colobjENew.IdMotivFin = ConstMotivoCese.TERMINO;
                            objDO.Update(colobjENew);
                        }

                    }

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

        #endregion


        private object[] UpdateMaster(EPersonal entity)
        {
            if (entity == null)
                return null;

            IDOUpdate objDO = new RHDOMnt.Personal();

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


        private object[] UpdateMasterB(ECliProv entity)
        {
            if (entity == null)
                return null;

            IDOUpdate objDO = new MGDOMnt.CliProv();

            if (entity.EntityState == EntityState.Unchanged)
                return null;

            object[] objRet = null;

            switch (entity.EntityState)
            {

                case EntityState.Added:
                    objRet = objDO.Insert(entity);
                    break;

                case EntityState.Modified:
                    if (entity.StRegSis == ConstFlagEstado.DESACTIVADO)
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

        private void UpdateDetail(IList<EPerDepen> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerDepen();

            foreach (EPerDepen objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
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

        private void UpdateDetailB(IList<EPerContrato> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerContrato();
            RHDOMnt.Personal objDOPer = new RHDOMnt.Personal();
            EPersonal NewEPersonal = new EPersonal();

            foreach (EPerContrato objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
                }

                switch (objE.EntityState)
                {

                    case EntityState.Added:
                        objRet = objDO.Insert(objE);


                        NewEPersonal.IdEmpresa = objE.IdEmpresa;
                        NewEPersonal.IdPersonal = objE.IdPersonal;
                        NewEPersonal.IdSituEmple = ConstSituacionEmpleado.ACTIVO_SUBSIDIADO;
                        NewEPersonal.IdMotivFin = "";
                        NewEPersonal.FeCese = null;
                        if (objE.StProrroga == ConstFlagEstado.ACTIVADO)
                        {
                            NewEPersonal.FeIngpla = null;
                        }
                        else
                        {
                            NewEPersonal.FeIngpla = objE.FeInicio;
                        }

                        objDOPer.UpdateEstadoFechaCese(NewEPersonal);


                        break;

                    case EntityState.Modified:
                        if (objE.StAnulado == ConstFlagEstado.DESACTIVADO)
                            objDO.Update(objE);
                        if (objE.StContrato == ConstFlagEstado.ACTIVADO)
                        {

                            NewEPersonal.IdEmpresa = objE.IdEmpresa;
                            NewEPersonal.IdPersonal = objE.IdPersonal;
                            NewEPersonal.IdSituEmple = ConstSituacionEmpleado.BAJA;
                            NewEPersonal.FeCese = objE.FeCese;
                            NewEPersonal.FeIngpla = null;
                            NewEPersonal.IdMotivFin = objE.IdMotivFin;
                            objDOPer.UpdateEstadoFechaCese(NewEPersonal);
                        }
                        else
                            objDO.Delete(objE);
                        break;

                }

            }

        }

        private void UpdateDetailC(EPerFoto objE, object[] primKey)
        {

            if (objE == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerFoto();

            object[] objRet = null;

            if (primKey != null)
            {
                objE.IdPersonal = primKey[0].ToString();
            }

            switch (objE.EntityState)
            {

                case EntityState.Added:
                    objRet = objDO.Insert(objE);
                    break;

                case EntityState.Modified:
                    objDO.Update(objE);
                    break;
            }

        }

        private void UpdateDetailD(IList<EPerPlanilla> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerPlanilla();

            foreach (EPerPlanilla objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
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

        private void UpdateDetailE(IList<EPerExpeLabo> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerExpeLabo();


            foreach (EPerExpeLabo objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
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

        private void UpdateDetailF(IList<EPerEducacion> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerEducacion();


            foreach (EPerEducacion objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
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

        private void UpdateDetailG(IList<EPerRemu> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerRemu();


            foreach (EPerRemu objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
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

        private void UpdateDetailH(EPerHistoAprob entity, object[] primKey)
        {

            if (entity == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerHistoAprob();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            object[] objRet = null;

            if (primKey != null)
            {
                entity.IdPersonal = primKey[0].ToString();
            }

            switch (entity.EntityState)
            {

                case EntityState.Added:

                    objRet = objDO.Insert(entity);
                    break;

                case EntityState.Modified:
                    objDO.Update(entity);
                    break;

                case EntityState.Deleted:
                    objDO.Delete(entity);
                    break;

            }

        }

        private void UpdateDetailI(IList<EPerContraArch> col, object[] primKey)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerContraArch();


            foreach (EPerContraArch objE in col)
            {

                object[] objRet = null;

                if (primKey != null)
                {
                    objE.IdPersonal = primKey[0].ToString();
                }

                switch (objE.EntityState)
                {

                    case EntityState.Added:
                        objRet = objDO.Insert(objE);
                        break;

                    case EntityState.Modified:
                        objDO.Update(objE);
                        break;
                }

            }

        }

        private void DeleteMaster(EPersonal entity)
        {

            IDOUpdate objDO = new RHDOMnt.Personal();

            if (entity.EntityState == EntityState.Unchanged)
                return;

            objDO.Delete(entity);

        }

        private void DeleteDetail(IList<EPerDepen> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerDepen();
            IEnumerable<EPerDepen> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerDepen>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerDepen>)deleteItems;
            }
            foreach (EPerDepen objE in colSel)
                objDO.Delete(objE);

        }

        private void DeleteDetailB(IList<EPerContrato> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerContrato();
            IEnumerable<EPerContrato> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerContrato>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerContrato>)deleteItems;
            }
            foreach (EPerContrato objE in colSel)
                objDO.Delete(objE);

        }

        private void DeleteDetailD(IList<EPerPlanilla> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerPlanilla();
            IEnumerable<EPerPlanilla> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerPlanilla>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerPlanilla>)deleteItems;
            }
            foreach (EPerPlanilla objE in colSel)
                objDO.Delete(objE);

        }

        private void DeleteDetailE(IList<EPerExpeLabo> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerExpeLabo();
            IEnumerable<EPerExpeLabo> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerExpeLabo>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerExpeLabo>)deleteItems;
            }
            foreach (EPerExpeLabo objE in colSel)
                objDO.Delete(objE);

        }

        private void DeleteDetailF(IList<EPerEducacion> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerEducacion();
            IEnumerable<EPerEducacion> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerEducacion>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerEducacion>)deleteItems;
            }
            foreach (EPerEducacion objE in colSel)
                objDO.Delete(objE);

        }

        private void DeleteDetailG(IList<EPerRemu> col, bool filterModified)
        {

            if (col == null)
                return;

            IDOUpdate objDO = new RHDOMnt.PerRemu();
            IEnumerable<EPerRemu> colSel = null;

            if (filterModified)
            {
                var deleteItems = from itm in col
                                  where itm.EntityState == EntityState.Deleted
                                  select itm;

                colSel = (IEnumerable<EPerRemu>)deleteItems;
            }
            else
            {
                var deleteItems = from itm in col
                                  select itm;

                colSel = (IEnumerable<EPerRemu>)deleteItems;
            }
            foreach (EPerRemu objE in colSel)
                objDO.Delete(objE);

        }
    }
}
