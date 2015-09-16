using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;

namespace Texfina.DOQry.Rh
{
	/// <summary>
	/// Data Object para Consultas a la Tabla: Campos disponibles en el Editor de Formulas Detalle (RH_TablaCFDet)
	/// </summary>
	/// <remarks></remarks>
	public class TablaCFDet: DataObjectBase,IDOQuery
	{

		#region IDOQuery Members

		public DataTable GetByCriteria(IEntityBase value)
		{

			ETablaCFDet objE = (ETablaCFDet) value;

			try
			{

				ArrayList arrPrm = new ArrayList();

				arrPrm.Add(DataHelper.CreateParameter("@pidEditor", SqlDbType.Char,3, objE.IdEditor));
				arrPrm.Add(DataHelper.CreateParameter("@pnuSeccion", SqlDbType.Char,1, objE.NuSeccion));
				arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

				DataTable dt = this.ExecuteDatatable("RH_TablaCFDet_qry01", arrPrm);

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

			ETablaCFDet objE = (ETablaCFDet) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("RH_TablaCFDet_qry02", arrPrm);

				objE = null;

				foreach(DataRow dr in dt.Rows)
					objE = DataHelper.CopyDataRowToEntity<ETablaCFDet>(dr, typeof(ETablaCFDet));

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

			ETablaCFDet objE = (ETablaCFDet) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("RH_TablaCFDet_qry03", arrPrm);

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

			ETablaCFDet objE = (ETablaCFDet) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("RH_TablaCFDet_qry04", arrPrm);

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

			ETablaCFDet objE = (ETablaCFDet) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);
				int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

				SqlParameter[] objPrm = (SqlParameter[]) arrPrm.ToArray(typeof(SqlParameter));

				DataTable dt = this.ExecuteDatatable("RH_TablaCFDet_qry05", arrPrm);

				return objPrm[intIdx].Value.ToString() == "1" ? true : false;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		private ArrayList BuildParamInterface (ETablaCFDet value)
		{

			ArrayList arrPrm = new ArrayList();

			arrPrm.Add(DataHelper.CreateParameter("@pidEditor", SqlDbType.Char,3, value.IdEditor));
			arrPrm.Add(DataHelper.CreateParameter("@pnuSeccion", SqlDbType.Char,1, value.NuSeccion));
			arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));

			return arrPrm;

		}

		#endregion

      /// <summary>
      /// Recupera la lista de campos dispobibles por seccion
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public DataTable GetCamposXSeccion(IEntityBase value)
      {

         ETablaCF objE = (ETablaCF)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidEditor", SqlDbType.Char, 3, objE.IdEditor));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSeccion", SqlDbType.Char, 1, DataHelper.IfNullString(objE.NuSeccion)));

            DataTable dt = this.ExecuteDatatable("RH_TablaCFDet_qry10", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

	}
}
