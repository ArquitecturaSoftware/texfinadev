using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_PerVacaProv (RH_PerVacaProv)
    /// </summary>
    [DataContract()]
    public class EPerVacaProv : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPersonal = "";
        private string _strIdPeriVac = "";
        private int _intNuDiasVaca = 0;
        private decimal _decMtVaca = 0;
        private decimal _decNuDiasPagado = 0;
        private decimal _decNuDiasGozado = 0;
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
        public string IdPeriVac
        {
            get { return _strIdPeriVac; }
            set { _strIdPeriVac = value; }
        }

        [DataMember()]
        public int NuDiasVaca
        {
            get { return _intNuDiasVaca; }
            set { _intNuDiasVaca = value; }
        }

        [DataMember()]
        public decimal MtVaca
        {
            get { return _decMtVaca; }
            set { _decMtVaca = value; }
        }

        [DataMember()]
        public decimal NuDiasPagado
        {
            get { return _decNuDiasPagado; }
            set { _decNuDiasPagado = value; }
        }

        [DataMember()]
        public decimal NuDiasGozado
        {
            get { return _decNuDiasGozado; }
            set { _decNuDiasGozado = value; }
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
