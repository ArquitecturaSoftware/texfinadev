using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class EOrdPedido_Detalle
    {
        #region Campos


        private string _strIdreqsalida = "";
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strid_clipro = null;
        private string _strds_clipro = null;
        private string _strId_producto = null;
        private string _strds_producto = "";
        private string _strId_color = null;
        private string _strDsColor = null;
        private string _strNuItem = "";
        private Nullable<int> _intQt_rollo = null;
        private Nullable<int> _intQt_rollo_pend = null;
        private Nullable<decimal> _decMt_preunit_real = null;
        private Nullable<decimal> _decMt_preunit_actual = null;
        private Nullable<decimal> _decQt_peso = null;

        private string _strid_vendedor = null;
        private string _strds_vendedor = null;

        private string _strSt_estado = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_uupdarec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";


        private Boolean _stIgvActivo;

        private string _st_igv;

        #endregion

        #region Atributos

   
    
    
        public string Idreqsalida
        {
            get { return _strIdreqsalida; }
            set { _strIdreqsalida = value; }
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


        public string Id_clipro
        {
            get { return _strid_clipro; }
            set { _strid_clipro = value; }
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

        public string DsColor
        {
            get { return _strDsColor; }
            set { _strDsColor = value; }
        }


        public string NuItem
        {
            get { return _strNuItem; }
            set { _strNuItem = value; }
        }

       
        public Nullable<int> Qt_rollo
        {
            get { return _intQt_rollo; }
            set { _intQt_rollo = value; }
        }


        public Nullable<int> Qt_rollo_pend
        {
            get { return _intQt_rollo_pend; }
            set { _intQt_rollo_pend = value; }
        }


        public Nullable<decimal> Mt_preunit_real
        {
            get { return _decMt_preunit_real; }
            set { _decMt_preunit_real = value; }
        }

    
        public Nullable<decimal> Mt_preunit_actual
        {
            get { return _decMt_preunit_actual; }
            set { _decMt_preunit_actual = value; }
        }

     
        public Nullable<decimal> Qt_peso
        {
            get { return _decQt_peso; }
            set { _decQt_peso = value; }
        }


        public string Id_vendedor
        {
            get { return _strid_vendedor; }
            set { _strid_vendedor = value; }
        }

        public string Ds_vendedor
        {
            get { return _strds_vendedor; }
            set { _strds_vendedor = value; }
        }


        public string St_estado
        {
            get { return _strSt_estado; }
            set { _strSt_estado = value; }
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


       public Boolean _igvActivo
       {
           get { return _stIgvActivo; }
           set { _stIgvActivo = value; }
       }

       public string st_igv
       {
           get { return _st_igv; }
           set { _st_igv = value; }
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
