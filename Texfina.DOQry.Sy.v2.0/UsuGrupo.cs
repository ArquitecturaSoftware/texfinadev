using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Sy;

namespace Texfina.DOQry.Sy
{
	/// <summary>
	/// Data Object para Consultas a la Tabla: Usuario - Grupo (SY_UsuGrupo)
	/// </summary>
	/// <remarks></remarks>
	public class UsuGrupo: DataObjectBase,IDOQuery
	{

		#region IDOQuery Members

		public DataTable GetByCriteria(IEntityBase value)
		{

			EUsuGrupo objE = (EUsuGrupo) value;

			try
			{

				ArrayList arrPrm = new ArrayList();

				arrPrm.Add(DataHelper.CreateParameter("@pidUsuario", SqlDbType.Char,5, objE.IdUsuario));
				arrPrm.Add(DataHelper.CreateParameter("@pidGrupo", SqlDbType.Char,5, objE.IdGrupo));

				DataTable dt = this.ExecuteDatatable("SY_UsuGrupo_qry01", arrPrm);

				return dt;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		public IEntityBase GetByKey(IEntityBase value)
		{

			EUsuGrupo objE = (EUsuGrupo) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_UsuGrupo_qry02", arrPrm);

				objE = null;

				foreach(DataRow dr in dt.Rows)
					objE = DataHelper.CopyDataRowToEntity<EUsuGrupo>(dr, typeof(EUsuGrupo));

				return objE;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		public DataTable GetByParentKey(IEntityBase value)
		{

			EUsuGrupo objE = (EUsuGrupo) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_UsuGrupo_qry03", arrPrm);

				return dt;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		public DataTable GetList(IEntityBase value)
		{

			EUsuGrupo objE = (EUsuGrupo) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_UsuGrupo_qry04", arrPrm);

				return dt;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		public bool Exists(IEntityBase value)
		{

			EUsuGrupo objE = (EUsuGrupo) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);
				int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

				SqlParameter[] objPrm = (SqlParameter[]) arrPrm.ToArray(typeof(SqlParameter));

				DataTable dt = this.ExecuteDatatable("SY_UsuGrupo_qry05", arrPrm);

				return objPrm[intIdx].Value.ToString() == "1" ? true : false;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		private ArrayList BuildParamInterface (EUsuGrupo value)
		{

			ArrayList arrPrm = new ArrayList();

			arrPrm.Add(DataHelper.CreateParameter("@pidUsuario", SqlDbType.Char,5, value.IdUsuario));
			arrPrm.Add(DataHelper.CreateParameter("@pidGrupo", SqlDbType.Char,5, value.IdGrupo));

			return arrPrm;

		}

		#endregion

	}
}
