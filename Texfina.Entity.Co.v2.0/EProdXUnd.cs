using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EProdXUnd
    {
        #region Campos

       
        private string _strId_producto = "";
        private string _strId_prodprese = "";
        private string _strDs_prodprese = "";
        private int _intNu_uniprese = 0;
        private int _intNu_umprese = 0;
        private decimal _decQt_pesoneto = 0;
        private decimal _decQt_pesobruto = 0;
        private decimal _decMt_precio = 0;
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";
        private string _strIdEmpresa = "";
        #endregion

        #region Atributos


        public string Id_Empresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        
        public string Id_producto
        {
            get { return _strId_producto; }
            set { _strId_producto = value; }
        }

        
        public string Id_prodprese
        {
            get { return _strId_prodprese; }
            set { _strId_prodprese = value; }
        }

        
        public string Ds_prodprese
        {
            get { return _strDs_prodprese; }
            set { _strDs_prodprese = value; }
        }

        
        public int Nu_uniprese
        {
            get { return _intNu_uniprese; }
            set { _intNu_uniprese = value; }
        }

        
        public int Nu_umprese
        {
            get { return _intNu_umprese; }
            set { _intNu_umprese = value; }
        }

        
        public decimal Qt_pesoneto
        {
            get { return _decQt_pesoneto; }
            set { _decQt_pesoneto = value; }
        }

        
        public decimal Qt_pesobruto
        {
            get { return _decQt_pesobruto; }
            set { _decQt_pesobruto = value; }
        }

        
        public decimal Mt_precio
        {
            get { return _decMt_precio; }
            set { _decMt_precio = value; }
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
