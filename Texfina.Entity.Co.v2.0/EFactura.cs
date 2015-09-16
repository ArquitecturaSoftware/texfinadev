using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EFactura
    {
        #region Campos

      
        private string _strId_periodo = "";
        private string _strId_serie = "";
        private string _strId_factura = "";
        private string _strId_ordenco = "";

        private string _datFe_factura;
        private string _datFe_oc;
        private string _strId_docucom = "";
        private string _strNu_docu = "";
        private string _strId_clipro = "";

        private string _strDsClipro = "";
        private string _strId_personal = "";
        private string _strDs_observa = "";
        private string _strId_vmoneda = "";
        private decimal _decMt_total = 0;
        private decimal _decMt_tc = 0;
        private string _strId_modcomp = "";
        private string _strSt_factura = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strId_empresa = null;
        private string _strStAnulado = "";

        private string _strds_personal = "";
        #endregion

        #region Atributos

        
        public string Id_periodo
        {
            get { return _strId_periodo; }
            set { _strId_periodo = value; }
        }

        public string Id_serie
        {
            get { return _strId_serie; }
            set { _strId_serie = value; }
        }

        public string Id_factura
        {
            get { return _strId_factura; }
            set { _strId_factura = value; }
        }

        public string Id_ordenco
        {
            get { return _strId_ordenco; }
            set { _strId_ordenco = value; }
        }

        public string Fe_factura
        {
            get { return _datFe_factura; }
            set { _datFe_factura = value; }
        }

        public string Fe_OrdenCompra
        {
            get { return _datFe_oc; }
            set { _datFe_oc = value; }
        }

        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }

        public string Nu_docu
        {
            get { return _strNu_docu; }
            set { _strNu_docu = value; }
        }

        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }

        public string ds_clipro
        {
            get { return _strDsClipro; }
            set { _strDsClipro = value; }
        }



        public string Id_personal
        {
            get { return _strId_personal; }
            set { _strId_personal = value; }
        }


        public string ds_personal
        {
            get { return _strds_personal; }
            set { _strds_personal = value; }
        }

        public string Ds_observa
        {
            get { return _strDs_observa; }
            set { _strDs_observa = value; }
        }

        public string Id_vmoneda
        {
            get { return _strId_vmoneda; }
            set { _strId_vmoneda = value; }
        }

        public decimal Mt_total
        {
            get { return _decMt_total; }
            set { _decMt_total = value; }
        }

        public decimal Mt_tc
        {
            get { return _decMt_tc; }
            set { _decMt_tc = value; }
        }

        public string Id_modcomp
        {
            get { return _strId_modcomp; }
            set { _strId_modcomp = value; }
        }

        public string St_factura
        {
            get { return _strSt_factura; }
            set { _strSt_factura = value; }
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
