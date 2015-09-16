using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EDetProducto
    {
        #region Campos


        private string _strCodigo = "";
        private string _strPres = "";
        private string _strProducto = "";
        private string _strPresenta = "";
        private string _strTgxdef = "";
     
        private string _strUM = "";
        private decimal _decPeso_Bruto;
        private string _strNum_Correla = "";
        private string _datefe_venc;
        private string _datefe_Entrega;
        private string _strOP = "";
        private decimal _decCant;
        private decimal _decCantReciv;

        private decimal _decCantReg;

        private decimal _decPreNeto;
        private decimal _decPreUnit;
        private string _strTipgasto = "";
        private string _strClase = "";
        private string _strdsTg = "";
        private string _strC_Gasto = "";

        private string _strid_Gasto = "";

        private string _strIdCosto = "";
        private string _strCCostos = "";
        private string _strid_tipgstimp = "";

        private decimal _decDscto;
        private Boolean _stIgvActivo;
        private Boolean _stSelect;
        private decimal _decIgv;
        private decimal _decsubTotal;

        private decimal _decReserva;
        private string _strLote = "";
        private string _strTalla = "";
        private string _strColor = "";
        private string _strCalidad = "";
        private decimal _decNu_pordscto;

        private string _strId_vunicons = "";
        private string _strDescripcion = "";

        private string _strclase = "";

        private string _stEmpresa = "";

        private string _stpsintypesel = "";

        #endregion

        #region Atributosque 


        public string _Codigo
        {
            get { return _strCodigo; }
            set { _strCodigo = value; }
        }




        public string _psintypesel
        {
            get { return _stpsintypesel; }
            set { _stpsintypesel = value; }
        }


        public string _Empresa
        {
            get { return _stEmpresa; }
            set { _stEmpresa = value; }
        }


        public string _Pres
        {
            get { return _strPres; }
            set { _strPres = value; }
        }


        public string _Producto
        {
            get { return _strProducto; }
            set { _strProducto = value; }
        }
    
        public string _Nu_Correla
        {
            get { return _strNum_Correla; }
            set { _strNum_Correla = value; }
        }

        public string _Presenta
        {
            get { return _strPresenta; }
            set { _strPresenta = value; }
        }

        public string Id_vunicons
        {
            get { return _strId_vunicons; }
            set { _strId_vunicons = value; }
        }

        public string _Tgxdef
        {
            get { return _strTgxdef; }
            set { _strTgxdef = value; }
        }


        public string _Tipgasto
        {
            get { return _strTipgasto; }
            set { _strTipgasto = value; }
        }

        public string _idclase
        {
            get { return _strClase; }
            set { _strClase = value; }
        }

        public string _dstg
        {
            get { return _strdsTg; }
            set { _strdsTg = value; }
        }

        public string _id_tipgstimp
        {
            get { return _strid_tipgstimp; }
            set { _strid_tipgstimp = value; }
        }

        public string _UM
        {
            get { return _strUM; }
            set { _strUM = value; }
        }

        public decimal _Peso_Bruto
        {
            get { return _decPeso_Bruto; }
            set { _decPeso_Bruto = value; }
        }

        public string _fe_venc
        {
            get { return _datefe_venc; }
            set { _datefe_venc = value; }
        }

        public string _fe_Entrega
        {
            get { return _datefe_Entrega; }
            set { _datefe_Entrega = value; }
        }

        public string _OP
        {
            get { return _strOP; }
            set { _strOP = value; }
        }

        public decimal _Cant
        {
            get { return _decCant; }
            set { _decCant = value; }
        }

        public decimal _cantReciv
        {
            get { return _decCantReciv; }
            set { _decCantReciv = value; }
        }


        public decimal _cantReg
        {
            get { return _decCantReg; }
            set { _decCantReg = value; }
        }

        public decimal _PreNeto
        {
            get { return _decPreNeto; }
            set { _decPreNeto = value; }
        }

        public decimal _PreUnit
        {
            get { return _decPreUnit; }
            set { _decPreUnit = value; }
        }

        public string _id_Gasto
        {
            get { return _strid_Gasto; }
            set { _strid_Gasto = value; }
        }

        public string _C_Gasto
        {
            get { return _strC_Gasto; }
            set { _strC_Gasto = value; }
        }

        public string _idCosto
        {
            get { return _strIdCosto; }
            set { _strIdCosto = value; }
        }

        public string _C_Costos
        {
            get { return _strCCostos; }
            set { _strCCostos = value; }
        }


        public decimal _Dscto
        {
            get { return _decDscto; }
            set { _decDscto = value; }

        }

        public Boolean _igvActivo
        {
            get { return _stIgvActivo; }
            set { _stIgvActivo = value; }
        }


        public Boolean _select
        {
            get { return _stSelect; }
            set { _stSelect = value; }
        }



        public decimal _Igv
        {
            get { return _decIgv; }
            set { _decIgv = value; }
        }

        public decimal _subTotal
        {
            get { return _decsubTotal; }
            set { _decsubTotal = value; }
        }

        public decimal _Reserva
        {
            get { return _decReserva; }
            set { _decReserva = value; }
        }

        public string _Lote
        {
            get { return _strLote; }
            set { _strLote = value; }
        }

        public string _Talla
        {
            get { return _strTalla; }
            set { _strTalla = value; }
        }

        public string _Color
        {
            get { return _strColor; }
            set { _strColor = value; }
        }


        public string _Calidad
        {
            get { return _strCalidad; }
            set { _strCalidad = value; }
        }

        public decimal _nu_pordscto
        {
            get { return _decNu_pordscto; }
            set { _decNu_pordscto = value; }
        }

        public string _detalle
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        public string _clase
        {
            get { return _strclase; }
            set { _strclase = value; }
        }

        #endregion
    }
}
