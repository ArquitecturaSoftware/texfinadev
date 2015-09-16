using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Co
{
    /// <summary>
    /// Entidad para la Tabla: CO_BienFiscaEstable (CO_BienFiscaEstable)
    /// </summary>
    [DataContract()]
    public class EBienFiscaEstable : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _intId = "";
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strNuRUC = "";
        private string _strIdEstable = "";
        private string _strDsDireccion = "";
        private string _strDsDireccionDet = "";
        private string _strStZGBRE = "";
        private string _strDsEstado = "";
        private Nullable<DateTime> _datIdFechaIniEstado;
        private Nullable<DateTime> _datIdFechaFinEstado;
        private string _strIdEstado = "";
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
        public string Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        [DataMember()]
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        [DataMember()]
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

        [DataMember()]
        public string NuRUC
        {
            get { return _strNuRUC; }
            set { _strNuRUC = value; }
        }

        [DataMember()]
        public string IdEstable
        {
            get { return _strIdEstable; }
            set { _strIdEstable = value; }
        }

        [DataMember()]
        public string DsDireccion
        {
            get { return _strDsDireccion; }
            set { _strDsDireccion = value; }
        }

        [DataMember()]
        public string DsDireccionDet
        {
            get { return _strDsDireccionDet; }
            set { _strDsDireccionDet = value; }
        }

        [DataMember()]
        public string StZGBRE
        {
            get { return _strStZGBRE; }
            set { _strStZGBRE = value; }
        }

        [DataMember()]
        public string DsEstado
        {
            get { return _strDsEstado; }
            set { _strDsEstado = value; }
        }

        [DataMember()]
        public Nullable<DateTime> IdFechaIniEstado
        {
            get { return _datIdFechaIniEstado; }
            set { _datIdFechaIniEstado = value; }
        }

        [DataMember()]
        public Nullable<DateTime> IdFechaFinEstado
        {
            get { return _datIdFechaFinEstado; }
            set { _datIdFechaFinEstado = value; }
        }

        [DataMember()]
        public string IdEstado
        {
            get { return _strIdEstado; }
            set { _strIdEstado = value; }
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
