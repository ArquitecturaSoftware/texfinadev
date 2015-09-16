using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
   public class ECCostos
    {

        #region Campos

        
        private string _strIdEmpresa = "";
        private string _strIdCCosto = "";
        private string _strIdUNegocio = "";
        private string _strDsCCosto = "";
        private string _strDsAbrev = "";
        private string _strIdtipGasto = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos

        

        
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        
        public string IdCCosto
        {
            get { return _strIdCCosto; }
            set { _strIdCCosto = value; }
        }

        
        public string IdUNegocio
        {
            get { return _strIdUNegocio; }
            set { _strIdUNegocio = value; }
        }

        
        public string DsCCosto
        {
            get { return _strDsCCosto; }
            set { _strDsCCosto = value; }
        }

        
        public string DsAbrev
        {
            get { return _strDsAbrev; }
            set { _strDsAbrev = value; }
        }

        
        public string IdtipGasto
        {
            get { return _strIdtipGasto; }
            set { _strIdtipGasto = value; }
        }

        /// <summary>
        /// Estado Anulado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        
        public string StAnulado
        {
            get { return _strStAnulado; }
            set { _strStAnulado = value; }
        }

        #endregion


    }
}
