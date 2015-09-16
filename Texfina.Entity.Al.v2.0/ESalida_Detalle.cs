using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
    public class ESalida_Detalle
    {

        #region Campos
        private int _intypesel = 0; 
   
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strIdSalida = "";
        private string _strId_producto = "";
        private string _strDs_producto = "";
        private string _strId_vendedor = "";

        private string _strNu_item = "";
        private string _strCodBar = null;
        private string _strNu_op = null;
        private string _strNu_tf = null;
        private string _strId_color = null;
        private string _strDs_color = null;

        private string _strId_tipo = null;
        private string _strId_mercado = null;
        private string _strId_tiptela = null;
        private Nullable<decimal> _decQt_peso = null;

        private Nullable<decimal> _decQt_peso_actual = null;
        private Nullable<decimal> _decQt_peso_disp = null;

        private Nullable<decimal> _decMt_precio = null;
        private Nullable<int> _qt_rollo = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_uupdarec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        //private string _strStAnulado = "";

        private Nullable<decimal> _decMt_igv = null;
        private Nullable<decimal> _decMt_total = null;

        private bool _stIgvActivo;

        private string  strId_cliente = null;
        private string strpidreqsalida = null;



        #endregion

        #region Atributos





        public string _id_cliente
        {
            get { return strId_cliente; }
            set { strId_cliente = value; }
        }

        public string _pidreqsalida
        {
            get { return strpidreqsalida; }
            set { strpidreqsalida = value; }
        }


       // public string _pidreqsalida { get; set; }

        public int psintypesel
        {
            get { return _intypesel; }
            set { _intypesel = value; }
        }

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

        public string IdSalida
        {
            get { return _strIdSalida; }
            set { _strIdSalida = value; }
        }

        public string Id_producto
        {
            get { return _strId_producto; }
            set { _strId_producto = value; }
        }

        public string Id_vendedor
        {
            get { return _strId_vendedor; }
            set { _strId_vendedor = value; }
        }

        public string Ds_producto
        {
            get { return _strDs_producto; }
            set { _strDs_producto = value; }
        }

        public string Nu_item
        {
            get { return _strNu_item; }
            set { _strNu_item = value; }
        }

      
        public string CodBar
        {
            get { return _strCodBar; }
            set { _strCodBar = value; }
        }

       
        public string Nu_op
        {
            get { return _strNu_op; }
            set { _strNu_op = value; }
        }


        public string Nu_tf
        {
            get { return _strNu_tf; }
            set { _strNu_tf = value; }
        }


        public string Id_color
        {
            get { return _strId_color; }
            set { _strId_color = value; }
        }


        public string Ds_color
        {
            get { return _strDs_color; }
            set { _strDs_color = value; }
        }
   
        public string Id_tipo
        {
            get { return _strId_tipo; }
            set { _strId_tipo = value; }
        }

        public string Id_mercado
        {
            get { return _strId_mercado; }
            set { _strId_mercado = value; }
        }

 
        public string Id_tiptela
        {
            get { return _strId_tiptela; }
            set { _strId_tiptela = value; }
        }

     
        public Nullable<decimal> Qt_peso
        {
            get { return _decQt_peso; }
            set { _decQt_peso = value; }
        }

        public Nullable<decimal> Qt_peso_Actual
        {
            get { return _decQt_peso_actual; }
            set { _decQt_peso_actual = value; }
        }


        public Nullable<decimal> Qt_peso_Disp
        {
            get { return _decQt_peso_disp; }
            set { _decQt_peso_disp = value; }
        }


        public Nullable<int> Qt_rollo
        {
            get { return _qt_rollo; }
            set { _qt_rollo = value; }
        }
  
        public Nullable<decimal> Mt_precio
        {
            get { return _decMt_precio; }
            set { _decMt_precio = value; }
        }



        public Nullable<decimal> Mt_igv
        {
            get { return _decMt_igv; }
            set { _decMt_igv = value; }
        }


        public Nullable<decimal> Mt_total
        {
            get { return _decMt_total; }
            set { _decMt_total = value; }
        }

        public Boolean _igvActivo
        {
            get { return _stIgvActivo; }
            set { _stIgvActivo = value; }
        }



        public Nullable<DateTime> Fe_creatrec
        {
            get { return _datFe_creatrec; }
            set { _datFe_creatrec = value; }
        }


        public string Id_ucreatrec
        {
            get { return _strId_ucreatrec; }
            set { _strId_ucreatrec = value; }
        }

     
        public Nullable<DateTime> Fe_uupdarec
        {
            get { return _datFe_uupdarec; }
            set { _datFe_uupdarec = value; }
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
        /// 
        public string St_anulado
        {
            get { return _strSt_anulado; }
            set { _strSt_anulado = value; }
        }


        #endregion

    }
}
