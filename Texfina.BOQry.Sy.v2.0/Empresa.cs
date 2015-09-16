using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using SYDOQry = Texfina.DOQry.Sy;

namespace Texfina.BOQry.Sy
{
   /// <summary>
   /// Interface para Consultas personalizadas
   /// </summary>
   [ServiceContract()]
   public interface IEmpresa
   {
      /// <summary>
      /// Obtiene los Periodos por Empresa
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPeriodos(IEntityBase value);

      /// <summary>
      /// Obtiene los Establecimientos por Empresa
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      [OperationContract()]
      [NetDataContract()]
      DataTable GetEstablecimientos(IEntityBase value);
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Empresa (SY_Empresa)
   /// </summary>
   public class Empresa : BusinessObjectBase, IBOQuery, IEmpresa
	{

		#region IBOQuery Members

		public DataTable GetByCriteria(IEntityBase value)
		{

			IDOQuery objData = (IDOQuery) new SYDOQry.Empresa();

			try
			{

				DataTable dt = objData.GetByCriteria(value);

				return dt;

			}
			catch(Exception ex)
			{

				throw ex;

			}

		}

		public IEntityBase GetByKey(IEntityBase value)
		{

			IDOQuery objData = (IDOQuery) new SYDOQry.Empresa();

			try
			{

				IEntityBase objE = objData.GetByKey(value);

				return objE;

			}
			catch(Exception ex)
			{

				throw ex;

			}

		}

		public DataTable GetByParentKey(IEntityBase value)
		{

			IDOQuery objData = (IDOQuery) new SYDOQry.Empresa();

			try
			{

				DataTable dt = objData.GetByParentKey(value);

				return dt;

			}
			catch(Exception ex)
			{

				throw ex;

			}

		}

		public DataTable GetList(IEntityBase value)
		{

			IDOQuery objData = (IDOQuery) new SYDOQry.Empresa();

			try
			{

				DataTable dt = objData.GetList(value);

				return dt;

			}
			catch(Exception ex)
			{

				throw ex;

			}

		}

		public bool Exists(IEntityBase value)
		{

			IDOQuery objData = (IDOQuery) new SYDOQry.Empresa();

			try
			{

				bool blnRes = objData.Exists(value);

				return blnRes;

			}
			catch(Exception ex)
			{

				throw ex;

			}

		}

		#endregion

      #region IEmpresa Members
      public DataTable GetPeriodos(IEntityBase value)
      {
         IDOQuery objData = (IDOQuery) new SYDOQry.EmpPeriodo();

         try
         {

            DataTable dt = objData.GetList(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetEstablecimientos(IEntityBase value)
      {
         IDOQuery objData = (IDOQuery)new SYDOQry.EmpEstable();

         try
         {

            DataTable dt = objData.GetList(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }
      #endregion
   }
}
