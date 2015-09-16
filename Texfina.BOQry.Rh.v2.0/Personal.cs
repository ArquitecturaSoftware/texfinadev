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
    /// Interface para Consultas personalizadas a la Tabla: RH_PerDepen,RH_PerFoto,RH_PerContrato,
    ///  RH_PerPlanilla,RH_Planilla,RH_PerExpeLabo,RH_PerEducacion,RH_Personal,MG_CliProv
    /// </summary>
   [ServiceContract()]
   public interface IPersonal
   {
       /// <summary>
       /// Obtiene las registro de la tabla RH_PerDepen, por su llave padre.
       /// </summary>
       /// <param name="value">Entidad base</param>
       /// <returns>Retorna un DataTable</returns>
       /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyPerDepen(IEntityBase value);

      /// <summary>
      /// Metodo general para consultar datos por la llave primaria a la tabla RH_PerDepen
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna una Entidad Base que representa el registro requerido</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetByKeyPerDepen(IEntityBase value);

      /// <summary>
      /// Metodo general para consultar datos por la llave primaria a la tabla RH_PerFoto
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna una Entidad Base que representa el registro requerido</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetByKeyPerFoto(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de la tabla RH_PerContrato, por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyPerContrato(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de las tablas unidas RH_PerPlanilla y RH_Planilla , por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPlanillaXPersonal(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de las tablas unidas RH_Personal y MG_CliProv , por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetCliProvXPersonal(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de la tabla RH_PerExpeLabo , por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyPerExpeLabo(IEntityBase value);

      /// <summary>
      /// Obtiene las registro de la tabla RH_PerEducacion , por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyPerEducacion(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla RH_PerRemu , por su llave padre.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKeyPerRemuneracion(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de las tablas unidas RH_PerPlanilla.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPersonalxPlanilla(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PerHistoAprob(Historial de Aprobaciones).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPerHistoAprob(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PerContrato(Contratos del Personal).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaPerContrato(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla RH_PerRemu , por su llave padre y solo el registro activo.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetPerRemuneracionActiva(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla RH_PerContraArch , por su llave padre y solo el registro activo.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetPerContraArch(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla RH_PerContraArch , por su llave padre y solo el registro activo.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetVacaPersonalGrupal(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la tabla RH_PerContraArch , por su llave padre y solo el registro activo.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaVacacion(IEntityBase value);
   }

   
   /// <summary>
   /// Business Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   public class Personal : BusinessObjectBase, IBOQuery, IPersonal
   {

      #region IBOQuery Members

      public DataTable GetByCriteria(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.Personal();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Personal();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Personal();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Personal();

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

         IDOQuery objData = (IDOQuery)new RHDOQry.Personal();

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

      #region IPersonal Members

      public DataTable GetByParentKeyPerDepen(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerDepen();

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

      public IEntityBase GetByKeyPerDepen(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerDepen();

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

      public IEntityBase GetByKeyPerFoto(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerFoto();

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

      public DataTable GetByParentKeyPerContrato(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerContrato();

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

      public DataTable GetPlanillaXPersonal(IEntityBase value)
      {

         RHDOQry.Personal objData = new RHDOQry.Personal();

         try
         {

            DataTable dt = objData.GetPlanillaXPersonal(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetCliProvXPersonal(IEntityBase value)
      {

         RHDOQry.Personal objData = new RHDOQry.Personal();

         try
         {

            DataTable dt = objData.GetCliProvXPersonal(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByParentKeyPerExpeLabo(IEntityBase value)
      {

          IDOQuery objData = (IDOQuery)new RHDOQry.PerExpeLabo();

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

      public DataTable GetByParentKeyPerEducacion(IEntityBase value)
      {

          IDOQuery objData = (IDOQuery)new RHDOQry.PerEducacion();

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

      public DataTable GetByParentKeyPerRemuneracion(IEntityBase value)
      {

          IDOQuery objData = (IDOQuery)new RHDOQry.PerRemu();

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

      public DataTable GetPersonalxPlanilla(IEntityBase value)
      {

          RHDOQry.Personal objData = new RHDOQry.Personal();

          try
          {

              DataTable dt = objData.GetPersonalxPlanilla(value);

              return dt;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }

      public DataTable GetPerHistoAprob(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerHistoAprob();

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

      public DataTable GetByCriteriaPerContrato(IEntityBase value)
      {

         IDOQuery objData = (IDOQuery)new RHDOQry.PerContrato();

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

      public IEntityBase GetPerRemuneracionActiva(IEntityBase value)
      {

         RHDOQry.PerRemu objData = new RHDOQry.PerRemu();

         try
         {

            IEntityBase objE = objData.GetPerRemuneracionActiva(value);

            return objE;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public IEntityBase GetPerContraArch(IEntityBase value)
      {

         RHDOQry.PerContraArch objData = new RHDOQry.PerContraArch();

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

      public DataTable GetVacaPersonalGrupal(IEntityBase value)
      {

         RHDOQry.Personal objData = new RHDOQry.Personal();

         try
         {

            DataTable dt = objData.GetVacaPersonalGrupal(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaVacacion(IEntityBase value)
      {

          RHDOQry.Personal objData = new RHDOQry.Personal();

          try
          {

              DataTable dt = objData.GetByCriteriaVacacion(value);

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
