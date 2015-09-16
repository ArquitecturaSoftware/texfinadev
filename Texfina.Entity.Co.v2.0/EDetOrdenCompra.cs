using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EDetOrdenCompra
    {

        #region Campos


        private string _strId_periodo = "";
        private string _strId_op = "";
        private string _strId_ordenco = "";
        private string _strNu_correla = "";
        private string _strNu_lote = "";
        private string _strId_producto = "";
        private string _strId_prodprese = "";

        private decimal _decQt_producto = 0;
        private decimal _decQt_difcierre = 0;
        private string _strId_vmoneda = "";
        private decimal _decQt_pesobruto = 0;
        private decimal _decQt_pesoneto = 0;
        private decimal _decMt_precuni = 0;
        private decimal _decMt_igv = 0;
        private decimal _decMt_subtotal = 0;
        private decimal _decNu_pordscto = 0;
        private decimal _decMt_dscto = 0;

        private string _strId_ccosto = "";
        private string _strId_clase = "";
        
        private string _strId_cgasto = "";
        private string _strId_tipogsto = "";
        private string _strId_tipgstimp = "";
        private string _strSt_gastodist = "";
        private string _datFe_venclote;
        private string _datFe_entrega;
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";
        private string _strProducto = "";
        private string _strPres = "";
        private string _strds_prodprese = "";
        private string _strIdEmpresa = "";
        private string _strObser = "";
        private string _strUnimedida = "";
        private string _strDsCCostos = "";

        private decimal _desPorDesc;


        #endregion

        #region Atributos

        public string ds_prodprese
        {
            get { return _strds_prodprese; }
            set { _strds_prodprese = value; }
        }

        public string dsProducto
        {
            get { return _strProducto; }
            set { _strProducto = value; }
        }

        public string IdPrese
        {
            get { return _strPres; }
            set { _strPres = value; }
        }

        public string Id_periodo
        {
            get { return _strId_periodo; }
            set { _strId_periodo = value; }
        }


        public string Id_op
        {
            get { return _strId_op; }
            set { _strId_op = value; }
        }


        public string Id_ordenco
        {
            get { return _strId_ordenco; }
            set { _strId_ordenco = value; }
        }


        public string Nu_correla
        {
            get { return _strNu_correla; }
            set { _strNu_correla = value; }
        }


        public string Nu_lote
        {
            get { return _strNu_lote; }
            set { _strNu_lote = value; }
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


        public decimal Qt_producto
        {
            get { return _decQt_producto; }
            set { _decQt_producto = value; }
        }


        public decimal Qt_difcierre
        {
            get { return _decQt_difcierre; }
            set { _decQt_difcierre = value; }
        }


        public string Id_vmoneda
        {
            get { return _strId_vmoneda; }
            set { _strId_vmoneda = value; }
        }


        public decimal Qt_pesobruto
        {
            get { return _decQt_pesobruto; }
            set { _decQt_pesobruto = value; }
        }


        public decimal Qt_pesoneto
        {
            get { return _decQt_pesoneto; }
            set { _decQt_pesoneto = value; }
        }


        public decimal Mt_precuni
        {
            get { return _decMt_precuni; }
            set { _decMt_precuni = value; }
        }


        public decimal Mt_igv
        {
            get { return _decMt_igv; }
            set { _decMt_igv = value; }
        }


        public decimal Mt_subtotal
        {
            get { return _decMt_subtotal; }
            set { _decMt_subtotal = value; }
        }


        public decimal Nu_pordscto
        {
            get { return _decNu_pordscto; }
            set { _decNu_pordscto = value; }
        }


        public decimal Mt_dscto
        {
            get { return _decMt_dscto; }
            set { _decMt_dscto = value; }
        }

        public string Id_clase
        {
            get { return _strId_clase; }
            set { _strId_clase = value; }
        }


        public string Id_ccosto
        {
            get { return _strId_ccosto; }
            set { _strId_ccosto = value; }
        }


        public string Id_cgasto
        {
            get { return _strId_cgasto; }
            set { _strId_cgasto = value; }
        }


        public string Id_tipogsto
        {
            get { return _strId_tipogsto; }
            set { _strId_tipogsto = value; }
        }


        public string Id_tipgstimp
        {
            get { return _strId_tipgstimp; }
            set { _strId_tipgstimp = value; }
        }


        public string St_gastodist
        {
            get { return _strSt_gastodist; }
            set { _strSt_gastodist = value; }
        }


        public string Fe_venclote
        {
            get { return _datFe_venclote; }
            set { _datFe_venclote = value; }
        }


        public string Fe_entrega
        {
            get { return _datFe_entrega; }
            set { _datFe_entrega = value; }
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


        public string idEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }


        public string unimedida
        {
            get { return _strUnimedida; }
            set { _strUnimedida = value; }
        }


        public string dsccostos
        {
            get { return _strDsCCostos; }
            set { _strDsCCostos = value; }

        }


        public decimal PorDesc
        {
            get { return _desPorDesc; }
            set { _desPorDesc = value; }
        }


        public string _Detalle
        {
            get { return _strObser; }
            set { _strObser = value; }
        }

        #endregion


    }
}
