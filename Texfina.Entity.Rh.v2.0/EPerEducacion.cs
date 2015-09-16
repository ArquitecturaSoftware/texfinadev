using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_PerEducacion (RH_PerEducacion)
    /// </summary>
    [DataContract()]
    public class EPerEducacion : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPersonal = "";
        private int _intNuSecuen = 0;
        private string _strIdNivel = "";
        private string _strDsCodigo = "";
        private string _strDsCentroEst = "";
        private DateTime _datFeInicio;
        private DateTime _datFeFin;
        private DateTime _datFeObtGrado;
        private string _strDsObservacion = "";
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
        /// Codigo Nivel/grado de Instruccion
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdNivel
        {
            get { return _strIdNivel; }
            set { _strIdNivel = value; }
        }

        /// <summary>
        /// Codigo de alumno en el Centro de Estudios
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsCodigo
        {
            get { return _strDsCodigo; }
            set { _strDsCodigo = value; }
        }

        /// <summary>
        /// Centro de Estudios
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsCentroEst
        {
            get { return _strDsCentroEst; }
            set { _strDsCentroEst = value; }
        }

        /// <summary>
        /// Fecha de Inicio de estudios
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
        /// Fecha de fin de estudios
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
        /// Fecha de Obtecion del Grado o Titulo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public DateTime FeObtGrado
        {
            get { return _datFeObtGrado; }
            set { _datFeObtGrado = value; }
        }

        /// <summary>
        /// Observaciones
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsObservacion
        {
            get { return _strDsObservacion; }
            set { _strDsObservacion = value; }
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
