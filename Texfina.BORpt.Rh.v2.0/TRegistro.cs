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
    public interface ITRegistro
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
   public class TRegistro : BusinessObjectBase, ITRegistro
   {

      #region IBOQuery Members

       public DataTable GetDataXKey(IEntityBase value)
      {

         RHDORpt.TRegistro objData = new RHDORpt.TRegistro();

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
