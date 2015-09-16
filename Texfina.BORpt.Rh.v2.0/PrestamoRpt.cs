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
    public interface IPrestamoRpt
   {
      /// <summary>
      /// Obtiene data para exportar informacion de afp
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      /// 
      [OperationContract()]
      [NetDataContract()]
      DataTable GetDataPrestamo(IEntityBase value);
   }

   /// <summary>
   /// Business Object para Consultas a la Tabla: Calculos de afp  (RH_procplacalc)
   /// </summary>
   /// 
   public class PrestamoRpt : BusinessObjectBase, IPrestamoRpt

   {

      #region IBOQuery Members

       public DataTable GetDataPrestamo(IEntityBase value)
      {

         RHDORpt.PrestamoRpt objData = new RHDORpt.PrestamoRpt();

         try
         {

            DataTable dt = objData.GetDataPrestamo(value);

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
