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
   public interface IPlanilla
   {

      /// <summary>
      /// Obtiene la cabezara para el reporte de Vencimiento de contratos
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetVencimientoContrato(IEntityBase value);

      /// <summary>
      /// Obtiene la cabezara para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetBoletaTrabajador(IEntityBase value);

      /// <summary>
      /// Obtiene la cabezara para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetCertificadoTrabajador(IEntityBase value);

      /// <summary>
      /// Obtiene El Detalle (Retenciones y Aportaciones) para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetBoletaTrabajadorDet(IEntityBase value);

      /// <summary>
      /// Obtiene El Detalle (Retenciones y Aportaciones) para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetBoletaTrabajadorPrint(IEntityBase value);

      /// <summary>
      /// Obtiene información para el reporte de resumen de planillas
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetResumenPlanilla(IEntityBase value);

      /// <summary>
      /// Obtiene información para el reporte de Distribución de Billete
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetDistribuciónBillete(IEntityBase value);

      /// <summary>
      /// Obtiene información para el reporte de Resumen de planilla
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetConsoPlanilla(IEntityBase value);

      /// <summary>
      /// Obtiene información para el reporte de Resumen de planilla con descuento de descanso Fisico
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetConsoPlanillaVaca(IEntityBase value);

      /// <summary>
      /// Obtiene información para el reporte de Horas Laboradas
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetProcPlaHora(IEntityBase value);

      /// <summary>
      /// Dias de vacaciones del Trabajador por periodo
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetVacaDiasPrint(IEntityBase value);


      /// <summary>
      /// Obtiene información para el reporte de resumen por concepto remunerativo
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetResumenConcepto(IEntityBase value);

      /// <summary>
      /// Obtiene El Detalle (Retenciones y Aportaciones) para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetConstanciaCTS(IEntityBase value);

      /// <summary>
      /// Obtiene información para el reporte de resumen de planillas
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetBancoResu(IEntityBase value);

   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   public class Planilla : BusinessObjectBase, IPlanilla

   {

      #region IBOQuery Members
      
      public DataTable GetBoletaTrabajador(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetBoletaTrabajador(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetBoletaTrabajadorDet(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetBoletaTrabajadorDet(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetBoletaTrabajadorPrint(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetBoletaTrabajadorPrint(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetResumenPlanilla(IEntityBase value)
      {

          RHDORpt.Planilla objData = new RHDORpt.Planilla();

          try
          {

              DataTable dt = objData.GetResumenPlanilla(value);

              return dt;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }

      public DataTable GetDistribuciónBillete(IEntityBase value)
      {

          RHDORpt.Planilla objData = new RHDORpt.Planilla();

          try
          {

             DataTable dt = objData.GetDistribuciónBillete(value);

              return dt;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }


      public DataTable GetConsoPlanilla(IEntityBase value)
      {

          RHDORpt.Planilla objData = new RHDORpt.Planilla();

          try
          {

             DataTable dt = objData.GetConsoPlanilla(value);

              return dt;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }

      public DataTable GetConsoPlanillaVaca(IEntityBase value)
      {

          RHDORpt.Planilla objData = new RHDORpt.Planilla();

          try
          {

              DataTable dt = objData.GetConsoPlanillaVaca(value);

              return dt;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }
      
      public DataTable GetProcPlaHora(IEntityBase value)
      {

          RHDORpt.Planilla objData = new RHDORpt.Planilla();

          try
          {

              DataTable dt = objData.GetProcPlaHora(value);

              return dt;

          }
          catch (Exception ex)
          {

              throw ex;

          }

      }
      
      ///Llamando a mi reporte
      public DataTable GetBancoResu(IEntityBase value)
       {

           RHDORpt.Planilla objData = new RHDORpt.Planilla();

           try
           {

               DataTable dt = objData.GetBancoResu(value);

               return dt;

           }
           catch (Exception ex)
           {

               throw ex;

           }

       } 
       
      public DataTable GetCertificadoTrabajador(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetCertificadoTrabajador(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetVencimientoContrato(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetVencimientoContrato(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetVacaDiasPrint(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetVacaDiasPrint(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

      public DataTable GetResumenConcepto(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetResumenConcepto(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }
      
      public DataTable GetConstanciaCTS(IEntityBase value)
      {

         RHDORpt.Planilla objData = new RHDORpt.Planilla();

         try
         {

            DataTable dt = objData.GetConstanciaCTS(value);

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
