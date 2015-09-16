using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using RHDORpt = Texfina.DORpt.Rh;

namespace Texfina.BORpt.Rh
{
   [ServiceContract()]
   public interface IPersonal
   {
      /// <summary>
      /// Obtiene la cabezara para el reporte de Contratos.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPerContrato(IEntityBase value);

         /// <summary>
      /// Obtiene la cabezara para el reporte de Personal.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPersonal(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de las tablas unidas RH_PerContrato.
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetContratosMasivamente(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PerContrato(Contratos del Personal para impresion por Fecha).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaImpreContra(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PerContrato(trabajadores para Exportar masivamente).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaExpConMinTrab(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PerContrato(Contratos para Exportar masivamente).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaExpConMinCon(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PeRemu(Remuneración de Personal).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaPerRemu(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_Prestamo(Prestamo de Personal).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaPrestamo(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_PrestaCuota(PrestaCuota de Personal).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaPrestaCuota(IEntityBase value);

      /// <summary>
      /// Obtiene los registros de la Tabla RH_ProcPlaReg(ProcPlaReg de Personal).
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteriaProcPlaReg(IEntityBase value);


   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   public class Personal : BusinessObjectBase, IPersonal
   {

      #region IBOQuery Members


      public DataTable GetPerContrato(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

            DataTable dt = objData.GetPerContrato(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetPersonal(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

            DataTable dt = objData.GetPerContrato(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetContratosMasivamente(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

            DataTable dt = objData.GetContratosMasivamente(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaImpreContra(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

            DataTable dt = objData.GetByCriteriaImpreContra(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }


      public DataTable GetByCriteriaExpConMinTrab(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

            DataTable dt = objData.GetByCriteriaExpConMinTrab(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaExpConMinCon(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

            DataTable dt = objData.GetByCriteriaExpConMinCon(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaPerRemu(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

             DataTable dt = objData.GetByCriteriaPerRemu(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaPrestamo(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

             DataTable dt = objData.GetByCriteriaPrestamo(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaPrestaCuota(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

             DataTable dt = objData.GetByCriteriaPrestaCuota(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetByCriteriaProcPlaReg(IEntityBase value)
      {

         RHDORpt.Personal objData = new RHDORpt.Personal();

         try
         {

             DataTable dt = objData.GetByCriteriaProcPlaReg(value);

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
