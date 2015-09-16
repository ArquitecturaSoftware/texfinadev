using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_PerVacaDesca (RH_PerVacaDesca)
    /// </summary>
    [DataContract()]
    public class EPerVacaDesca : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPersonal = "";
        private string _strIdPeriodo = "";
        private string _strIdVacaDesca = "";
        private string _strIdPlanilla = "";
        private string _strIdForPago = "";
        private string _strStVaca = "";
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
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        [DataMember()]
        public string IdPersonal
        {
            get { return _strIdPersonal; }
            set { _strIdPersonal = value; }
        }

        [DataMember()]
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

        [DataMember()]
        public string IdVacaDesca
        {
            get { return _strIdVacaDesca; }
            set { _strIdVacaDesca = value; }
        }

        [DataMember()]
        public string IdPlanilla
        {
            get { return _strIdPlanilla; }
            set { _strIdPlanilla = value; }
        }

        [DataMember()]
        public string IdForPago
        {
            get { return _strIdForPago; }
            set { _strIdForPago = value; }
        }

        [DataMember()]
        public string StVaca
        {
            get { return _strStVaca; }
            set { _strStVaca = value; }
        }

        [DataMember()]
        public string DsObserva
        {
            get { return _strDsObserva; }
            set { _strDsObserva = value; }
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
