using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para Busqueda ConsoPlanilla
   /// </summary>
   [DataContract()]
   public class EPlanillaBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnual = 0;
      private int _intNuProcAnualFin = 0;
      private string _strIdPersonal = "";
      private string _strIdCCosto = "";
      private string _strIdEstable = "";
      private string _strIdTipGasto = "";


      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      /// <summary>
      /// Código de Periodo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPeriodo
      {
         get { return _strIdPeriodo; }
         set { _strIdPeriodo = value; }
      }

      /// <summary>
      /// Código de Empresa
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEmpresa
      {
         get { return _strIdEmpresa; }
         set { _strIdEmpresa = value; }
      }

      [DataMember()]
      public string IdForPago
      {
         get { return _strIdForPago; }
         set { _strIdForPago = value; }
      }

      /// <summary>
      /// Código de Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPlanilla
      {
         get { return _strIdPlanilla; }
         set { _strIdPlanilla = value; }
      }

      /// <summary>
      /// Proc. Anual
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuProcAnual
      {
         get { return _intNuProcAnual; }
         set { _intNuProcAnual = value; }
      }

      /// <summary>
      /// Proc. Anual Fin
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuProcAnualFin
      {
          get { return _intNuProcAnualFin; }
          set { _intNuProcAnualFin = value; }
      }

      /// <summary>
      /// Código del Personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPersonal
      {
         get { return _strIdPersonal; }
         set { _strIdPersonal = value; }
      }

      /// <summary>
      /// Código del Centro de Costos
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCCosto
      {
         get { return _strIdCCosto; }
         set { _strIdCCosto = value; }
      }

      /// <summary>
      /// Código de Establecimiento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEstable
      {
         get { return _strIdEstable; }
         set { _strIdEstable = value; }
      }

      /// <summary>
      /// Tipo de Gasto
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipGasto
      {
          get { return _strIdTipGasto; }
          set { _strIdTipGasto = value; }
      }

     
      #endregion

   }
}
