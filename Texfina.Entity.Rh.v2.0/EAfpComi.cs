using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: Afp - Comision (RH_AfpComi)
    /// </summary>
    [DataContract()]
    public class EAfpComi : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdAfp = "";
        private string _strIdPeriodo = "";
        private string _strIdMes = "";
        private string _strIdTipoComi = "";
        private string _strIdTipoValor = "";
        private decimal _decNuValor = 0;
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
        /// Código de AFP
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdAfp
        {
            get { return _strIdAfp; }
            set { _strIdAfp = value; }
        }

        /// <summary>
        /// Código de Periodo
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

        /// <summary>
        /// Código de Mes
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdMes
        {
            get { return _strIdMes; }
            set { _strIdMes = value; }
        }

        /// <summary>
        /// Tipo de Comisión
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoComi
        {
            get { return _strIdTipoComi; }
            set { _strIdTipoComi = value; }
        }

        /// <summary>
        /// Tipo de Valor
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdTipoValor
        {
            get { return _strIdTipoValor; }
            set { _strIdTipoValor = value; }
        }

        /// <summary>
        /// Número Valor
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public decimal NuValor
        {
            get { return _decNuValor; }
            set { _decNuValor = value; }
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
