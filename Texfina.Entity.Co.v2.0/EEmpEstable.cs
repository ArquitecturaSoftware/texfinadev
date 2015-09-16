using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EEmpEstable
    {
        #region Campos

        private string _strIdEmpresa = "";
        private string _strIdEstable = "";
        private string _strDsEstable = "";
        private string _strStCentRiesgo = "";
        private string _strStAnulado = "";

        #endregion


        #region Atributos


        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

 
        public string IdEstable
        {
            get { return _strIdEstable; }
            set { _strIdEstable = value; }
        }

      
        public string DsEstable
        {
            get { return _strDsEstable; }
            set { _strDsEstable = value; }
        }

        public string StCentRiesgo
        {
            get { return _strStCentRiesgo; }
            set { _strStCentRiesgo = value; }
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
