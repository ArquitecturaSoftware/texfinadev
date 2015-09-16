using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;
using Texfina.Core.Data;
using Texfina.Entity.Sy;
using Texfina.Core.Common;
using SYDOMnt = Texfina.DOMnt.Sy;

namespace Texfina.BOMnt.Sy
{
	/// <summary>
	/// Business Object para mantenimiento a la Tabla SY_Empresa
	/// </summary>
	public class Empresa: BusinessObjectBase,IBOUpdate
	{

		#region IBOUpdate Members

		public string[] UpdateData(IEntityBase value)
		{

			EEmpresaSet objE = (EEmpresaSet) value;
			object[] objRet = null;

			try
			{

				using(TransactionScope tx = new TransactionScope())
				{

					//this.DeleteDetail(objE.Empresa, true);

					objRet = this.UpdateMaster(objE.Empresa);
					//this.UpdateDetail(objE.Empresa, objRet);

					tx.Complete();

				}

			if(objRet == null)
				return null;

			return new String[] { objRet[0].ToString() };

			}
			catch(Exception ex)
			{

				throw ex;

			}
		}

		public int DeleteData(IEntityBase value)
		{

			EEmpresaSet objE = (EEmpresaSet) value;

			try
			{

				using(TransactionScope tx = new TransactionScope())
				{

					//this.DeleteDetail(objE.Empresa, false);
					this.DeleteMaster(objE.Empresa);

					tx.Complete();

				}

			return 1;

			}
			catch(Exception ex)
			{

				throw ex;

			}

		}

		#endregion

		private object[] UpdateMaster(EEmpresa entity)
		{

			IDOUpdate objDO = new SYDOMnt.Empresa();

			if(entity.EntityState == EntityState.Unchanged)
				return null;

			object[] objRet = null;

			switch(entity.EntityState)
			{

				case EntityState.Added:
					objRet = objDO.Insert(entity);
				break;

				case EntityState.Modified:
					if(entity.StAnulado == ConstFlagEstado.DESACTIVADO)
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

		private void UpdateDetail(IList<EEmpresa> col, object[] primKey)
		{

			if(col == null)
				return;

			IDOUpdate objDO = new SYDOMnt.Empresa();

			foreach(EEmpresa objE in col)
			{

				object[] objRet = null;

				if(primKey!=null)
				{
					objE.IdEmpresa = primKey[0].ToString();
				}

				switch(objE.EntityState)
				{

					case EntityState.Added:
						objRet = objDO.Insert(objE);
					break;

					case EntityState.Modified:
						if(objE.StAnulado == ConstFlagEstado.DESACTIVADO)
							objDO.Update(objE);
						else
							objDO.Delete(objE);
					break;

				}

			}

		}

		private void DeleteMaster(EEmpresa entity)
		{

			IDOUpdate objDO = new SYDOMnt.Empresa();

			if(entity.EntityState == EntityState.Unchanged)
				return;

			objDO.Delete(entity);

		}

		private void DeleteDetail(IList<EEmpresa> col, bool filterModified)
		{

			if(col == null)
				return;

			IDOUpdate objDO = new SYDOMnt.Empresa();
			IEnumerable<EEmpresa> colSel = null;

			if(filterModified)
			{
				var deleteItems = from itm in col 
					where itm.EntityState == EntityState.Deleted
					select itm;

				colSel = (IEnumerable<EEmpresa>) deleteItems;
			}
			else
			{
				var deleteItems = from itm in col 
					select itm;

				colSel = (IEnumerable<EEmpresa>) deleteItems;
			}
			foreach(EEmpresa objE in colSel)
				objDO.Delete(objE);

		}

	}
}
