using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.TJ
{
    /// <summary>
    /// Entidad para la Tabla: TJ_Tejeduria_DetMall (TJ_Tejeduria_DetMall)
    /// </summary>

    public class ETejeduria_DetMall 
    {

        #region Campos

  
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strId_producto = "";
        private string _strNu_correficha = "";
        private string _strNu_secuen = "";
        private string _strNu_item = null;
        private Nullable<decimal> _decNu_longmalla = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucrearec = null;
        private Nullable<DateTime> _datFe_updatrec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";

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

   
        public string Nu_secuen
        {
            get { return _strNu_secuen; }
            set { _strNu_secuen = value; }
        }


        public string Nu_item
        {
            get { return _strNu_item; }
            set { _strNu_item = value; }
        }

 
        public Nullable<decimal> Nu_longmalla
        {
            get { return _decNu_longmalla; }
            set { _decNu_longmalla = value; }
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

  


        /// <summary>
        /// Estado Anulado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
    
        public string St_anulado
        {
            get { return _strSt_anulado; }
            set { _strSt_anulado = value; }
        }

        #endregion

    }


}
