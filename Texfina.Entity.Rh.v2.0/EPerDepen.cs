using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Personal DerechoHabientes (RH_PerDepen)
   /// </summary>
   [DataContract()]
   public class EPerDepen : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private int _intNuSecuen = 0;
      private string _strIdTDocIden = "";
      private string _strNuDocIden = "";
      private string _strIdPaisEmiDoc = "";
      private DateTime _datFeNacimien;
      private string _strDsAPaterno = "";
      private string _strDsAMaterno = "";
      private string _strDsNombres = "";
      private string _strIdSexo = "";
      private string _strIdVincFam = "";
      private string _strIdTipoDocAcre = "";
      private string _strNuDocAcre = "";
      private string _strNuMesConcep = "";
      private string _strIdTipoVia1 = "";
      private string _strDsNombreVia1 = "";
      private string _strNuVia1 = "";
      private string _strNuDepa1 = "";
      private string _strNuInterior1 = "";
      private string _strNuMz1 = "";
      private string _strNuLote1 = "";
      private string _strNuKm1 = "";
      private string _strNuBlock1 = "";
      private string _strDsEtapa1 = "";
      private string _strIdTipoZona1 = "";
      private string _strDsNombZona1 = "";
      private string _strDsReferen1 = "";
      private string _strIdPais1 = "";
      private string _strIdDepa1 = "";
      private string _strIdProv1 = "";
      private string _strIdDist1 = "";
      private string _strIdTipoVia2 = "";
      private string _strDsNombreVia2 = "";
      private string _strNuVia2 = "";
      private string _strNuDepa2 = "";
      private string _strNuInterior2 = "";
      private string _strNuMz2 = "";
      private string _strNuLote2 = "";
      private string _strNuKm2 = "";
      private string _strNuBlock2 = "";
      private string _strDsEtapa2 = "";
      private string _strIdTipoZona2 = "";
      private string _strDsNombZona2 = "";
      private string _strDsReferen2 = "";
      private string _strIdPais2 = "";
      private string _strIdDepa2 = "";
      private string _strIdProv2 = "";
      private string _strIdDist2 = "";
      private string _strStAsisEsSalud = "";
      private string _strNuTlfCodLDN = "";
      private string _strNuTelf = "";
      private string _strDsEmail = "";
      private Nullable<DateTime> _datFeBaja = null;
      private string _strIdMotivBaja = null;
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
      /// Número de Secuencia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuSecuen
      {
         get { return _intNuSecuen; }
         set { _intNuSecuen = value; }
      }

      /// <summary>
      /// Tipo de Documento de Identidad del Personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTDocIden
      {
         get { return _strIdTDocIden; }
         set { _strIdTDocIden = value; }
      }

      /// <summary>
      /// Número de Documento de Identidad del Personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuDocIden
      {
         get { return _strNuDocIden; }
         set { _strNuDocIden = value; }
      }

      /// <summary>
      /// País Emisor del Documento

      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPaisEmiDoc
      {
         get { return _strIdPaisEmiDoc; }
         set { _strIdPaisEmiDoc = value; }
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
      /// Apellido Paterno 
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAPaterno
      {
         get { return _strDsAPaterno; }
         set { _strDsAPaterno = value; }
      }

      /// <summary>
      /// Apellido Materno 
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAMaterno
      {
         get { return _strDsAMaterno; }
         set { _strDsAMaterno = value; }
      }

      /// <summary>
      /// Nombres
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsNombres
      {
         get { return _strDsNombres; }
         set { _strDsNombres = value; }
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
      /// Código de Vínculo Familiar
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdVincFam
      {
         get { return _strIdVincFam; }
         set { _strIdVincFam = value; }
      }

      /// <summary>
      /// Tipo de Documento que Acredita el Vínculo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoDocAcre
      {
         get { return _strIdTipoDocAcre; }
         set { _strIdTipoDocAcre = value; }
      }

      /// <summary>
      /// Número de Documento que Acredita el Vínculo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuDocAcre
      {
         get { return _strNuDocAcre; }
         set { _strNuDocAcre = value; }
      }

      /// <summary>
      /// Mes de Concepción
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuMesConcep
      {
         get { return _strNuMesConcep; }
         set { _strNuMesConcep = value; }
      }

      /// <summary>
      /// Tipo de Vía
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoVia1
      {
         get { return _strIdTipoVia1; }
         set { _strIdTipoVia1 = value; }
      }

      /// <summary>
      /// Nombre de Vía
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsNombreVia1
      {
         get { return _strDsNombreVia1; }
         set { _strDsNombreVia1 = value; }
      }

      /// <summary>
      /// Número de Vía
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuVia1
      {
         get { return _strNuVia1; }
         set { _strNuVia1 = value; }
      }

      /// <summary>
      /// Número de Departamento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuDepa1
      {
         get { return _strNuDepa1; }
         set { _strNuDepa1 = value; }
      }

      /// <summary>
      /// Número Interior
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuInterior1
      {
         get { return _strNuInterior1; }
         set { _strNuInterior1 = value; }
      }

      /// <summary>
      /// Descripción de Manzana
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuMz1
      {
         get { return _strNuMz1; }
         set { _strNuMz1 = value; }
      }

      /// <summary>
      /// Número de Lote
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuLote1
      {
         get { return _strNuLote1; }
         set { _strNuLote1 = value; }
      }

      /// <summary>
      /// Número de Kilometro
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuKm1
      {
         get { return _strNuKm1; }
         set { _strNuKm1 = value; }
      }

      /// <summary>
      /// Número de Block
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuBlock1
      {
         get { return _strNuBlock1; }
         set { _strNuBlock1 = value; }
      }

      /// <summary>
      /// Descripción de Etapa
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsEtapa1
      {
         get { return _strDsEtapa1; }
         set { _strDsEtapa1 = value; }
      }

      /// <summary>
      /// Tipo de Zona
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoZona1
      {
         get { return _strIdTipoZona1; }
         set { _strIdTipoZona1 = value; }
      }

      /// <summary>
      /// Nombre de Zona
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsNombZona1
      {
         get { return _strDsNombZona1; }
         set { _strDsNombZona1 = value; }
      }

      /// <summary>
      /// Descripción de Referencia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsReferen1
      {
         get { return _strDsReferen1; }
         set { _strDsReferen1 = value; }
      }

      /// <summary>
      /// Código de País
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPais1
      {
         get { return _strIdPais1; }
         set { _strIdPais1 = value; }
      }

      /// <summary>
      /// Código de Departamento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdDepa1
      {
         get { return _strIdDepa1; }
         set { _strIdDepa1 = value; }
      }

      /// <summary>
      /// Código de Provincia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdProv1
      {
         get { return _strIdProv1; }
         set { _strIdProv1 = value; }
      }

      /// <summary>
      /// Código de Distrito
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdDist1
      {
         get { return _strIdDist1; }
         set { _strIdDist1 = value; }
      }

      /// <summary>
      /// Tipo de Vía
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoVia2
      {
         get { return _strIdTipoVia2; }
         set { _strIdTipoVia2 = value; }
      }

      /// <summary>
      /// Nombre de Vía
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsNombreVia2
      {
         get { return _strDsNombreVia2; }
         set { _strDsNombreVia2 = value; }
      }

      /// <summary>
      /// Número de Vía
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuVia2
      {
         get { return _strNuVia2; }
         set { _strNuVia2 = value; }
      }

      /// <summary>
      /// Número de Departamento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuDepa2
      {
         get { return _strNuDepa2; }
         set { _strNuDepa2 = value; }
      }

      /// <summary>
      /// Número Interior
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuInterior2
      {
         get { return _strNuInterior2; }
         set { _strNuInterior2 = value; }
      }

      /// <summary>
      /// Descripción de Manzana
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuMz2
      {
         get { return _strNuMz2; }
         set { _strNuMz2 = value; }
      }

      /// <summary>
      /// Número de Lote
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuLote2
      {
         get { return _strNuLote2; }
         set { _strNuLote2 = value; }
      }

      /// <summary>
      /// Número de Kilometro
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuKm2
      {
         get { return _strNuKm2; }
         set { _strNuKm2 = value; }
      }

      /// <summary>
      /// Número de Block
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuBlock2
      {
         get { return _strNuBlock2; }
         set { _strNuBlock2 = value; }
      }

      /// <summary>
      /// Descripción de Etapa
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsEtapa2
      {
         get { return _strDsEtapa2; }
         set { _strDsEtapa2 = value; }
      }

      /// <summary>
      /// Tipo de Zona
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoZona2
      {
         get { return _strIdTipoZona2; }
         set { _strIdTipoZona2 = value; }
      }

      /// <summary>
      /// Nombre de Zona
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsNombZona2
      {
         get { return _strDsNombZona2; }
         set { _strDsNombZona2 = value; }
      }

      /// <summary>
      /// Descripción de Referencia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsReferen2
      {
         get { return _strDsReferen2; }
         set { _strDsReferen2 = value; }
      }

      /// <summary>
      /// Código de País
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPais2
      {
         get { return _strIdPais2; }
         set { _strIdPais2 = value; }
      }

      /// <summary>
      /// Código de Departamento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdDepa2
      {
         get { return _strIdDepa2; }
         set { _strIdDepa2 = value; }
      }

      /// <summary>
      /// Código de Provincia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdProv2
      {
         get { return _strIdProv2; }
         set { _strIdProv2 = value; }
      }

      /// <summary>
      /// Código de Distrito
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdDist2
      {
         get { return _strIdDist2; }
         set { _strIdDist2 = value; }
      }

      /// <summary>
      /// Descripción del Indicador Centro Asistencial ESSALUD
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAsisEsSalud
      {
         get { return _strStAsisEsSalud; }
         set { _strStAsisEsSalud = value; }
      }

      /// <summary>
      /// Número de Teléfono - Código de Larga Distancia Nacional
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuTlfCodLDN
      {
         get { return _strNuTlfCodLDN; }
         set { _strNuTlfCodLDN = value; }
      }

      /// <summary>
      /// Número de Teléfono
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuTelf
      {
         get { return _strNuTelf; }
         set { _strNuTelf = value; }
      }

      /// <summary>
      /// Descripción del Correo Electrónico
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsEmail
      {
         get { return _strDsEmail; }
         set { _strDsEmail = value; }
      }

      /// <summary>
      /// Fecha de Baja
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeBaja
      {
         get { return _datFeBaja; }
         set { _datFeBaja = value; }
      }

      /// <summary>
      /// Motivo de Baja
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdMotivBaja
      {
         get { return _strIdMotivBaja; }
         set { _strIdMotivBaja = value; }
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
