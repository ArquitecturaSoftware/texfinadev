using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_ProcPlaCalc (RH_ProcPlaCalc)
   /// </summary>
   [DataContract()]
   public class EProcPlaCalc : IEntityBase
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
      private string _strStOrigen = "";
      private int _intNuSecuen = 0;
      private string _strIdMes = "";
      private decimal _decNuHoras = 0;
      private decimal _decMtSubCalc = 0;
      private decimal _decMtCalculo = 0;
      private decimal _decMtCalcMe = 0;
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
      /// Estado de Origen
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StOrigen
      {
         get { return _strStOrigen; }
         set { _strStOrigen = value; }
      }

      /// <summary>
      /// Numero de Secuencia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuSecuen
      {
         get { return _intNuSecuen; }
         set { _intNuSecuen = value; }
      }

      [DataMember()]
      public string IdMes
      {
         get { return _strIdMes; }
         set { _strIdMes = value; }
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
      /// Monto Sub Cálculo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtSubCalc
      {
         get { return _decMtSubCalc; }
         set { _decMtSubCalc = value; }
      }

      /// <summary>
      /// Monto de Cálculo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtCalculo
      {
         get { return _decMtCalculo; }
         set { _decMtCalculo = value; }
      }

      /// <summary>
      /// Monto de Cálculo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtCalcMe
      {
         get { return _decMtCalcMe; }
         set { _decMtCalcMe = value; }
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
