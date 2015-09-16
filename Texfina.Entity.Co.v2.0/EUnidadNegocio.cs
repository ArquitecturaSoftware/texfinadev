using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EUnidadNegocio
    {
        #region Campos
        private string _strIdEmpresa = "";
        private string _strIdUNegocio = "";
        private string _strDsUNegocio = "";
        private string _strDsAbrev = "";
        private string _strStAnulado = "";
        private string _strExiste = "";
        #endregion

        #region Atributos



        public string Existe
        {
            get { return _strExiste; }
            set { _strExiste = value; }
        }


        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }


        public string IdUNegocio
        {
            get { return _strIdUNegocio; }
            set { _strIdUNegocio = value; }
        }


        public string DsUNegocio
        {
            get { return _strDsUNegocio; }
            set { _strDsUNegocio = value; }
        }


        public string DsAbrev
        {
            get { return _strDsAbrev; }
            set { _strDsAbrev = value; }
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
