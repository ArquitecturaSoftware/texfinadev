using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_PerVacaDescaDet (RH_PerVacaDescaDet)
    /// </summary>
    [DataContract()]
    public class EPerVacaDescaDet : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPersonal = "";
        private string _strIdPeriodo = "";
        private string _strIdVacaDesca = "";
        private int _intNuSecuen = 0;
        private string _strIdPeriVac = "";
        private string _strIdPlanilla = "";
        private string _strIdForPago = "";
        private int _intNuProcAnual = 0;
        private string _strIdConRemu = "";
        private decimal _decNuDiasVaca = 0;
        private decimal _decMtVaca = 0;
        private DateTime _datFeVaca;
        private string _strStVaca = "";
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
        public int NuSecuen
        {
            get { return _intNuSecuen; }
            set { _intNuSecuen = value; }
        }

        [DataMember()]
        public string IdPeriVac
        {
            get { return _strIdPeriVac; }
            set { _strIdPeriVac = value; }
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
        public int NuProcAnual
        {
            get { return _intNuProcAnual; }
            set { _intNuProcAnual = value; }
        }

        [DataMember()]
        public string IdConRemu
        {
            get { return _strIdConRemu; }
            set { _strIdConRemu = value; }
        }

        [DataMember()]
        public decimal NuDiasVaca
        {
            get { return _decNuDiasVaca; }
            set { _decNuDiasVaca = value; }
        }

        [DataMember()]
        public decimal MtVaca
        {
            get { return _decMtVaca; }
            set { _decMtVaca = value; }
        }

        [DataMember()]
        public DateTime FeVaca
        {
            get { return _datFeVaca; }
            set { _datFeVaca = value; }
        }

        [DataMember()]
        public string StVaca
        {
            get { return _strStVaca; }
            set { _strStVaca = value; }
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
