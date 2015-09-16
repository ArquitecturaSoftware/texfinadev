using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class EIngresoDetalle
    {
        #region Campos

        private int _psintypesel = 0;
        private string _strIdEmpresa = "";
        private string _strIdIngreso = "";
        private string _strIdPeriodo = "";
        private string _strCod_Bar = "";
        private string _strCod_Bar2 = "";
     

        private string _strId_clipro = null;
        private string _strds_clipro = null;
        private string _strId_producto = "";
        private string _strds_producto = "";
      
        private string _strId_color = null;
        private string _strds_color = null;
        private string _strNu_Item = "";
        private string _strNu_tf = null;
        private string _strNu_op = null;
        private string _strId_mercado = "";
        private string _strId_tipTela = "";
        private string _strId_Tipo = "";
        private string _strId_TipIngreso = "";
        private Nullable<int> _intQt_rollo = null;
        private Nullable<decimal> _decQt_peso_desp = null;
        private Nullable<decimal> _decQt_peso_real = null;
        private Nullable<decimal> _decQt_peso_actual = null;
        private Nullable<decimal> _decQt_densidad = null;
        private Nullable<decimal> _decQt_ancho = null;
        private string _strSt_estado = null;
        private string _strSt_anulado = null;

        private string _strId_Vendedor = null;
        private string _strDs_Vendedor = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_uupdatrec = null;
        private string _strId_uupdarec = null;

        public string fecha { get; set; }
        public string fechaFin { get; set; }
        public string nrollo { get; set; }
        public int qt_rollo_reserv { get; set; }
        #endregion

        #region Atributos


        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }
   
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

      
        public string IdIngreso
        {
            get { return _strIdIngreso; }
            set { _strIdIngreso = value; }
        }

       
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

       
        public string Cod_Bar
        {
            get { return _strCod_Bar; }
            set { _strCod_Bar = value; }
        }


          public string Cod_Bar2
        {
            get { return _strCod_Bar2; }
            set { _strCod_Bar2 = value; }
        }



      


        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }


        public string ds_clipro
        {
            get { return _strds_clipro; }
            set { _strds_clipro = value; }
        }

        public string Id_producto
        {
            get { return _strId_producto; }
            set { _strId_producto = value; }
        }


        public string ds_producto
        {
            get { return _strds_producto; }
            set { _strds_producto = value; }
        }



        public string Id_color
        {
            get { return _strId_color; }
            set { _strId_color = value; }
        }

        public string ds_color
        {
            get { return _strds_color; }
            set { _strds_color = value; }
        }

        public string Nu_Item
        {
            get { return _strNu_Item; }
            set { _strNu_Item = value; }
        }

      
        public string Nu_tf
        {
            get { return _strNu_tf; }
            set { _strNu_tf = value; }
        }

       
        public string Nu_op
        {
            get { return _strNu_op; }
            set { _strNu_op = value; }
        }

        public string Id_mercado
        {
            get { return _strId_mercado; }
            set { _strId_mercado = value; }
        }

        public string Id_tipTela
        {
            get { return _strId_tipTela; }
            set { _strId_tipTela = value; }
        }

   
        public string Id_Tipo
        {
            get { return _strId_Tipo; }
            set { _strId_Tipo = value; }
        }

       
        public string Id_TipIngreso
        {
            get { return _strId_TipIngreso; }
            set { _strId_TipIngreso = value; }
        }

 
        public Nullable<int> Qt_rollo
        {
            get { return _intQt_rollo; }
            set { _intQt_rollo = value; }
        }

     
        public Nullable<decimal> Qt_peso_desp
        {
            get { return _decQt_peso_desp; }
            set { _decQt_peso_desp = value; }
        }

     
        public Nullable<decimal> Qt_peso_real
        {
            get { return _decQt_peso_real; }
            set { _decQt_peso_real = value; }
        }

    
       public Nullable<decimal> Qt_peso_actual
        {
            get { return _decQt_peso_actual; }
            set { _decQt_peso_actual = value; }
        }

       
        public Nullable<decimal> Qt_densidad
        {
            get { return _decQt_densidad; }
            set { _decQt_densidad = value; }
        }

       
       public Nullable<decimal> Qt_ancho
        {
            get { return _decQt_ancho; }
            set { _decQt_ancho = value; }
        }

      
        public string St_estado
        {
            get { return _strSt_estado; }
            set { _strSt_estado = value; }
        }



        public string id_Vendedor
        {
            get { return _strId_Vendedor; }
            set { _strId_Vendedor = value; }
        }

        public string Ds_Vendedor
        {
            get { return _strDs_Vendedor; }
            set { _strDs_Vendedor = value; }
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

       
        public Nullable<DateTime> Fe_uupdatrec
        {
            get { return _datFe_uupdatrec; }
            set { _datFe_uupdatrec = value; }
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
