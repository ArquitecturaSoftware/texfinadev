using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class Eexportacion
    {

        #region Campos

        private Int32 _psintypesel = 0;
        private string _strId_Exporta = "";
        private string _strId_Periodo = "";
        private string _strId_Empresa = "";
        private string _strDs_Exporta = null;
        private string _strId_via = "";
        private string _strId_tercom = "";
        private DateTime _datFe_createrec;
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


        public string Id_Exporta
        {
            get { return _strId_Exporta; }
            set { _strId_Exporta = value; }
        }

        public string Id_Periodo
        {
            get { return _strId_Periodo; }
            set { _strId_Periodo = value; }
        }


        public string Id_Empresa
        {
            get { return _strId_Empresa; }
            set { _strId_Empresa = value; }
        }

        public string Ds_Exporta
        {
            get { return _strDs_Exporta; }
            set { _strDs_Exporta = value; }
        }

        public string Id_via
        {
            get { return _strId_via; }
            set { _strId_via = value; }
        }

        public string Id_tercom
        {
            get { return _strId_tercom; }
            set { _strId_tercom = value; }
        }

        public DateTime Fe_createrec
        {
            get { return _datFe_createrec; }
            set { _datFe_createrec = value; }
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
