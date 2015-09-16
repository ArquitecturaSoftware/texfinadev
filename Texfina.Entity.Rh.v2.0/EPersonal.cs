using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Personal (RH_Personal)
   /// </summary>
   [DataContract()]
   public class EPersonal : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strIdCliProv = "";
      private string _strNuFotocheck = "";
      private string _strIdEstable = "";
      private string _strIdSexo = "";
      private DateTime _datFeNacimien;
      private string _strIdNacional = "";
      private string _strNuRUC = "";
      private string _strStEsSalud = "";
      private string _strStDomiciliado = "";
      private string _strIdCateTrab = "";
      private string _strIdTipoTrab = "";
      private string _strIdCateOcupa = "";
      private string _strIdRegLaboral = "";
      private string _strIdNivEduc = "";
      private string _strIdOcupa = "";
      private string _strStDiscapa = "";
      private string _strIdRegPensi = "";
      private Nullable<DateTime> _datFeInscRegPen = null;
      private string _strNuCuspp = "";
      private string _strIdSctrSalud = "";
      private string _strIdSctrPens = "";
      private string _strIdTipoCont = "";
      private string _strStSujRegAlter = "";
      private string _strStJTMaxima = "";
      private string _strStJTHoraNoc = "";
      private string _strStJTAtipico = "";
      private string _strStOtrosIng5ta = "";
      private string _strStSindical = "";
      private string _strIdPeriRemu = "";
      private string _strIdSegMedi = "";
      private string _strIdEmpEps = "";
      private string _strIdSituEmple = "";
      private string _strSt5taExon = "";
      private string _strIdSitEspTrab = "";
      private string _strIdTipoRemu = "";
      private Nullable<DateTime> _datFeIngpla = null;
      private Nullable<DateTime> _datFeCese = null;
      private string _strIdMotivFin = "";
      private string _strStMadreResp = "";
      private string _strIdTipoCenFP = "";
      private string _strIdCentroFP = "";
      private string _strIdProvDest = "";
      private string _strIdEstaCivil = "";
      private string _strIdBcoAbono = "";
      private string _strIdTipoCtaAbo = "";
      private string _strNuCtaAbono = "";
      private string _strStAsigFami = "";
      private string _strIdBcoCts = "";
      private string _strNuCtaCts = "";
      private string _strIdUNegocio = "";
      private string _strIdCCosto = "";
      private string _strIdTipoSangre = "";
      private string _strDsEnfermedad = "";
      private string _strDsAlergia = "";
      private string _strDsPriAuxilios = "";
      private decimal _decNuTalla = 0;
      private decimal _decNuPeso = 0;
      private string _strDsTallaCalza = "";
      private string _strDsTallaPanta = "";
      private string _strDsTallaCamisa = "";
      private string _strDsClubSoDe = "";
      private string _strDsHobby = "";
      private string _strDsReligion = "";
      private string _strIdEstado = "";
      private int _intNuUltGen01 = 0;
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
      /// Código de Personal
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
      /// Código Cliente/Proveedor
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCliProv
      {
         get { return _strIdCliProv; }
         set { _strIdCliProv = value; }
      }

      /// <summary>
      /// Número de Fotocheck
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuFotocheck
      {
         get { return _strNuFotocheck; }
         set { _strNuFotocheck = value; }
      }

      /// <summary>
      /// Código de establecimiento
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
      /// Código de Sexo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSexo
      {
         get { return _strIdSexo; }
         set { _strIdSexo = value; }
      }

      /// <summary>
      /// Fecha de Nacimiento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public DateTime FeNacimien
      {
         get { return _datFeNacimien; }
         set { _datFeNacimien = value; }
      }

      /// <summary>
      /// Código Nacional
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdNacional
      {
         get { return _strIdNacional; }
         set { _strIdNacional = value; }
      }

      [DataMember()]
      public string NuRUC
      {
         get { return _strNuRUC; }
         set { _strNuRUC = value; }
      }

      /// <summary>
      /// Estado de ESSALUD
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StEsSalud
      {
         get { return _strStEsSalud; }
         set { _strStEsSalud = value; }
      }

      /// <summary>
      /// Estado Domiciliario
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StDomiciliado
      {
         get { return _strStDomiciliado; }
         set { _strStDomiciliado = value; }
      }

      [DataMember()]
      public string IdCateTrab
      {
         get { return _strIdCateTrab; }
         set { _strIdCateTrab = value; }
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
      /// Código Categoria del Personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCateOcupa
      {
         get { return _strIdCateOcupa; }
         set { _strIdCateOcupa = value; }
      }

      /// <summary>
      /// Código de Régimen Laboral
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
      /// Código Nivel de Educación
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdNivEduc
      {
         get { return _strIdNivEduc; }
         set { _strIdNivEduc = value; }
      }

      /// <summary>
      /// Categoría Ocupacional del trabajador
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
      /// Estado de Discapacidad
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StDiscapa
      {
         get { return _strStDiscapa; }
         set { _strStDiscapa = value; }
      }

      /// <summary>
      /// Código de Régimen Pensionario
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
      /// Fecha Inscripción del Régimen Pensionario
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
      /// Código de CUSPP (Solo para trabajadores afiliados a una AFP)
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
      /// Código de SCTR (Seguro Complementario de Trabajo Riesgo) - Salud
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
      /// Código de SCTR (Seguro Complementario de Trabajo Riesgo) - Pensión
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
      /// Tipo de Contrato de Trabajo
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
      /// Estado Sujeto a Régimen Alternativo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StSujRegAlter
      {
         get { return _strStSujRegAlter; }
         set { _strStSujRegAlter = value; }
      }

      /// <summary>
      /// Estado Sujeto a Jornada de trabajo Máxima
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StJTMaxima
      {
         get { return _strStJTMaxima; }
         set { _strStJTMaxima = value; }
      }

      /// <summary>
      /// Estado Sujeto a Trabajo horario Nocturno
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StJTHoraNoc
      {
         get { return _strStJTHoraNoc; }
         set { _strStJTHoraNoc = value; }
      }

      [DataMember()]
      public string StJTAtipico
      {
         get { return _strStJTAtipico; }
         set { _strStJTAtipico = value; }
      }

      /// <summary>
      /// Estado de Otros Ingresos de Quinta Categoría
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StOtrosIng5ta
      {
         get { return _strStOtrosIng5ta; }
         set { _strStOtrosIng5ta = value; }
      }

      /// <summary>
      /// Estado Sindicalizado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StSindical
      {
         get { return _strStSindical; }
         set { _strStSindical = value; }
      }

      /// <summary>
      /// Código Periodicidad de la remuneración o ingreso
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPeriRemu
      {
         get { return _strIdPeriRemu; }
         set { _strIdPeriRemu = value; }
      }

      /// <summary>
      /// Código de Seguro Médico
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
      /// Código de Empresa EPS
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
      /// Código Situación del Trabajador o Empleado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSituEmple
      {
         get { return _strIdSituEmple; }
         set { _strIdSituEmple = value; }
      }

      /// <summary>
      /// Estado de Rentas de 5ta Categoría Exoneradas
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string St5taExon
      {
         get { return _strSt5taExon; }
         set { _strSt5taExon = value; }
      }

      /// <summary>
      /// Código Situación de EPS del Trabajador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdSitEspTrab
      {
         get { return _strIdSitEspTrab; }
         set { _strIdSitEspTrab = value; }
      }

      /// <summary>
      /// Tipo de Remuneración
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoRemu
      {
         get { return _strIdTipoRemu; }
         set { _strIdTipoRemu = value; }
      }

      /// <summary>
      /// Fecha de Ingreso a Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeIngpla
      {
         get { return _datFeIngpla; }
         set { _datFeIngpla = value; }
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
      /// Código Motivo Final 
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdMotivFin
      {
         get { return _strIdMotivFin; }
         set { _strIdMotivFin = value; }
      }

      /// <summary>
      /// Estado Madre con Responsabilidad Familiar
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StMadreResp
      {
         get { return _strStMadreResp; }
         set { _strStMadreResp = value; }
      }

      /// <summary>
      /// Tipo de Centro de Formación Profesional
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoCenFP
      {
         get { return _strIdTipoCenFP; }
         set { _strIdTipoCenFP = value; }
      }

      [DataMember()]
      public string IdCentroFP
      {
         get { return _strIdCentroFP; }
         set { _strIdCentroFP = value; }
      }

      /// <summary>
      /// Código 
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdProvDest
      {
         get { return _strIdProvDest; }
         set { _strIdProvDest = value; }
      }

      /// <summary>
      /// Código Estado Civil
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEstaCivil
      {
         get { return _strIdEstaCivil; }
         set { _strIdEstaCivil = value; }
      }

      /// <summary>
      /// Código Banco de Abono
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
      /// Tipo Cuenta Abono
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
      /// Estado Asignación Familiar
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAsigFami
      {
         get { return _strStAsigFami; }
         set { _strStAsigFami = value; }
      }

      /// <summary>
      /// Código Banco CTS
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
      /// Número Cuenta de CTS
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
      /// Codigo de Unidad de Negocio
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
      /// Código de Centro de Costo
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
      /// Codigo de Tipo de Sangre
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoSangre
      {
         get { return _strIdTipoSangre; }
         set { _strIdTipoSangre = value; }
      }

      /// <summary>
      /// Descripcion de Enfermedad
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsEnfermedad
      {
         get { return _strDsEnfermedad; }
         set { _strDsEnfermedad = value; }
      }

      /// <summary>
      /// Descripcion Alergia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAlergia
      {
         get { return _strDsAlergia; }
         set { _strDsAlergia = value; }
      }

      /// <summary>
      /// Descripcion Primeros Auxilios
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsPriAuxilios
      {
         get { return _strDsPriAuxilios; }
         set { _strDsPriAuxilios = value; }
      }

      /// <summary>
      /// Talla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal NuTalla
      {
         get { return _decNuTalla; }
         set { _decNuTalla = value; }
      }

      /// <summary>
      /// Peso
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal NuPeso
      {
         get { return _decNuPeso; }
         set { _decNuPeso = value; }
      }

      /// <summary>
      /// Talla de Calzado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsTallaCalza
      {
         get { return _strDsTallaCalza; }
         set { _strDsTallaCalza = value; }
      }

      /// <summary>
      /// Talla de Pantalon
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsTallaPanta
      {
         get { return _strDsTallaPanta; }
         set { _strDsTallaPanta = value; }
      }

      /// <summary>
      /// Talla de Camisa
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsTallaCamisa
      {
         get { return _strDsTallaCamisa; }
         set { _strDsTallaCamisa = value; }
      }

      /// <summary>
      /// Descripcion de Club Social o Deportivo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsClubSoDe
      {
         get { return _strDsClubSoDe; }
         set { _strDsClubSoDe = value; }
      }

      /// <summary>
      /// Descripcion de Hobby
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsHobby
      {
         get { return _strDsHobby; }
         set { _strDsHobby = value; }
      }

      /// <summary>
      /// Descripcion de Religion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsReligion
      {
         get { return _strDsReligion; }
         set { _strDsReligion = value; }
      }

      /// <summary>
      /// Estado Aprobado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEstado
      {
         get { return _strIdEstado; }
         set { _strIdEstado = value; }
      }

      /// <summary>
      /// Último Número Generado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuUltGen01
      {
         get { return _intNuUltGen01; }
         set { _intNuUltGen01 = value; }
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
