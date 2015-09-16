using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Co
{
    /// <summary>
    /// Entidad para la Tabla: RH_TRegistro (RH_TRegistro)
    /// </summary>
    [DataContract()]
    public class ESunat : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdSunat = "";
        private string _strDsSunat = "";
        private string _strDsNombreArchivo = "";
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
        public string IdSunat
        {
            get { return _strIdSunat; }
            set { _strIdSunat = value; }
        }

        [DataMember()]
        public string DsSunat
        {
            get { return _strDsSunat; }
            set { _strDsSunat = value; }
        }

        [DataMember()]
        public string DsNombreArchivo
        {
            get { return _strDsNombreArchivo; }
            set { _strDsNombreArchivo = value; }
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
