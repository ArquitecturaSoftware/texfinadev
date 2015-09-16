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
	/// Data Object para consultas a la Tabla SY_Empresa
	/// </summary>
	/// <remarks></remarks>
	public class Empresa: DataObjectBase,IDOQuery
	{

		#region IDOQuery Members

		public DataTable GetByCriteria(IEntityBase value)
		{

			EEmpresa objE = (EEmpresa) value;

			try
			{

				ArrayList arrPrm = new ArrayList();

				arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char,3, objE.IdEmpresa));

				DataTable dt = this.ExecuteDatatable("SY_Empresa_qry01", arrPrm);

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

			EEmpresa objE = (EEmpresa) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_Empresa_qry02", arrPrm);

				objE = null;

				foreach(DataRow dr in dt.Rows)
					objE = DataHelper.CopyDataRowToEntity<EEmpresa>(dr, typeof(EEmpresa));

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

			EEmpresa objE = (EEmpresa) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_Empresa_qry03", arrPrm);

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

			EEmpresa objE = (EEmpresa) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_Empresa_qry04", arrPrm);

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

			EEmpresa objE = (EEmpresa) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);
				int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

				SqlParameter[] objPrm = (SqlParameter[]) arrPrm.ToArray(typeof(SqlParameter));

				DataTable dt = this.ExecuteDatatable("SY_Empresa_qry05", arrPrm);

				return objPrm[intIdx].Value.ToString() == "1" ? true : false;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		private ArrayList BuildParamInterface (EEmpresa value)
		{

			ArrayList arrPrm = new ArrayList();

			arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char,3, value.IdEmpresa));

			return arrPrm;

		}

		#endregion

	}
}
