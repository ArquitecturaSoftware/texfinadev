using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_Subsidio (RH_Subsidio)
    /// </summary>
    [DataContract()]
    public class ESubsidioBandeja : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdPeriodo = "";
        private string _strIdEmpresa = "";
        private string _strIdForPago = "";
        private string _strIdPlanilla = "";
        private int _intNuProcAnual = 0;
        private string _strIdPersonal = "";
        private string _strIdSubsidio = "";
        private string _strIdTipoSubsidio = "";
        private Nullable<DateTime> _datFeSubsidio = null;
        private Nullable<DateTime> _datFeInicioPerioIncapa = null;
        private Nullable<DateTime> _datFeFinPerioIncapa = null;
        private string _strDsObserva = "";
        private string _strDsApellNom = "";
        private string _strNuDocIden = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos

        [DataMember()]
        public EntityState EntityState
        {
            get { return _intState; }
            set { _intState = value; }
        }

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

        [DataMember()]
        public string IdPlanilla
        {
            get { return _strIdPlanilla; }
            set { _strIdPlanilla = value; }
        }

        [DataMember()]
        public int NuProcAnual
        {
            get { return _intNuProcAnual; }
            set { _intNuProcAnual = value; }
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
        /// Código de Prestamo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdSubsidio
        {
            get { return _strIdSubsidio; }
            set { _strIdSubsidio = value; }
        }

        /// <summary>
        /// Código Concepto de Remuneración
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoSubsidio
        {
            get { return _strIdTipoSubsidio; }
            set { _strIdTipoSubsidio = value; }
        }

        /// <summary>
        /// Fecha de Prestamo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public Nullable<DateTime> FeSubsidio
        {
            get { return _datFeSubsidio; }
            set { _datFeSubsidio = value; }
        }

        [DataMember()]
        public Nullable<DateTime> FeInicioPerioIncapa
        {
            get { return _datFeInicioPerioIncapa; }
            set { _datFeInicioPerioIncapa = value; }
        }

        [DataMember()]
        public Nullable<DateTime> FeFinPerioIncapa
        {
            get { return _datFeFinPerioIncapa; }
            set { _datFeFinPerioIncapa = value; }
        }

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

        /// <summary>
        /// Nombres
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsApellNom
        {
            get { return _strDsApellNom; }
            set { _strDsApellNom = value; }
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
        #endregion

    }
}
