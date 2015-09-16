using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Texfina.Core.Common;
using System.Text;
using System.Collections;


namespace Texfina.Core.Data
{
    //public class DBAccess : DataObjectBase, IDisposable
    public class DBAccess : IDisposable
    {

        private IDbCommand cmd = new SqlCommand();
        private string strConnectionString = "";
        private bool handleErrors = false;
        private string strLastError = "";

        private static string ConfigFilePath
        {
            get
            {
                #if DEBUG
                return AppDomain.CurrentDomain.RelativeSearchPath.Replace("\\bin\\Debug", "\\Config");
                #else
                    return AppHelper.DirectoryName;
                #endif
            }
        }

        //public static string GetConnectionString()
        //{


        //    string strXmlFile = Path.Combine(ConfigFilePath, Texfina.Core.Common.Constants2.ConstSistema.CONFIGDATA);

        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.Load(strXmlFile);
        //    XmlNode nod = xmlDoc.SelectSingleNode("/ConfigData/CNX");
        //    if (nod == null)
        //    {
        //        return null;
        //    }

        //    string strSvr = "";
        //    string strDB = "";
        //    string strUsr = "";
        //    string strPsw = "";
        //    Cryptor objCryptor = new Cryptor();

        //    strSvr = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["Server"].Value)));
        //    //strDB = "tex2013";
        //    strDB = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["Database"].Value)));
        //    strUsr = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["User"].Value)));
        //    strPsw = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["Password"].Value)));

        //    return GetConnectionString(strSvr, strDB, strUsr, strPsw);

        //}

        //public static string GetConnectionString(string serverName, string dataBase, string user, string password)
        //{

        //    string strCS = "";

        //    if (string.IsNullOrEmpty(user.Trim()))
        //    {
        //        strCS = "Server = " + serverName + "; Database = " + dataBase + "; trusted_connection=yes";
        //    }
        //    else
        //    {
        //        strCS = "Server = " + serverName + "; Database = " + dataBase + "; User = " + user + "; Password = " + password + "";
        //    }


        //    return strCS;
        //}
    
