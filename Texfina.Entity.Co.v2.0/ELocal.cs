using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class ELocal
    {
        #region Campos

       
        private string _strId_local = "";
        private string _strDs_local = "";
        private string _strDs_direc = "";
        private string _strNu_telf = null;
        private string _strSt_local = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos

   

        
        public string Id_local
        {
            get { return _strId_local; }
            set { _strId_local = value; }
        }

        
        public string Ds_local
        {
            get { return _strDs_local; }
            set { _strDs_local = value; }
        }

        
        public string Ds_direc
        {
            get { return _strDs_direc; }
            set { _strDs_direc = value; }
        }

        
        public string Nu_telf
        {
            get { return _strNu_telf; }
            set { _strNu_telf = value; }
        }

        
        public string St_local
        {
            get { return _strSt_local; }
            set { _strSt_local = value; }
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
