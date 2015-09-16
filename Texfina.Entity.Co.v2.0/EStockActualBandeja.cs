using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Co
{
    /// <summary>
    /// Entidad para la Tabla: Afp (RH_Afp)
    /// </summary>
    [DataContract()]
    public class EStockActualBandeja : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = null;
        private string _strIdDeclaStock = null;
        private string _strIdPeriodo = null;
        private string _strNuRUC = null;
        private string _strDsDireccion = null;
        private string _strIdUbigeo = null;
        private string _strDsPreseComercial = null;
        private decimal _decMtCantidadExis = 0;
        private decimal _decMtCantidadNeta = 0;
        private string _strDsUniControl = null;
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
        public string IdDeclaStock
        {
            get { return _strIdDeclaStock; }
            set { _strIdDeclaStock = value; }
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
        public string DsDireccion
        {
            get { return _strDsDireccion; }
            set { _strDsDireccion = value; }
        }

        [DataMember()]
        public string IdUbigeo
        {
            get { return _strIdUbigeo; }
            set { _strIdUbigeo = value; }
        }

        [DataMember()]
        public string DsPreseComercial
        {
            get { return _strDsPreseComercial; }
            set { _strDsPreseComercial = value; }
        }

        [DataMember()]
        public decimal MtCantidadExis
        {
            get { return _decMtCantidadExis; }
            set { _decMtCantidadExis = value; }
        }

        [DataMember()]
        public decimal MtCantidadNeta
        {
            get { return _decMtCantidadNeta; }
            set { _decMtCantidadNeta = value; }
        }

        [DataMember()]
        public string DsUniControl
        {
            get { return _strDsUniControl; }
            set { _strDsUniControl = value; }
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
