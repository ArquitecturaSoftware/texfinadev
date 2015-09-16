using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_LiquidacionDet (RH_LiquidacionDet)
    /// </summary>
    [DataContract()]
    public class ELiquidacionDet : IEntityBase
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
        private int _intNuSecuen = 0;
        private string _strIdConRemu = "";
        private int _intNuMes = 0;
        private int _intNuDia = 0;
        private string _strStEditado = "";
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
        public int NuSecuen
        {
            get { return _intNuSecuen; }
            set { _intNuSecuen = value; }
        }

        [DataMember()]
        public string IdConRemu
        {
            get { return _strIdConRemu; }
            set { _strIdConRemu = value; }
        }

        [DataMember()]
        public int NuMes
        {
            get { return _intNuMes; }
            set { _intNuMes = value; }
        }

        [DataMember()]
        public int NuDia
        {
            get { return _intNuDia; }
            set { _intNuDia = value; }
        }

        [DataMember()]
        public string StEditado
        {
            get { return _strStEditado; }
            set { _strStEditado = value; }
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
