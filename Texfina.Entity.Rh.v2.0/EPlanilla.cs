using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: Planilla (RH_Planilla)
    /// </summary>
    [DataContract()]
    public class EPlanilla : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPlanilla = "";
        private string _strDsPlanilla = "";
        private int _intNuProcAnual = 0;
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
        /// Código de Planilla
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdPlanilla
        {
            get { return _strIdPlanilla; }
            set { _strIdPlanilla = value; }
        }

        /// <summary>
        /// Descripción de Planilla
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string DsPlanilla
        {
            get { return _strDsPlanilla; }
            set { _strDsPlanilla = value; }
        }

        /// <summary>
        /// Proc. Anual
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public int NuProcAnual
        {
            get { return _intNuProcAnual; }
            set { _intNuProcAnual = value; }
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
