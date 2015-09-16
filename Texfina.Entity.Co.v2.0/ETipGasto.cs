using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
   public class ETipGasto
    {
        #region Campos

       private string _strId_empresa = "";
       private string _strId_uninegocio = "";
       private string _strId_ccosto = "";

        private string _strId_tipogsto = "";
        private string _strDs_tipogsto = "";
        private string _strDs_abrev = "";
        private string _strSt_ultnivel = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos

        public string Id_empresa
        {
            get { return _strId_empresa; }
            set { _strId_empresa = value; }
        }

        public string Id_ccosto
        {
            get { return _strId_ccosto; }
            set { _strId_ccosto = value; }
        }

        public string Id_unegocio
        {
            get { return _strId_uninegocio; }
            set { _strId_uninegocio = value; }
        }

 
           public string Id_tipogsto
        {
            get { return _strId_tipogsto; }
            set { _strId_tipogsto = value; }
        }

        
        public string Ds_tipogsto
        {
            get { return _strDs_tipogsto; }
            set { _strDs_tipogsto = value; }
        }

        
        public string Ds_abrev
        {
            get { return _strDs_abrev; }
            set { _strDs_abrev = value; }
        }

        
        public string St_ultnivel
        {
            get { return _strSt_ultnivel; }
            set { _strSt_ultnivel = value; }
        }

        
        public DateTime Fe_creatrec
        {
            get { return _datFe_creatrec; }
            set { _datFe_creatrec = value; }
        }

        
        public string Id_ucrearec
        {
            get { return _strId_ucrearec; }
            set { _strId_ucrearec = value; }
        }

        
        public DateTime Fe_updatrec
        {
            get { return _datFe_updatrec; }
            set { _datFe_updatrec = value; }
        }

        
        public string Id_uupdarec
        {
            get { return _strId_uupdarec; }
            set { _strId_uupdarec = value; }
        }

        
        public string St_anulado
        {
            get { return _strSt_anulado; }
            set { _strSt_anulado = value; }
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
