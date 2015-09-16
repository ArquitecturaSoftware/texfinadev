using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Proceso Planilla Regimen (RH_ProcPlaReg)
   /// </summary>
   [DataContract()]
   public class EProcPlaReg : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnual = 0;
      private string _strIdPersonal = "";
      private string _strIdConRemu = "";
      private string _strIdTipRegula = "";
      private decimal _decNuHoras = 0;
      private decimal _decMtRegulaMn = 0;
      private decimal _decMtRegulaMe = 0;
      private string _strDsObserva = "";
      private string _strStAnulado = "";

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
      /// Forma de Pago
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
      /// Proceso Anual
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
      /// Código Concepto de Remuneración
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdConRemu
      {
         get { return _strIdConRemu; }
         set { _strIdConRemu = value; }
      }

      /// <summary>
      /// Tipo de Regularización
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipRegula
      {
          get { return _strIdTipRegula; }
          set { _strIdTipRegula = value; }
      }

      /// <summary>
      /// Número de Horas
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal NuHoras
      {
         get { return _decNuHoras; }
         set { _decNuHoras = value; }
      }

      /// <summary>
      /// Monto Regular de Moneda Nacional
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtRegulaMn
      {
         get { return _decMtRegulaMn; }
         set { _decMtRegulaMn = value; }
      }

      /// <summary>
      /// Monto Regular Mensual
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtRegulaMe
      {
         get { return _decMtRegulaMe; }
         set { _decMtRegulaMe = value; }
      }

      /// <summary>
      /// Observaciones
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsObserva
      {
          get { return _strDsObserva; }
          set { _strDsObserva = value; }
      }

      /// <summary>
      /// Estado Anulado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAnulado
      {
         get { return _strStAnulado; }
         set { _strStAnulado = value; }
      }

      #endregion

   }
}
