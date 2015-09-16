using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
    /// <summary>
    /// Entidad para la Tabla: Planilla Detalle (RH_PlanillaDet)
    /// </summary>
    [DataContract()]
    public class EPlanillaDet : IEntityBase
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPlanilla = "";
        private string _strIdConRemu = "";
        private int _intNuSecuen = 0;
        private string _strStInhabilita = "";
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
        /// Código Concepto de Remuneración
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string IdConRemu
        {
            get { return _strIdConRemu; }
            set { _strIdConRemu = value; }
        }

        /// <summary>
        /// Número de Secuencia
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public int NuSecuen
        {
            get { return _intNuSecuen; }
            set { _intNuSecuen = value; }
        }

        /// <summary>
        /// Estado de concepto deshabilitado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string StInhabilita
        {
            get { return _strStInhabilita; }
            set { _strStInhabilita = value; }
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
