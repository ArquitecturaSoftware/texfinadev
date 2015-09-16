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
    public interface IAFPnet
   {
      /// <summary>
      /// Obtiene data para exportar informacion de afp
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetDataAFPnet(IEntityBase value);
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Calculos de afp  (RH_procplacalc)
   /// </summary>
   /// 
   public class AFPnet : BusinessObjectBase, IAFPnet

   {

      #region IBOQuery Members

       public DataTable GetDataAFPnet(IEntityBase value)
      {

         RHDORpt.AFPnet objData = new RHDORpt.AFPnet();

         try
         {

             DataTable dt = objData.GetDataAFPnet(value);

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
