using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Pd
{
   /// <summary>
   /// Entidad para la Tabla: Personal (RH_Personal)
   /// </summary>
   [DataContract()]
   public class ECliente : IEntityBase
   {

       #region Campos

       private EntityState _intState = EntityState.Unchanged;
       private string _strIdEmpresa = "";
       private string _strIdCliente = "";
       private string _strNuNIF = null;
       private string _strDsRazSocial = null;
       private string _strDsRazSocial2 = null;
       private string _strDsDireccion = null;
       private string _strDsDireccion2 = null;
       private string _strDsDistrito = null;
       private string _strNuCodPostal = null;
       private string _strIdTipCliente = null;
       private string _strNuTelf01 = null;
       private string _strNuTelf02 = null;
       private string _strNuTelf03 = null;
       private string _strNuFax = null;
       private string _strDsEmail = null;
       private string _strDsClienteAlias = null;
       private string _strNuIniVac = null;
       private string _strNuFinVac = null;
       private string _strNuDesplaza = null;
       private string _strIdEtiqueta = null;
       private string _strIdUrgencia = null;
       private string _strDsPersonaRef = null;
       private string _strObsPersonaRef = null;
       private string _strNuCuenta = null;
       private string _strIdPeriodoFac = null;
       private string _strIdAgruAlbaran = null;
       private string _strIdTipoCliente = null;
       private string _strIdReqNombre = null;
       private string _strIdReqEtiqueta = null;
       private string _strNuCopiasFac = null;
       private string _strNuCopiasAlba = null;
       private string _strIdZona = null;
       private string _strIdTubos = null;
       private string _strIdControl = null;
       private string _strIdAlbaranValor = null;
       private string _strIdDivisa = null;
       private string _strIdTransportista = null;
       private string _strIdPortes = null;
       private Nullable<decimal> _decMtRiesgoConce = null;
       private Nullable<decimal> _decMtRiesgoCircu = null;
       private Nullable<decimal> _decMtRiesgoMayor = null;
       private Nullable<DateTime> _datFeRiesgoReg = null;
       private string _strIdClieEnvio = null;
       private string _strDsNomEnvio = null;
       private string _strDsDomiEnvio = null;
       private string _strDsDistritoEnvio = null;
       private string _strNuCodPostalEnvio = null;
       private string _strIdZonaEnvio = null;
       private string _strIdPagoCliente = null;
       private string _strDsNomPago = null;
       private string _strDsDomiPago = null;
       private string _strDsDistritoPago = null;
       private string _strIdZonaPago = null;
       private string _strIdCtaBanPago1 = null;
       private string _strNuCtaBanPago1 = null;
       private string _strIdCtaBanPago2 = null;
       private string _strNuCtaBanPago2 = null;
       private string _strIdPrioridad = null;
       private string _strDsNroVnto = null;
       private string _strIdFormaPago = null;
       private Nullable<decimal> _decMtDepPronPago = null;
       private Nullable<decimal> _decMtDepGeneral = null;
       private string _strDsPeriodoPago = null;
       private string _strIdRegimen = null;
       private string _strObsCliente = null;
       private string _strIdEstado = null;
       private string _strStAnulado = null;

       #endregion

       #region Atributos

       [DataMember()]
       public EntityState EntityState
       {
           get { return _intState; }
           set { _intState = value; }
       }

       [DataMember()]
       public string IdEmpresa
       {
           get { return _strIdEmpresa; }
           set { _strIdEmpresa = value; }
       }

       [DataMember()]
       public string IdCliente
       {
           get { return _strIdCliente; }
           set { _strIdCliente = value; }
       }

       [DataMember()]
       public string NuNIF
       {
           get { return _strNuNIF; }
           set { _strNuNIF = value; }
       }

       [DataMember()]
       public string DsRazSocial
       {
           get { return _strDsRazSocial; }
           set { _strDsRazSocial = value; }
       }

       [DataMember()]
       public string DsRazSocial2
       {
           get { return _strDsRazSocial2; }
           set { _strDsRazSocial2 = value; }
       }

       [DataMember()]
       public string DsDireccion
       {
           get { return _strDsDireccion; }
           set { _strDsDireccion = value; }
       }

       [DataMember()]
       public string DsDireccion2
       {
           get { return _strDsDireccion2; }
           set { _strDsDireccion2 = value; }
       }

       [DataMember()]
       public string DsDistrito
       {
           get { return _strDsDistrito; }
           set { _strDsDistrito = value; }
       }

       [DataMember()]
       public string NuCodPostal
       {
           get { return _strNuCodPostal; }
           set { _strNuCodPostal = value; }
       }

       [DataMember()]
       public string IdTipCliente
       {
           get { return _strIdTipCliente; }
           set { _strIdTipCliente = value; }
       }

       [DataMember()]
       public string NuTelf01
       {
           get { return _strNuTelf01; }
           set { _strNuTelf01 = value; }
       }

       [DataMember()]
       public string NuTelf02
       {
           get { return _strNuTelf02; }
           set { _strNuTelf02 = value; }
       }

       [DataMember()]
       public string NuTelf03
       {
           get { return _strNuTelf03; }
           set { _strNuTelf03 = value; }
       }

       [DataMember()]
       public string NuFax
       {
           get { return _strNuFax; }
           set { _strNuFax = value; }
       }

       [DataMember()]
       public string DsEmail
       {
           get { return _strDsEmail; }
           set { _strDsEmail = value; }
       }

       [DataMember()]
       public string DsClienteAlias
       {
           get { return _strDsClienteAlias; }
           set { _strDsClienteAlias = value; }
       }

       [DataMember()]
       public string NuIniVac
       {
           get { return _strNuIniVac; }
           set { _strNuIniVac = value; }
       }

       [DataMember()]
       public string NuFinVac
       {
           get { return _strNuFinVac; }
           set { _strNuFinVac = value; }
       }

       [DataMember()]
       public string NuDesplaza
       {
           get { return _strNuDesplaza; }
           set { _strNuDesplaza = value; }
       }

       [DataMember()]
       public string IdEtiqueta
       {
           get { return _strIdEtiqueta; }
           set { _strIdEtiqueta = value; }
       }

       [DataMember()]
       public string IdUrgencia
       {
           get { return _strIdUrgencia; }
           set { _strIdUrgencia = value; }
       }

       [DataMember()]
       public string DsPersonaRef
       {
           get { return _strDsPersonaRef; }
           set { _strDsPersonaRef = value; }
       }

       [DataMember()]
       public string ObsPersonaRef
       {
           get { return _strObsPersonaRef; }
           set { _strObsPersonaRef = value; }
       }

       [DataMember()]
       public string NuCuenta
       {
           get { return _strNuCuenta; }
           set { _strNuCuenta = value; }
       }

       [DataMember()]
       public string IdPeriodoFac
       {
           get { return _strIdPeriodoFac; }
           set { _strIdPeriodoFac = value; }
       }

       [DataMember()]
       public string IdAgruAlbaran
       {
           get { return _strIdAgruAlbaran; }
           set { _strIdAgruAlbaran = value; }
       }

       [DataMember()]
       public string IdTipoCliente
       {
           get { return _strIdTipoCliente; }
           set { _strIdTipoCliente = value; }
       }

       [DataMember()]
       public string IdReqNombre
       {
           get { return _strIdReqNombre; }
           set { _strIdReqNombre = value; }
       }

       [DataMember()]
       public string IdReqEtiqueta
       {
           get { return _strIdReqEtiqueta; }
           set { _strIdReqEtiqueta = value; }
       }

       [DataMember()]
       public string NuCopiasFac
       {
           get { return _strNuCopiasFac; }
           set { _strNuCopiasFac = value; }
       }

       [DataMember()]
       public string NuCopiasAlba
       {
           get { return _strNuCopiasAlba; }
           set { _strNuCopiasAlba = value; }
       }

       [DataMember()]
       public string IdZona
       {
           get { return _strIdZona; }
           set { _strIdZona = value; }
       }

       [DataMember()]
       public string IdTubos
       {
           get { return _strIdTubos; }
           set { _strIdTubos = value; }
       }

       [DataMember()]
       public string IdControl
       {
           get { return _strIdControl; }
           set { _strIdControl = value; }
       }

       [DataMember()]
       public string IdAlbaranValor
       {
           get { return _strIdAlbaranValor; }
           set { _strIdAlbaranValor = value; }
       }

       [DataMember()]
       public string IdDivisa
       {
           get { return _strIdDivisa; }
           set { _strIdDivisa = value; }
       }

       [DataMember()]
       public string IdTransportista
       {
           get { return _strIdTransportista; }
           set { _strIdTransportista = value; }
       }

       [DataMember()]
       public string IdPortes
       {
           get { return _strIdPortes; }
           set { _strIdPortes = value; }
       }

       [DataMember()]
       public Nullable<decimal> MtRiesgoConce
       {
           get { return _decMtRiesgoConce; }
           set { _decMtRiesgoConce = value; }
       }

       [DataMember()]
       public Nullable<decimal> MtRiesgoCircu
       {
           get { return _decMtRiesgoCircu; }
           set { _decMtRiesgoCircu = value; }
       }

       [DataMember()]
       public Nullable<decimal> MtRiesgoMayor
       {
           get { return _decMtRiesgoMayor; }
           set { _decMtRiesgoMayor = value; }
       }

       [DataMember()]
       public Nullable<DateTime> FeRiesgoReg
       {
           get { return _datFeRiesgoReg; }
           set { _datFeRiesgoReg = value; }
       }

       [DataMember()]
       public string IdClieEnvio
       {
           get { return _strIdClieEnvio; }
           set { _strIdClieEnvio = value; }
       }

       [DataMember()]
       public string DsNomEnvio
       {
           get { return _strDsNomEnvio; }
           set { _strDsNomEnvio = value; }
       }

       [DataMember()]
       public string DsDomiEnvio
       {
           get { return _strDsDomiEnvio; }
           set { _strDsDomiEnvio = value; }
       }

       [DataMember()]
       public string DsDistritoEnvio
       {
           get { return _strDsDistritoEnvio; }
           set { _strDsDistritoEnvio = value; }
       }

       [DataMember()]
       public string NuCodPostalEnvio
       {
           get { return _strNuCodPostalEnvio; }
           set { _strNuCodPostalEnvio = value; }
       }

       [DataMember()]
       public string IdZonaEnvio
       {
           get { return _strIdZonaEnvio; }
           set { _strIdZonaEnvio = value; }
       }

       [DataMember()]
       public string IdPagoCliente
       {
           get { return _strIdPagoCliente; }
           set { _strIdPagoCliente = value; }
       }

       [DataMember()]
       public string DsNomPago
       {
           get { return _strDsNomPago; }
           set { _strDsNomPago = value; }
       }

       [DataMember()]
       public string DsDomiPago
       {
           get { return _strDsDomiPago; }
           set { _strDsDomiPago = value; }
       }

       [DataMember()]
       public string DsDistritoPago
       {
           get { return _strDsDistritoPago; }
           set { _strDsDistritoPago = value; }
       }

       [DataMember()]
       public string IdZonaPago
       {
           get { return _strIdZonaPago; }
           set { _strIdZonaPago = value; }
       }

       [DataMember()]
       public string IdCtaBanPago1
       {
           get { return _strIdCtaBanPago1; }
           set { _strIdCtaBanPago1 = value; }
       }

       [DataMember()]
       public string NuCtaBanPago1
       {
           get { return _strNuCtaBanPago1; }
           set { _strNuCtaBanPago1 = value; }
       }

       [DataMember()]
       public string IdCtaBanPago2
       {
           get { return _strIdCtaBanPago2; }
           set { _strIdCtaBanPago2 = value; }
       }

       [DataMember()]
       public string NuCtaBanPago2
       {
           get { return _strNuCtaBanPago2; }
           set { _strNuCtaBanPago2 = value; }
       }

       [DataMember()]
       public string IdPrioridad
       {
           get { return _strIdPrioridad; }
           set { _strIdPrioridad = value; }
       }

       [DataMember()]
       public string DsNroVnto
       {
           get { return _strDsNroVnto; }
           set { _strDsNroVnto = value; }
       }

       [DataMember()]
       public string IdFormaPago
       {
           get { return _strIdFormaPago; }
           set { _strIdFormaPago = value; }
       }

       [DataMember()]
       public Nullable<decimal> MtDepPronPago
       {
           get { return _decMtDepPronPago; }
           set { _decMtDepPronPago = value; }
       }

       [DataMember()]
       public Nullable<decimal> MtDepGeneral
       {
           get { return _decMtDepGeneral; }
           set { _decMtDepGeneral = value; }
       }

       [DataMember()]
       public string DsPeriodoPago
       {
           get { return _strDsPeriodoPago; }
           set { _strDsPeriodoPago = value; }
       }

       [DataMember()]
       public string IdRegimen
       {
           get { return _strIdRegimen; }
           set { _strIdRegimen = value; }
       }

       [DataMember()]
       public string ObsCliente
       {
           get { return _strObsCliente; }
           set { _strObsCliente = value; }
       }

       [DataMember()]
       public string IdEstado
       {
           get { return _strIdEstado; }
           set { _strIdEstado = value; }
       }

       [DataMember()]
       public string StAnulado
       {
           get { return _strStAnulado; }
           set { _strStAnulado = value; }
       }

       #endregion

   }
}
