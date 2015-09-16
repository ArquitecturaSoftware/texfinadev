using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Proceso de Planilla (RH_ProcPlani)
   /// </summary>
   [DataContract()]
   public class EBoletaPago : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnualIni = 0;
      private int _intNuProcAnualFin = 0;

      private string _strIdEstable = "";
      private string _strIdUNegocio = "";
      private string _strIdCCosto = "";
      private string _strIdPersonalIni = "";
      private string _strIdPersonalFin = "";

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

      /// <summary>
      /// Codigo Forma de Pago(B N)
      /// </summary>
      /// <value></value>
      /// <returns></returns>
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
      /// Proceso Anual Inicio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuProcAnualIni
      {
         get { return _intNuProcAnualIni; }
         set { _intNuProcAnualIni = value; }
      }

      /// <summary>
      /// Proceso Anual Hasta
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
      /// Código de UNegocio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdUNegocio
      {
         get { return _strIdUNegocio; }
         set { _strIdUNegocio = value; }
      }

      /// <summary>
      /// Código de UCCosto
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
      /// Código de Personal Inicio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPersonalIni
      {
         get { return _strIdPersonalIni; }
         set { _strIdPersonalIni = value; }
      }

      /// <summary>
      /// Código de Personal Fin
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPersonalFin
      {
         get { return _strIdPersonalFin; }
         set { _strIdPersonalFin = value; }
      }

      #endregion

   }
}
