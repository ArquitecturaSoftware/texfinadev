using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: RH_TRegistro (RH_TRegistro)
    /// </summary>
    [DataContract()]
    public class ETRegistroReporte : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdStore = "";
        private string _strIdPeriodo = "";
        private string _strIdEmpresa = "";
        private string _strIdMes = "";

        #endregion

        #region Atributos

        [DataMember()]
        public EntityState EntityState
        {
            get { return _intState; }
            set { _intState = value; }
        }

        [DataMember()]
        public string IdStore
        {
            get { return _strIdStore; }
            set { _strIdStore = value; }
        }

        [DataMember()]
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

        [DataMember()]
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        [DataMember()]
        public string IdMes
        {
            get { return _strIdMes; }
            set { _strIdMes = value; }
        }

        #endregion

    }
}
