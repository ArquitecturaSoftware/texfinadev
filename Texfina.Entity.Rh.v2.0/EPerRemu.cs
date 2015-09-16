using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: Personal Remuneración (RH_PerRemu)
    /// </summary>
    [DataContract()]
    public class EPerRemu : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPersonal = "";
        private string _strIdForPago = "";
        private string _strIdTipoRemu = "";
        private string _strIdMoneda = "";
        private decimal _decMtRemu = 0;
        private string _strStAprobado = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos

        [DataMember()]
        public EntityState EntityState
        {
            get { return _intState; }
            set { _intState = value; }
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
        /// Forma de Pago B N
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
        /// Codigo de tipo de Remuneracion
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoRemu
        {
            get { return _strIdTipoRemu; }
            set { _strIdTipoRemu = value; }
        }

        /// <summary>
        /// Código de Moneda
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdMoneda
        {
            get { return _strIdMoneda; }
            set { _strIdMoneda = value; }
        }

        /// <summary>
        /// Monto de Remuneración
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public decimal MtRemu
        {
            get { return _decMtRemu; }
            set { _decMtRemu = value; }
        }

        /// <summary>
        /// Estado Aprobado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string StAprobado
        {
            get { return _strStAprobado; }
            set { _strStAprobado = value; }
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
