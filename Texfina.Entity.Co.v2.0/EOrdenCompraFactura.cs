using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EOrdenCompraFactura
    {
        #region Campos

        
        private string _strId_periodo = "";
        private string _strId_ordenco = "";
        private string _strNu_secuen = "";
        private string _strId_docucom = "001";
        private string _strNu_docum = "";
        private decimal _decMt_docum = 0;
        private string _strFe_documold = "";
        private DateTime _datFe_docum;
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strId_empresa = null;
        private string _strStAnulado = "";

        private string _strObserv = "";
        #endregion

        #region Atributos


        public string ds_observa
        {
            get { return _strObserv; }
            set { _strObserv = value; }
        }


        public string Id_periodo
        {
            get { return _strId_periodo; }
            set { _strId_periodo = value; }
        }

       
        public string Id_ordenco
        {
            get { return _strId_ordenco; }
            set { _strId_ordenco = value; }
        }

       
        public string Nu_secuen
        {
            get { return _strNu_secuen; }
            set { _strNu_secuen = value; }
        }

       
        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }

       
        public string Nu_docum
        {
            get { return _strNu_docum; }
            set { _strNu_docum = value; }
        }

       
        public decimal Mt_docum
        {
            get { return _decMt_docum; }
            set { _decMt_docum = value; }
        }

       
        public string Fe_documold
        {
            get { return _strFe_documold; }
            set { _strFe_documold = value; }
        }


        public DateTime Fe_docum
        {
            get { return _datFe_docum; }
            set { _datFe_docum = value; }
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

       
        public string Id_empresa
        {
            get { return _strId_empresa; }
            set { _strId_empresa = value; }
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
