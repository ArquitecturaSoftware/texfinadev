using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.TJ
{
   public class EEtiqueta_tela
    {
        #region Campos

  
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strId_producto = "";
        private string _strNu_correficha = "";
        private string _strIdCodBar = "";
        private string _strIdCodBar2 = "";
        private string _strItem = "";
        private string _strIdRutaProces = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucrearec = null;
        private Nullable<DateTime> _datFe_updatrec = null;
        private string _strId_uupdarec = null;
        private string _strStAnulado = null;

        #endregion

        #region Atributos

    
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

 
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

   
        public string Id_producto
        {
            get { return _strId_producto; }
            set { _strId_producto = value; }
        }

 
        public string Nu_correficha
        {
            get { return _strNu_correficha; }
            set { _strNu_correficha = value; }
        }

    
        public string IdCodBar
        {
            get { return _strIdCodBar; }
            set { _strIdCodBar = value; }
        }

   
        public string Item
        {
            get { return _strItem; }
            set { _strItem = value; }
        }


        public string IdRutaProces
        {
            get { return _strIdRutaProces; }
            set { _strIdRutaProces = value; }
        }


        public string IdCodBar2
        {
            get { return _strIdCodBar2; }
            set { _strIdCodBar2 = value; }
        }

        public Nullable<DateTime> Fe_creatrec
        {
            get { return _datFe_creatrec; }
            set { _datFe_creatrec = value; }
        }

 
        public string Id_ucrearec
        {
            get { return _strId_ucrearec; }
            set { _strId_ucrearec = value; }
        }

    
        public Nullable<DateTime> Fe_updatrec
        {
            get { return _datFe_updatrec; }
            set { _datFe_updatrec = value; }
        }

    
        public string Id_uupdarec
        {
            get { return _strId_uupdarec; }
            set { _strId_uupdarec = value; }
        }


        public string StAnulado
        {
            get { return _strStAnulado; }
            set { _strStAnulado = value; }
        }

        #endregion


    }
}
