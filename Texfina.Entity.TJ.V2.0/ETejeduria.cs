using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.TJ
{
    /// <summary>
    /// Entidad para la Tabla: TJ_Tejeduria (TJ_Tejeduria)
    /// </summary>
 
    public class ETejeduria 
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strId_producto = "";
        private string _strNu_correficha = "";
        private string _strId_clipro = null;
        private string _datFe_registro = "";
        private string _strNu_refmuestra = null;
        private string _strNu_tf = null;
        private string _strNu_gt = null;
        private string _strNu_tfref = null;
        private string _strId_vtipmcdo = null;
        private string _strNu_regula = null;
        private string _strId_vdestino = null;
        private string _strId_vtipancru = null;
        private Nullable<decimal> _decQt_anchcrudo = null;
        private Nullable<decimal> _decQt_denscrudo = null;
        private Nullable<decimal> _decQt_rendcrudo = null;
        private Nullable<decimal> _decQt_anchacaba = null;
        private Nullable<decimal> _decQt_densacaba = null;
        private Nullable<decimal> _decQt_rendacaba = null;
        private string _strId_maqtenido = null;
        private Nullable<decimal> _decNu_porencla = null;
        private Nullable<decimal> _decNu_porencan = null;
        private string _strDs_observa = null;
        private string _strId_ptmaq = null;
        private Nullable<decimal> _decNu_ptdiame = null;
        private Nullable<int> _intNu_ptgalga = null;
        private Nullable<int> _intNu_ptsistrab = null;
        private Nullable<int> _intNu_ptsisanul = null;
        private Nullable<int> _intNu_ptrpm = null;
        private string _datFe_pttejini = "";
        private string _datFe_pttejfin = "";
        private Nullable<decimal> _decQt_ptpeso = null;
        private string _strDs_obstejido = null;
        private string _strDs_evadeftj = null;
        private Nullable<decimal> _decNu_porrev = null;
        private Nullable<decimal> _decNu_gradosrev = null;
        private Nullable<decimal> _decNu_pormerma = null;
        private Nullable<decimal> _decMt_costtenido = null;
        private Nullable<decimal> _decMt_totconsumo = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucrearec = null;
        private Nullable<DateTime> _datFe_updatrec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";
        private int _psintypesel = 0;

        private string _existe = null;
        private string _strdsProducto = null;

        private string _strds_producto = null;

        private string _strds_razSoc = null;

        private Nullable<decimal> _decqt_anchdatreqacaba = null;
        private Nullable<decimal> _decqt_densdatreqacaba = null;

        private Nullable<decimal> _decnu_platina = null;

        private string _strid_color = null;

        private string _strds_color = null;
        private string _idCodBar = null;


        #endregion

        #region Atributos

        public string idCodBar
        {
            get { return _idCodBar; }
            set { _idCodBar = value; }
        }
        public EntityState EntityState
        {
            get { return _intState; }
            set { _intState = value; }
        }

        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }


        public string existe
        {
            get { return _existe; }
            set { _existe = value; }
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


        public string Ds_Producto
        {
            get { return _strdsProducto; }
            set { _strdsProducto = value; }
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

 
        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }


        public string Fe_registro
        {
            get { return _datFe_registro; }
            set { _datFe_registro = value; }
        }

        public string Nu_refmuestra
        {
            get { return _strNu_refmuestra; }
            set { _strNu_refmuestra = value; }
        }

   
        public string Nu_tf
        {
            get { return _strNu_tf; }
            set { _strNu_tf = value; }
        }

 
        public string Nu_gt
        {
            get { return _strNu_gt; }
            set { _strNu_gt = value; }
        }

     
        public string Nu_tfref
        {
            get { return _strNu_tfref; }
            set { _strNu_tfref = value; }
        }

      
        public string Id_vtipmcdo
        {
            get { return _strId_vtipmcdo; }
            set { _strId_vtipmcdo = value; }
        }

    
        public string Nu_regula
        {
            get { return _strNu_regula; }
            set { _strNu_regula = value; }
        }

   
        public string Id_vdestino
        {
            get { return _strId_vdestino; }
            set { _strId_vdestino = value; }
        }

  
        public string Id_vtipancru
        {
            get { return _strId_vtipancru; }
            set { _strId_vtipancru = value; }
        }

        public Nullable<decimal> Qt_anchcrudo
        {
            get { return _decQt_anchcrudo; }
            set { _decQt_anchcrudo = value; }
        }

        
        public Nullable<decimal> Qt_denscrudo
        {
            get
            {
                return _decQt_denscrudo; 
            }
            set { _decQt_denscrudo = value; }
        }

       
        public Nullable<decimal> Qt_rendcrudo
        {
            get { return _decQt_rendcrudo; }
            set { _decQt_rendcrudo = value; }
        }

       
        public Nullable<decimal> Qt_anchacaba
        {
            get { return _decQt_anchacaba; }
            set { _decQt_anchacaba = value; }
        }

    
        public Nullable<decimal> Qt_densacaba
        {
            get { return _decQt_densacaba; }
            set { _decQt_densacaba = value; }
        }

     
        public Nullable<decimal> Qt_rendacaba
        {
            get { return _decQt_rendacaba; }
            set { _decQt_rendacaba = value; }
        }

       
        public string Id_maqtenido
        {
            get { return _strId_maqtenido; }
            set { _strId_maqtenido = value; }
        }

        
        public Nullable<decimal> Nu_porencla
        {
            get { return _decNu_porencla; }
            set { _decNu_porencla = value; }
        }

       
        public Nullable<decimal> Nu_porencan
        {
            get { return _decNu_porencan; }
            set { _decNu_porencan = value; }
        }

   
        public string Ds_observa
        {
            get { return _strDs_observa; }
            set { _strDs_observa = value; }
        }

       
        public string Id_ptmaq
        {
            get { return _strId_ptmaq; }
            set { _strId_ptmaq = value; }
        }

        
        public Nullable<decimal> Nu_ptdiame
        {
            get { return _decNu_ptdiame; }
            set { _decNu_ptdiame = value; }
        }

        
        public Nullable<int> Nu_ptgalga
        {
            get { return _intNu_ptgalga; }
            set { _intNu_ptgalga = value; }
        }

       
        public Nullable<int> Nu_ptsistrab
        {
            get { return _intNu_ptsistrab; }
            set { _intNu_ptsistrab = value; }
        }

      
        public Nullable<int> Nu_ptsisanul
        {
            get { return _intNu_ptsisanul; }
            set { _intNu_ptsisanul = value; }
        }

      
        public Nullable<int> Nu_ptrpm
        {
            get { return _intNu_ptrpm; }
            set { _intNu_ptrpm = value; }
        }

      
        public string Fe_pttejini
        {
            get { return _datFe_pttejini; }
            set { _datFe_pttejini = value; }
        }

 
        public string Fe_pttejfin
        {
            get { return _datFe_pttejfin; }
            set { _datFe_pttejfin = value; }
        }

        
        public Nullable<decimal> Qt_ptpeso
        {
            get { return _decQt_ptpeso; }
            set { _decQt_ptpeso = value; }
        }

      
        public string Ds_obstejido
        {
            get { return _strDs_obstejido; }
            set { _strDs_obstejido = value; }
        }

       
        public string Ds_evadeftj
        {
            get { return _strDs_evadeftj; }
            set { _strDs_evadeftj = value; }
        }

    
        public Nullable<decimal> Nu_porrev
        {
            get { return _decNu_porrev; }
            set { _decNu_porrev = value; }
        }

     
        public Nullable<decimal> Nu_gradosrev
        {
            get { return _decNu_gradosrev; }
            set { _decNu_gradosrev = value; }
        }

       
        public Nullable<decimal> Nu_pormerma
        {
            get { return _decNu_pormerma; }
            set { _decNu_pormerma = value; }
        }

        public Nullable<decimal> Mt_costtenido
        {
            get { return _decMt_costtenido; }
            set { _decMt_costtenido = value; }
        }

     
        public Nullable<decimal> Mt_totconsumo
        {
            get { return _decMt_totconsumo; }
            set { _decMt_totconsumo = value; }
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

      
        public string St_anulado
        {
            get { return _strSt_anulado; }
            set { _strSt_anulado = value; }
        }



        public string ds_producto
        {
            get { return _strds_producto; }
            set { _strds_producto = value; }
        }


        public string ds_razonSoc
        {
            get { return _strds_razSoc; }
            set { _strds_razSoc = value; }
        }




        public Nullable<decimal> qt_anchdatreqacaba
        {
            get { return _decqt_anchdatreqacaba; }
            set { _decqt_anchdatreqacaba = value; }
        }


        public Nullable<decimal> qt_densdatreqacaba
        {
            get { return _decqt_densdatreqacaba; }
            set { _decqt_densdatreqacaba = value; }
        }



        public Nullable<decimal> nu_platina
        {
            get { return _decnu_platina; }
            set { _decnu_platina = value; }
        }


        public string Id_Color
        {
            get { return _strid_color; }
            set { _strid_color = value; }
        }

        public string ds_Color
        {
            get { return _strds_color; }
            set { _strds_color = value; }
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
