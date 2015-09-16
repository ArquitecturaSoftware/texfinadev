using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Texfina.Entity.Co
{
    public class EDocumento
    {
        #region Campos

  
        private string _strId_docucom = "";
        private string _strDs_docucom = "";
        private string _strDs_abrev = "";
        private string _strSt_docinte = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos

       
        
        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }

        
        public string Ds_docucom
        {
            get { return _strDs_docucom; }
            set { _strDs_docucom = value; }
        }

        
        public string Ds_abrev
        {
            get { return _strDs_abrev; }
            set { _strDs_abrev = value; }
        }

        
        public string St_docinte
        {
            get { return _strSt_docinte; }
            set { _strSt_docinte = value; }
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
