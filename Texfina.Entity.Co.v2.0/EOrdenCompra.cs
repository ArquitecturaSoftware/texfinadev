using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EOrdenCompra
    {


        #region Campos

        private string _psin_typeupd = "";

        private string _strId_periodo = "";
        private string _strId_ordenco = "";
        private string _strId_importa = "";
        private string _strDs_importa = "";
        private string _strId_Exporta = "";
        private string _strDs_Exporta = "";
        private string _strId_cotiza = "";
        private string _datFe_ordenco;
        private string _datFe_entrega;
        private string _strNu_hora = "";
        private string _strId_docucom = "";
        private string _strNu_docu = "";
        private string _strId_clipro = "";
        private string _strId_clipro2 = "";
        private string _strId_clipro3 = "";
        private string _strId_condpago = "";
        private DateTime _datFe_pago;
        private string _strId_personal = "";
        private string _strId_local = "";
        private string _strId_local2 = "";
        private string _strId_personal2 = "";
        private string _strDs_observa = "";
        private string _strId_vmoneda = "";
        private decimal _decMt_total = 0;
        private decimal _decMt_tc = 0;
        private string _strId_modcomp = "";
        private string _strId_tipcomp = "";
        private string _strId_prioridad = "";
        private string _strId_aprueba = "";
        private string _strSt_aprueba = "";
        private string _strId_autoriza = "";
        private string _strSt_ordenco = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";
        private string _strId_Empresa = "";

        private string _strEmitido = "";

        private string _datFe_ordenco_ini;
        private string _datFe_ordenco_Fin;
        private string _stordenco = "";
        private string _StrEstado = "";
        private string _strIdEmpresa = "";

        private string _strPedidop = "";
        private string _strEmitidap = "";
        private string _strdsCondPago = "";
        private string _strstfactura = "";
        private string _estadooc ="";
        private string _st_autorizado = "";
        private string _strclipro = "";

        private string _existe = "";

        #endregion

        #region Atributos


        public string existe
        {
            get { return _existe; }
            set { _existe = value; }
        }
        

        public string clipro
        {
            get { return _strclipro; }
            set { _strclipro = value; }
        }


        public string estadoOC
        {
            get { return _estadooc; }
            set { _estadooc = value; }
        }


        public string Estado
        {
            get { return _StrEstado; }
            set { _StrEstado = value; }
        }

        public string psin_typeupd
        {
            get { return _psin_typeupd; }
            set { _psin_typeupd = value; }
        }

        public string Id_periodo
        {
            get { return _strId_periodo; }
            set { _strId_periodo = value; }
        }


        public string Id_ordenco
        {
            get { return _strId_ordenco; }
            set { _strId_ordenco = value; }
        }


        public string Id_importa
        {
            get { return _strId_importa; }
            set { _strId_importa = value; }
        }

        public string Ds_importa
        {
            get { return _strDs_importa; }
            set { _strDs_importa = value; }
        }



        public string Id_Exporta
        {
            get { return _strId_Exporta; }
            set { _strId_Exporta = value; }
        }

        public string Ds_Exporta
        {
            get { return _strDs_Exporta; }
            set { _strDs_Exporta = value; }
        }

        public string Id_cotiza
        {
            get { return _strId_cotiza; }
            set { _strId_cotiza = value; }
        }


        public string Fe_ordenco
        {
            get { return _datFe_ordenco; }
            set { _datFe_ordenco = value; }
        }


        public string Fe_entrega
        {
            get { return _datFe_entrega; }
            set { _datFe_entrega = value; }
        }


        public string Nu_hora
        {
            get { return _strNu_hora; }
            set { _strNu_hora = value; }
        }


        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }


        public string Nu_docu
        {
            get { return _strNu_docu; }
            set { _strNu_docu = value; }
        }


        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }


        public string Id_clipro2
        {
            get { return _strId_clipro2; }
            set { _strId_clipro2 = value; }
        }


        public string Id_clipro3
        {
            get { return _strId_clipro3; }
            set { _strId_clipro3 = value; }
        }


        public string Id_condpago
        {
            get { return _strId_condpago; }
            set { _strId_condpago = value; }
        }


        public DateTime Fe_pago
        {
            get { return _datFe_pago; }
            set { _datFe_pago = value; }
        }


        public string Id_personal
        {
            get { return _strId_personal; }
            set { _strId_personal = value; }
        }


        public string Id_local
        {
            get { return _strId_local; }
            set { _strId_local = value; }
        }


        public string Id_local2
        {
            get { return _strId_local2; }
            set { _strId_local2 = value; }
        }


        public string Id_personal2
        {
            get { return _strId_personal2; }
            set { _strId_personal2 = value; }
        }


        public string Ds_observa
        {
            get { return _strDs_observa; }
            set { _strDs_observa = value; }
        }


        public string Id_vmoneda
        {
            get { return _strId_vmoneda; }
            set { _strId_vmoneda = value; }
        }


        public decimal Mt_total
        {
            get { return _decMt_total; }
            set { _decMt_total = value; }
        }


        public decimal Mt_tc
        {
            get { return _decMt_tc; }
            set { _decMt_tc = value; }
        }


        public string Id_modcomp
        {
            get { return _strId_modcomp; }
            set { _strId_modcomp = value; }
        }


        public string Id_tipcomp
        {
            get { return _strId_tipcomp; }
            set { _strId_tipcomp = value; }
        }


        public string Id_prioridad
        {
            get { return _strId_prioridad; }
            set { _strId_prioridad = value; }
        }


        public string Id_aprueba
        {
            get { return _strId_aprueba; }
            set { _strId_aprueba = value; }
        }


        public string St_aprueba
        {
            get { return _strSt_aprueba; }
            set { _strSt_aprueba = value; }
        }


        public string Id_autoriza
        {
            get { return _strId_autoriza; }
            set { _strId_autoriza = value; }
        }


        public string St_ordenco
        {
            get { return _strSt_ordenco; }
            set { _strSt_ordenco = value; }
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


        public string Id_Empresa
        {
            get { return _strId_Empresa; }
            set { _strId_Empresa = value; }
        }

        public string strEmitido
        {
            get { return _strEmitido; }
            set { _strEmitido = value; }
        }

        public string Fe_ordenco_ini
        {
            get { return _datFe_ordenco_ini; }
            set { _datFe_ordenco_ini = value; }
        }

        public string Fe_ordenco_fin
        {
            get { return _datFe_ordenco_Fin; }
            set { _datFe_ordenco_Fin = value; }
        }

        public string stordenco
        {
            get { return _stordenco; }
            set { _stordenco = value; }
        }

        public string st_autorizado
        {
            get { return _st_autorizado; }
            set { _st_autorizado = value; }
        }


        public string idEmpresa
        {
            get { return _strId_Empresa; }
            set { _strId_Empresa = value; }
        }




        public string Pedidop
        {
            get { return _strPedidop; }
            set { _strPedidop = value; }
        }

        public string Emitidap
        {
            get { return _strEmitidap; }
            set { _strEmitidap = value; }
        }

        public string dsCondPago
        {
            get { return _strdsCondPago; }
            set { _strdsCondPago = value; }
        }


        public string stfactura
        {
            get { return _strstfactura; }
            set { _strstfactura = value; }
        }

        #endregion

    }
}
