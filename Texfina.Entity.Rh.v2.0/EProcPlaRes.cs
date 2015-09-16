using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_ProcPlaRes (RH_ProcPlaRes)
   /// </summary>
   [DataContract()]
   public class EProcPlaRes : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnual = 0;
      private string _strIdPersonal = "";
      private string _strIdMes = null;
      private string _strIdTipoTrab = "";
      private string _strIdRegLaboral = "";
      private string _strIdOcupa = "";
      private string _strIdRegPensi = "";
      private Nullable<DateTime> _datFeInscRegPen = null;
      private string _strNuCuspp = "";
      private string _strIdSctrSalud = "";
      private string _strIdSctrPens = "";
      private string _strIdTipoCont = "";
      private string _strIdSegMedi = "";
      private string _strIdEmpEps = "";
      private string _strIdSituEmplEps = "";
      private string _strIdSitEsptrab = "";
      private Nullable<DateTime> _datFeIngPla = null;
      private Nullable<DateTime> _datFeCese = null;
      private string _strIdBcoAbono = "";
      private string _strIdTipoCtaAbo = "";
      private string _strNuCtaAbono = "";
      private string _strIdBcoCts = "";
      private string _strNuCtaCts = "";
      private string _strIdCCosto = "";
      private decimal _decMtRemu = 0;
      private decimal _decMtTotRemuMn = 0;
      private decimal _decMtTotDescMn = 0;
      private decimal _decMtTotAportMn = 0;
      private decimal _decMtRedAntMn = 0;
      private decimal _decMtRedActMn = 0;
      private decimal _decMtNetoMn = 0;
      private decimal _decMtTotRemuMe = 0;
      private decimal _decMtTotDescMe = 0;
      private decimal _decMtTotAportMe = 0;
      private decimal _decMtRedAntMe = 0;
      private decimal _decMtRedActMe = 0;
      private decimal _decMtNetoMe = 0;
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
      /// Código de Mes
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdMes
      {
         get { return _strIdMes; }
         set { _strIdMes = value; }
      }

      /// <summary>
      /// Tipo de Trabajo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoTrab
      {
         get { return _strIdTipoTrab; }
         set { _strIdTipoTrab = value; }
      }

      /// <summary>
      /// Código del Régimen Laboral
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdRegLaboral
      {
         get { return _strIdRegLaboral; }
         set { _strIdRegLaboral = value; }
      }

      /// <summary>
      /// Código de Ocupación
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdOcupa
      {
         get { return _strIdOcupa; }
         set { _strIdOcupa = value; }
      }

      /// <summary>
      /// Código del Régimen Pensionario
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdRegPensi
      {
         get { return _strIdRegPensi; }
         set { _strIdRegPensi = value; }
      }

      /// <summary>
      /// Fecha de Inscripción del Regimen de Pensión
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeInscRegPen
      {
         get { return _datFeInscRegPen; }
         set { _datFeInscRegPen = value; }
      }

      /// <summary>
      /// Número CUSPP
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuCuspp
      {
         get { return _strNuCuspp; }
         set { _strNuCuspp = value; }
      }

      /// <summary>
      /// Código de SCTR - Salud
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSctrSalud
      {
         get { return _strIdSctrSalud; }
         set { _strIdSctrSalud = value; }
      }

      /// <summary>
      /// Código de SCTR - Pensión
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSctrPens
      {
         get { return _strIdSctrPens; }
         set { _strIdSctrPens = value; }
      }

      /// <summary>
      /// Código Tipo de Contrato
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoCont
      {
         get { return _strIdTipoCont; }
         set { _strIdTipoCont = value; }
      }

      /// <summary>
      /// Código de Seguro Medico
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSegMedi
      {
         get { return _strIdSegMedi; }
         set { _strIdSegMedi = value; }
      }

      /// <summary>
      /// Código de Emp. EPS
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEmpEps
      {
         get { return _strIdEmpEps; }
         set { _strIdEmpEps = value; }
      }

      /// <summary>
      /// Código Situación de Emp EPS
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSituEmplEps
      {
         get { return _strIdSituEmplEps; }
         set { _strIdSituEmplEps = value; }
      }

      /// <summary>
      /// Código Situación EPS de Trabajador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSitEsptrab
      {
         get { return _strIdSitEsptrab; }
         set { _strIdSitEsptrab = value; }
      }

      /// <summary>
      /// Fecha de Ingreso a Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeIngPla
      {
         get { return _datFeIngPla; }
         set { _datFeIngPla = value; }
      }

      /// <summary>
      /// Fecha de Cese
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeCese
      {
         get { return _datFeCese; }
         set { _datFeCese = value; }
      }

      /// <summary>
      /// Código del Banco de Abono
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdBcoAbono
      {
         get { return _strIdBcoAbono; }
         set { _strIdBcoAbono = value; }
      }

      /// <summary>
      /// Tipo Cuenta de Abono
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoCtaAbo
      {
         get { return _strIdTipoCtaAbo; }
         set { _strIdTipoCtaAbo = value; }
      }

      /// <summary>
      /// Número Cuenta de Abono
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuCtaAbono
      {
         get { return _strNuCtaAbono; }
         set { _strNuCtaAbono = value; }
      }

      /// <summary>
      /// Código de Banco CTS
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdBcoCts
      {
         get { return _strIdBcoCts; }
         set { _strIdBcoCts = value; }
      }

      /// <summary>
      /// Número de Cuenta CTS
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuCtaCts
      {
         get { return _strNuCtaCts; }
         set { _strNuCtaCts = value; }
      }

      /// <summary>
      /// Código del Centro de Costo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCCosto
      {
         get { return _strIdCCosto; }
         set { _strIdCCosto = value; }
      }

      [DataMember()]
      public decimal MtRemu
      {
         get { return _decMtRemu; }
         set { _decMtRemu = value; }
      }

      /// <summary>
      /// Monto Total  Remuneración de Moneda Nacional de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTotRemuMn
      {
         get { return _decMtTotRemuMn; }
         set { _decMtTotRemuMn = value; }
      }

      /// <summary>
      /// Monto Total Descuento de Moneda Nacional de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTotDescMn
      {
         get { return _decMtTotDescMn; }
         set { _decMtTotDescMn = value; }
      }

      /// <summary>
      /// Monto Total de Aportaciones de Moneda Nacional de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTotAportMn
      {
         get { return _decMtTotAportMn; }
         set { _decMtTotAportMn = value; }
      }

      /// <summary>
      /// Monto Red Anterior de Moneda Nacional de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtRedAntMn
      {
         get { return _decMtRedAntMn; }
         set { _decMtRedAntMn = value; }
      }

      /// <summary>
      /// Monto Red Actual de Moneda Nacional de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtRedActMn
      {
         get { return _decMtRedActMn; }
         set { _decMtRedActMn = value; }
      }

      [DataMember()]
      public decimal MtNetoMn
      {
         get { return _decMtNetoMn; }
         set { _decMtNetoMn = value; }
      }

      /// <summary>
      /// Monto Total de Remuneración Mensual de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTotRemuMe
      {
         get { return _decMtTotRemuMe; }
         set { _decMtTotRemuMe = value; }
      }

      /// <summary>
      /// Monto Total de Descuento Mensual de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTotDescMe
      {
         get { return _decMtTotDescMe; }
         set { _decMtTotDescMe = value; }
      }

      /// <summary>
      /// Monto Total de Aportación Mensual de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTotAportMe
      {
         get { return _decMtTotAportMe; }
         set { _decMtTotAportMe = value; }
      }

      /// <summary>
      /// Monto de Red Anterior Mensual de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtRedAntMe
      {
         get { return _decMtRedAntMe; }
         set { _decMtRedAntMe = value; }
      }

      /// <summary>
      /// Monto Red Actual Mensual de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtRedActMe
      {
         get { return _decMtRedActMe; }
         set { _decMtRedActMe = value; }
      }

      [DataMember()]
      public decimal MtNetoMe
      {
         get { return _decMtNetoMe; }
         set { _decMtNetoMe = value; }
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
