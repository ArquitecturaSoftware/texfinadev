using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class ECondicionPago
    {
        #region Campos

        private Int32 _psintypesel = 0;
        private string _strId_condpago = "";
        private string _strDs_condpago = "";
        private string _strDs_cpingles = "";
        private string _intQt_docu ="";
        private int _intNu_intinicial = 0;
        private int _intNu_intinter = 0;
        private string _strId_docucom = "";
        private string _strSt_detalle = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";

        #endregion

        #region Atributos





        public Int32 psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }

        public string Id_condpago
        {
            get { return _strId_condpago; }
            set { _strId_condpago = value; }
        }

    
        public string Ds_condpago
        {
            get { return _strDs_condpago; }
            set { _strDs_condpago = value; }
        }


        public string Ds_cpingles
        {
            get { return _strDs_cpingles; }
            set { _strDs_cpingles = value; }
        }


        public string Qt_docu
        {
            get { return _intQt_docu; }
            set { _intQt_docu = value; }
        }

   
        public int Nu_intinicial
        {
            get { return _intNu_intinicial; }
            set { _intNu_intinicial = value; }
        }

       
        public int Nu_intinter
        {
            get { return _intNu_intinter; }
            set { _intNu_intinter = value; }
        }


        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }


        public string St_detalle
        {
            get { return _strSt_detalle; }
            set { _strSt_detalle = value; }
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
