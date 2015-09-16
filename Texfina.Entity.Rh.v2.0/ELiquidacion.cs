using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_Liquidacion (RH_Liquidacion)
    /// </summary>
    [DataContract()]
    public class ELiquidacion : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdPeriodo = "";
        private string _strIdEmpresa = "";
        private string _strIdForPago = "";
        private string _strIdPlanilla = "";
        private int _intNuProcAnual = 0;
        private string _strIdPersonal = "";
        private string _strIdLiquidacion = "";
        private string _strIdMes = "";
        private int _intNuSecuenContra = 0;
        private DateTime _datFeIngreso;
        private DateTime _datFeCese;
        private string _strIdCargo = "";
        private string _strIdMotivoCese = "";
        private decimal _decMtAPagar = 0;
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
        public string IdLiquidacion
        {
            get { return _strIdLiquidacion; }
            set { _strIdLiquidacion = value; }
        }

        [DataMember()]
        public string IdMes
        {
            get { return _strIdMes; }
            set { _strIdMes = value; }
        }

        [DataMember()]
        public int NuSecuenContra
        {
            get { return _intNuSecuenContra; }
            set { _intNuSecuenContra = value; }
        }

        /// <summary>
        /// Código Concepto de Remuneración
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public DateTime FeIngreso
        {
            get { return _datFeIngreso; }
            set { _datFeIngreso = value; }
        }

        /// <summary>
        /// Fecha de Prestamo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public DateTime FeCese
        {
            get { return _datFeCese; }
            set { _datFeCese = value; }
        }

        /// <summary>
        /// Código de Moneda
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdCargo
        {
            get { return _strIdCargo; }
            set { _strIdCargo = value; }
        }

        /// <summary>
        /// Monto Tipo de Cambio
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdMotivoCese
        {
            get { return _strIdMotivoCese; }
            set { _strIdMotivoCese = value; }
        }

        /// <summary>
        /// Monto Prestamo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public decimal MtAPagar
        {
            get { return _decMtAPagar; }
            set { _decMtAPagar = value; }
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

        #endregion

    }
}
