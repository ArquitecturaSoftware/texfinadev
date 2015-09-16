using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using RHDOQry = Texfina.DOQry.Rh;

namespace Texfina.BOQry.Rh
{

    /// <summary>
    /// Interface para Consultas personalizadas a la Tabla: RH_PrestaCuota
    /// </summary>
   [ServiceContract()]
   public interface IPrestamo
   {
       /// <summary>
       /// Metodo general para consultar datos por la llave primaria a la tabla RH_PrestaCuota
       /// </summary>
       /// <param name="value">Entidad base</param>
       /// <returns>Retorna una Entidad Base que representa el registro requerido</returns>
       /// 
      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetByKeyPrestaCuota(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de la tabla RH_PrestaCuota, por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyPrestaCuota(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de la tabla RH_PrestaCuota y RH_prestamo, por la llave de Proceso de planilla.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPrestaCuotaxProcPlanilla(IEntityBase value);

   }
   
   /// <summary>
   /// Business Object para Consultas a la Tabla: Prestamo (RH_Prestamo)
   /// </summary>
   public class Prestamo : BusinessObjectBase, IBOQuery, IPrestamo
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Prestamo();

         try
         {

            DataTable dt = objData.GetByCriteria(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public IEntityBase GetByKey(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Prestamo();

         try
         {

            IEntityBase objE = objData.GetByKey(value);

            return objE;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByParentKey(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Prestamo();

         try
         {

            DataTable dt = objData.GetByParentKey(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetList(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Prestamo();

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

      public bool Exists(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Prestamo();

         try
         {

            bool blnRes = objData.Exists(value);

            return blnRes;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      #endregion

      #region IPrestamo Members

      public IEntityBase GetByKeyPrestaCuota(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PrestaCuota();

         try
         {

            IEntityBase objE = objData.GetByKey(value);

            return objE;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByParentKeyPrestaCuota(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PrestaCuota();

         try
         {

            DataTable  objE = objData.GetByParentKey(value);

            return objE;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetPrestaCuotaxProcPlanilla(IEntityBase value)
      {

          RHDOQry.PrestaCuota  objData = new RHDOQry.PrestaCuota();

          try
          {

              DataTable objE = objData.GetPrestaCuotaxProcPlanilla(value);

              return objE;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }
      #endregion

   }
}
