using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class ETablaGeneral
    {

        #region Campos

        
        private string _strId_tabla = "";
        private string _strId_item = "";
        private string _strDs_item = "";
        private string _strDs_itemcort = null;
        private string _strSt_unidad = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";

        #endregion


        #region Atributos

        public string Id_tabla
        {
            get { return _strId_tabla; }
            set { _strId_tabla = value; }
        }

   
        public string Id_item
        {
            get { return _strId_item; }
            set { _strId_item = value; }
        }


        public string Ds_item
        {
            get { return _strDs_item; }
            set { _strDs_item = value; }
        }

        public string Ds_itemcort
        {
            get { return _strDs_itemcort; }
            set { _strDs_itemcort = value; }
        }

   
        public string St_unidad
        {
            get { return _strSt_unidad; }
            set { _strSt_unidad = value; }
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
