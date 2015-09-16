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
	/// Data Object para Consultas a la Tabla: Usuario - Menu (SY_UsuMenu)
	/// </summary>
	/// <remarks></remarks>
	public class UsuMenu: DataObjectBase,IDOQuery
	{

		#region IDOQuery Members

		public DataTable GetByCriteria(IEntityBase value)
		{

			EUsuMenu objE = (EUsuMenu) value;

			try
			{

				ArrayList arrPrm = new ArrayList();

				arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char,5, objE.IdUser));
				arrPrm.Add(DataHelper.CreateParameter("@pidMenu", SqlDbType.Char,8, objE.IdMenu));

				DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry01", arrPrm);

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

			EUsuMenu objE = (EUsuMenu) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry02", arrPrm);

				objE = null;

				foreach(DataRow dr in dt.Rows)
					objE = DataHelper.CopyDataRowToEntity<EUsuMenu>(dr, typeof(EUsuMenu));

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

			EUsuMenu objE = (EUsuMenu) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry03", arrPrm);

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

			EUsuMenu objE = (EUsuMenu) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);

				DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry04", arrPrm);

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

			EUsuMenu objE = (EUsuMenu) value;

			try
			{

				ArrayList arrPrm = BuildParamInterface(objE);
				int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

				SqlParameter[] objPrm = (SqlParameter[]) arrPrm.ToArray(typeof(SqlParameter));

				DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry05", arrPrm);

				return objPrm[intIdx].Value.ToString() == "1" ? true : false;

			}
			catch(Exception ex)
			{

				ServerObjectException objEx = (ServerObjectException) this.GetException(MethodBase.GetCurrentMethod(), ex);
				throw objEx;

			}
		}

		private ArrayList BuildParamInterface (EUsuMenu value)
		{

			ArrayList arrPrm = new ArrayList();

			arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char,5, value.IdUser));
			arrPrm.Add(DataHelper.CreateParameter("@pidMenu", SqlDbType.Char,8, value.IdMenu));

			return arrPrm;

		}

		#endregion

      /// <summary>
      /// Recupera el Menu asignado para el Usuario
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public DataTable GetMenuAsignado(IEntityBase value)
      {

         EUsuMenu objE = (EUsuMenu)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char, 5, objE.IdUser));

            DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry10", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      /// <summary>
      /// Recupera el Menu y sus Derechos, para configurarlo.
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      public DataTable GetConfigMenu(IEntityBase value)
      {

         EUsuario objE = (EUsuario)value;

         try
         {

            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidLogon", SqlDbType.VarChar, 30, objE.IdLogon));

            DataTable dt = this.ExecuteDatatable("SY_UsuMenu_qry11", arrPrm);

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
