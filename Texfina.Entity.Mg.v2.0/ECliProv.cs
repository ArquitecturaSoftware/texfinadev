using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
    /// <summary>
    /// Entidad para la Tabla: Cliente/Proveedor (MG_CliProv)
    /// </summary>
    [DataContract()]
    public class ECliProv : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdCliProv = "";
        private string _strIdTipoCliProv = "";
        private string _strIdNatuJuri = "";
        private string _strDsRazSocial = "";
        private string _strDsRsAbrev = "";
        private string _strDsAPaterno = "";
        private string _strDsAMaterno = "";
        private string _strDsNombres = "";
        private string _strIdTDocIden = "";
        private string _strNuDocIden = "";
        private DateTime _datFeVenDocIden;
        private string _strIdPaisEmite = "";
        private string _strNuRuc = "";
        private string _strIdTipoVia = "";
        private string _strDsNombreVia = "";
        private string _strNuVia = "";
        private string _strNuDpto = "";
        private string _strNuInterior = "";
        private string _strDsManzana = "";
        private string _strDsLote = "";
        private string _strDsKilometro = "";
        private string _strDsBlock = "";
        private string _strDsEtapa = "";
        private string _strIdTipoZona = "";
        private string _strDsNombZona = "";
        private string _strDsReferen = "";
        private string _strNuTelf = "";
        private string _strNuFax = "";
        private string _strIdPais = "";
        private string _strIdDepa = "";
        private string _strIdProv = "";
        private string _strIdDist = "";
        private string _strDsEmail = "";
        private string _strDsWeb = "";
        private string _strStRegSis = "";
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
        /// Código de Cliente/Proveedor
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
        /// Código del Tipo Cliente Proveedor
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoCliProv
        {
            get { return _strIdTipoCliProv; }
            set { _strIdTipoCliProv = value; }
        }

        /// <summary>
        /// Código Natural/Juridica
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdNatuJuri
        {
            get { return _strIdNatuJuri; }
            set { _strIdNatuJuri = value; }
        }

        /// <summary>
        /// Descripción de Razón Social
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsRazSocial
        {
            get { return _strDsRazSocial; }
            set { _strDsRazSocial = value; }
        }

        /// <summary>
        /// Razón Social Abreviado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsRsAbrev
        {
            get { return _strDsRsAbrev; }
            set { _strDsRsAbrev = value; }
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
        /// Tipo de Documento de Identidad
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
        /// Número Documento de Identidad
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
        /// Fecha de Vencimiento Documento de Identidad
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public DateTime FeVenDocIden
        {
            get { return _datFeVenDocIden; }
            set { _datFeVenDocIden = value; }
        }

        /// <summary>
        /// País Emisor del Documento
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdPaisEmite
        {
            get { return _strIdPaisEmite; }
            set { _strIdPaisEmite = value; }
        }

        /// <summary>
        /// Número de RUC
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string NuRuc
        {
            get { return _strNuRuc; }
            set { _strNuRuc = value; }
        }

        /// <summary>
        /// Tipo de Vía
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoVia
        {
            get { return _strIdTipoVia; }
            set { _strIdTipoVia = value; }
        }

        /// <summary>
        /// Nombre de Vía
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsNombreVia
        {
            get { return _strDsNombreVia; }
            set { _strDsNombreVia = value; }
        }

        /// <summary>
        /// Número de Vía
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string NuVia
        {
            get { return _strNuVia; }
            set { _strNuVia = value; }
        }

        [DataMember()]
        public string NuDpto
        {
            get { return _strNuDpto; }
            set { _strNuDpto = value; }
        }

        /// <summary>
        /// Número Interior
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string NuInterior
        {
            get { return _strNuInterior; }
            set { _strNuInterior = value; }
        }

        [DataMember()]
        public string DsManzana
        {
            get { return _strDsManzana; }
            set { _strDsManzana = value; }
        }

        [DataMember()]
        public string DsLote
        {
            get { return _strDsLote; }
            set { _strDsLote = value; }
        }

        [DataMember()]
        public string DsKilometro
        {
            get { return _strDsKilometro; }
            set { _strDsKilometro = value; }
        }

        [DataMember()]
        public string DsBlock
        {
            get { return _strDsBlock; }
            set { _strDsBlock = value; }
        }

        [DataMember()]
        public string DsEtapa
        {
            get { return _strDsEtapa; }
            set { _strDsEtapa = value; }
        }

        /// <summary>
        /// Código Tipo Zona
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoZona
        {
            get { return _strIdTipoZona; }
            set { _strIdTipoZona = value; }
        }

        /// <summary>
        /// Descripción Nombre de la Zona
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsNombZona
        {
            get { return _strDsNombZona; }
            set { _strDsNombZona = value; }
        }

        /// <summary>
        /// Descripción de Referencia
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsReferen
        {
            get { return _strDsReferen; }
            set { _strDsReferen = value; }
        }

        /// <summary>
        /// Número de Telefono
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
        /// Número de Fax
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string NuFax
        {
            get { return _strNuFax; }
            set { _strNuFax = value; }
        }

        /// <summary>
        /// Código de País
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdPais
        {
            get { return _strIdPais; }
            set { _strIdPais = value; }
        }

        /// <summary>
        /// Código de Departamento
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdDepa
        {
            get { return _strIdDepa; }
            set { _strIdDepa = value; }
        }

        /// <summary>
        /// Código de Provincia
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdProv
        {
            get { return _strIdProv; }
            set { _strIdProv = value; }
        }

        /// <summary>
        /// Código de Distrito
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdDist
        {
            get { return _strIdDist; }
            set { _strIdDist = value; }
        }

        /// <summary>
        /// Descripción de Email
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
        /// Descripción de Web
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsWeb
        {
            get { return _strDsWeb; }
            set { _strDsWeb = value; }
        }

        /// <summary>
        /// Estado Registro del Sistema
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string StRegSis
        {
            get { return _strStRegSis; }
            set { _strStRegSis = value; }
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
