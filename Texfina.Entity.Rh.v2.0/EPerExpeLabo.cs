using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: Experiencia Laboral del Personal (RH_PerExpeLabo)
    /// </summary>
    [DataContract()]
    public class EPerExpeLabo : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPersonal = "";
        private int _intNuSecuen = 0;
        private string _strDsEmpresa = "";
        private string _strIdOcupa = "";
        private DateTime _datFeInicio;
        private DateTime _datFeFin;
        private string _strDsDescripOcupa = "";
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
        /// Empresa donde laboro
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsEmpresa
        {
            get { return _strDsEmpresa; }
            set { _strDsEmpresa = value; }
        }

        /// <summary>
        /// Codigo de Ocupacion
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
        /// Fecha de Inicio de Ocupacion
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public DateTime FeInicio
        {
            get { return _datFeInicio; }
            set { _datFeInicio = value; }
        }

        /// <summary>
        /// Fecha de fin de ocupacion
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public DateTime FeFin
        {
            get { return _datFeFin; }
            set { _datFeFin = value; }
        }

        /// <summary>
        /// Descripcion de Ocupacion
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsDescripOcupa
        {
            get { return _strDsDescripOcupa; }
            set { _strDsDescripOcupa = value; }
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