        public static string GetConnectionStringX()
        {
            //string strXmlFile = Path.Combine(ConfigFilePath, ConstSistema.CONFIGDATA);
            string strXmlFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            string strXmlFile_ = Path.Combine(strXmlFile, Texfina.Core.Common.Constants2.ConstSistema.CONFIGDATA);

            XmlDocument xmlDoc = new XmlDocument();

            //string reportPath = Application.StartupPath + "\\Reporte\\co_ordenCompra_rpt.rpt";

            //xmlDoc.Load("D:\\2014\\sistema destock compras\\Sist_Compras\\Sist_Compras\\Config\\ConfigData.xml");

            xmlDoc.Load(strXmlFile_);

            XmlNode nod = xmlDoc.SelectSingleNode("/ConfigData/CNX");
            if (nod == null)
            {
                return null;
            }

            string strSvr = "";
            string strDB = "";
            string strUsr = "";
            string strPsw = "";
            Cryptor objCryptor = new Cryptor();

            strSvr = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["Server"].Value)));
            strDB = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["Database"].Value)));
            strUsr = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["User"].Value)));
            strPsw = Encoding.UTF8.GetString(objCryptor.Decrypt(Convert.FromBase64String(nod.Attributes["Password"].Value)));

            return GetConnectionStringX(strSvr, strDB, strUsr, strPsw);

        }

        public static string GetConnectionStringX(string serverName, string dataBase, string user, string password)
        {

            string strCS = "";

            if (string.IsNullOrEmpty(user.Trim()))
            {
                strCS = "Server = " + serverName + "; Database = " + dataBase + "; trusted_connection=yes";
            }
            else
            {
                strCS = "Server = " + serverName + "; Database = " + dataBase + "; User = " + user + "; Password = " + password + "";
            }


            return strCS;
        }
    
		public DBAccess()
		{
           // ConnectionStringSettings objConnectionStringSettings = ConfigurationManager.ConnectionStrings["connectionstring"];
            //strConnectionString = "server=LAB606_19\\UWIENER;database=SYSGLI; integrated security=sspi";
            //strConnectionString = "server=(local);database=PRUEBA_ASISTENCIA;uid=sa;pwd=123";
            //strConnectionString = GetConnectionString();

            strConnectionString = GetConnectionStringX();
          

            SqlConnection cnn=new SqlConnection();
            
			cnn.ConnectionString=strConnectionString;
            
			cmd.Connection=cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandTimeout = 0;
            
        }

		public IDataReader ExecuteReader()
		{
			IDataReader reader=null;
            try
            {
                this.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastError = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
			return reader;
		}

		public IDataReader ExecuteReader(string commandtext)
		{
			IDataReader reader=null;
			try
			{
				cmd.CommandText=commandtext;
				reader=this.ExecuteReader();
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return reader;
		}

		public object ExecuteScalar()
		{
			object obj=null;
			try
			{
				this.Open();
				obj= cmd.ExecuteScalar();
                this.Close();
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return obj;
		}

		public object ExecuteScalar(string commandtext)
		{
			object obj=null;
			try
			{
				cmd.CommandText=commandtext;
				obj= this.ExecuteScalar();
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return obj;
		}

		public int ExecuteNonQuery()
		{
			int i=-1;
			try
			{
			    this.Open();
				i=cmd.ExecuteNonQuery();
                this.Close();
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return i;
		}

		public int ExecuteNonQuery(string commandtext)
		{
			int i=-1;
			try
			{
				cmd.CommandText=commandtext;
				i=this.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return i;
		}

		public DataSet ExecuteDataSet()
		{
			SqlDataAdapter da=null;
			DataSet ds=null;
			try
			{
				da=new SqlDataAdapter();
				da.SelectCommand=(SqlCommand)cmd;
				ds=new DataSet();
				da.Fill(ds);
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return ds;
		}

		public DataSet ExecuteDataSet(string commandtext)
		{
			DataSet ds=null;
			try
			{
				cmd.CommandText=commandtext;
				ds=this.ExecuteDataSet();
			}
			catch(Exception ex)
			{
				if(handleErrors)
					strLastError=ex.Message;
				else
					throw;
			}
            catch
            {
                throw;
            }

			return ds;
		}


      
		public string CommandText
		{
			get
			{
				return cmd.CommandText;
			}
			set
			{
				cmd.CommandText=value;
				cmd.Parameters.Clear();
			}
		}

		public IDataParameterCollection Parameters
		{
			get
			{
				return cmd.Parameters;
			}
		}

    	public void AddParameter(string paramname,object paramvalue)
		{
			SqlParameter param=new SqlParameter(paramname,paramvalue);
			cmd.Parameters.Add(param);
		}

        public static SqlParameter CreateParameter(string paramName, SqlDbType dataType, int dataSize, object dataValue)
        {
            SqlParameter param = new SqlParameter(paramName, dataType, dataSize);
            param.Direction = ParameterDirection.Input;
            param.Value = dataValue;
            return param;
        }


        public static SqlParameter CreateParameter(string paramName, SqlDbType dataType, object dataValue)
        {
            SqlParameter param = new SqlParameter(paramName, dataType);
            param.Direction = ParameterDirection.Input;
            param.Value = dataValue;
            return param;
        }

		public void AddParameter(IDataParameter param)
		{
			cmd.Parameters.Add(param);
		}

		public string ConnectionString
		{
			get
			{
				return strConnectionString;
			}
			set
			{
				strConnectionString=value;
			}
		}

        private void Open()
        {
            cmd.Connection.Open();
        }

        private void Close()
        {
            cmd.Connection.Close();
        }

		public bool HandleExceptions
		{
			get
			{
				return handleErrors;
			}
			set
			{
				handleErrors=value;
			}
		}

		public string LastError
		{
			get
			{
				return strLastError;
			}
		}

        public void Dispose()
        {
            cmd.Dispose();
        }

        public static DataTable ExecuteDatatable(string connstrig, CommandType cmdType, string cmdText, SqlParameter[] sqlParams)
        {
            SqlConnection cnn = new SqlConnection(connstrig);
            SqlCommand cmm = new SqlCommand(cmdText, cnn);
            cmm.CommandType = cmdType;
            if (sqlParams != null)
                cmm.Parameters.AddRange(sqlParams);
            DataTable dt = new DataTable(cmdText);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            cnn.Open();
            cmm.CommandTimeout = 0;
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        
        public DataTable ExecuteDatatable(string cmdText, ArrayList paramList)
        {
            SqlParameter[] objPrm = null;
            if ((paramList != null))
                objPrm = (SqlParameter[])paramList.ToArray(typeof(SqlParameter));
            DataTable dt = ExecuteDatatable(GetConnectionStringX(), CommandType.StoredProcedure, cmdText, objPrm);
            return dt;


        }
    
    }

}
