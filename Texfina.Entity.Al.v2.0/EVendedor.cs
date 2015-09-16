using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
    public class EVendedor
    {
        #region Campos

        private int _psintypesel = 0;
        private string _strId_Vendedor = "";
        private string _strNu_dni = null;
        private string _strDs_nombre = null;
        private string _strDs_apellido = null;
        private string _strDs_RazSoc = null;

        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucrearec = null;
        private Nullable<DateTime> _datFe_updarec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";

        #endregion

        #region Atributos


        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        } 
        
        public string Id_Vendedor
        {
            get { return _strId_Vendedor; }
            set { _strId_Vendedor = value; }
        }

        
        public string Nu_dni
        {
            get { return _strNu_dni; }
            set { _strNu_dni = value; }
        }

        
        public string Ds_nombre
        {
            get { return _strDs_nombre; }
            set { _strDs_nombre = value; }
        }

        
        public string Ds_apellido
        {
            get { return _strDs_apellido; }
            set { _strDs_apellido = value; }
        }


        public string Ds_razsoc
        {
            get { return _strDs_RazSoc; }
            set { _strDs_RazSoc = value; }
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

       
        public Nullable<DateTime> Fe_updarec
        {
            get { return _datFe_updarec; }
            set { _datFe_updarec = value; }
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
