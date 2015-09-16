using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_TRegistro (RH_TRegistro)
    /// </summary>
    [DataContract()]
    public class ETRegistro : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdTRegistro = "";
        private string _strDsTRegistro = "";
        private string _strStExporta = "";
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
        public string IdTRegistro
        {
            get { return _strIdTRegistro; }
            set { _strIdTRegistro = value; }
        }

        [DataMember()]
        public string DsTRegistro
        {
            get { return _strDsTRegistro; }
            set { _strDsTRegistro = value; }
        }

        [DataMember()]
        public string StExporta
        {
            get { return _strStExporta; }
            set { _strStExporta = value; }
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
