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
    public interface IPerVacaDesca
   {
      /// <summary>
      /// Obtiene la cabezara para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetSolicitudVacaciones(IEntityBase value);

      /// <summary>
      /// Obtiene la cabezara para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetPlanillaVacaciones(IEntityBase value);

   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   public class PerVacaDesca : BusinessObjectBase, IPerVacaDesca
   {

      #region IBOQuery Members

       public DataTable GetSolicitudVacaciones(IEntityBase value)
      {

          RHDORpt.PerVacaDesca objData = new RHDORpt.PerVacaDesca();

         try
         {

             DataTable dt = objData.GetSolicitudVacaciones(value);

            return dt;

         }
         catch (Exception ex)
         {

            throw ex;

         }

      }

       public DataTable GetPlanillaVacaciones(IEntityBase value)
       {

           RHDORpt.PerVacaDesca objData = new RHDORpt.PerVacaDesca();

           try
           {

               DataTable dt = objData.GetPlanillaVacaciones(value);

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
