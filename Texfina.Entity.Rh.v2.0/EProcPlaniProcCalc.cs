using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: Proceso de Planilla (RH_ProcPlani)
    /// </summary>
    [DataContract()]
    public class EProcPlaniProcCalc : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdPeriodo = "";
        private string _strIdEmpresa = "";
        private string _strIdForPago = "";
        private string _strIdPlanilla = "";
        private int _intNuProcAnual = 0;
        private string _strIdMes = "";
        private string _strIdPersonal = "";

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

        /// <summary>
        /// Codigo Forma de Pago(B N)
        /// </summary>
        /// <value></value>
        /// <returns></returns>
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
        /// Proceso Anual
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
        /// Codigo de Personal
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdPersonal
        {
            get { return _strIdPersonal; }
            set { _strIdPersonal = value; }
        }

        #endregion

    }
}
