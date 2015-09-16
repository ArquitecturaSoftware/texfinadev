using System;
using System.Collections;
using System.Data;
using System.Text;
using System.ServiceModel;
using Texfina.Core.Data;
using CODORpt = Texfina.DORpt.Co;

namespace Texfina.BORpt.Co
{
   [ServiceContract()]
    public interface ISunat
   {
      /// <summary>
      /// Obtiene la cabezara para el reporte de la Boleta de Trabajador
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetDataXKey(IEntityBase value);

   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   public class TSunat : BusinessObjectBase, ISunat
   {

      #region IBOQuery Members

       public DataTable GetDataXKey(IEntityBase value)
      {

         //RHDORpt.TRegistro objData = new RHDORpt.TRegistro();
         CODORpt.TSunat objData = new CODORpt.TSunat();

         try
         {

             DataTable dt = objData.GetDataXKey(value);

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
