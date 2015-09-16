using System;
using System.Reflection;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Texfina.Core.Common;

namespace Texfina.Core.Data
{
/// <summary>
/// Clase base para los Data Objects
/// </summary>
/// <remarks></remarks>
public class DataObjectBase : ServerObject
{

	public Exception GetException(MethodBase method, Exception ex)
	{
		return this.GetException("DataObject", method, ex);
	}

	public DataTable ExecuteDatatable(string cmdText, ArrayList paramList)
	{

		SqlParameter[] objPrm = null;

		if ((paramList != null))
			objPrm = (SqlParameter[])paramList.ToArray(typeof(SqlParameter));

		DataTable dt = DataHelper.ExecuteDatatable(this.GetConnectionString(), CommandType.StoredProcedure, cmdText, objPrm);

		return dt;

	}

	public DataTable ExecuteDatatable(string cmdText, Int16 timeOut)
	{

		DataTable dt = DataHelper.ExecuteDatatable(this.GetConnectionString(), CommandType.StoredProcedure, cmdText, timeOut);

		return dt;

	}

	public int ExecuteNonQuery(string cmdText, ArrayList paramList)
	{

		SqlParameter[] objPrm = (SqlParameter[])paramList.ToArray(typeof(SqlParameter));

		int intRet = this.ExecuteNonQuery(cmdText, objPrm);

		return intRet;
	}

	public int ExecuteNonQuery(string cmdText, SqlParameter[] paramList)
	{

		int intRet = DataHelper.ExecuteNonQuery(this.GetConnectionString(), CommandType.StoredProcedure, cmdText, paramList);

		return intRet;

	}

	private string GetConnectionString()
	{

		return DataHelper.GetConnectionString();

	}

	public object ExecuteScalar(string cmdText, ArrayList paramList)
	{

		SqlParameter[] objPrm = (SqlParameter[])paramList.ToArray(typeof(SqlParameter));

		object obj = DataHelper.ExecuteScalar(this.GetConnectionString(), CommandType.StoredProcedure, cmdText, objPrm);

		return obj;

	}

	private string ConfigFilePath {
		get
      {
#if DEBUG
         return AppDomain.CurrentDomain.RelativeSearchPath.Replace("\\bin", "\\Config");
#else
			return AppHelper.DirectoryName;
#endif
		}
	}

}}
