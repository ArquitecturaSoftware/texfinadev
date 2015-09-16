using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.TJ
{
    /// <summary>
    /// Entidad para la Tabla: TJ_TejeduriaDet (TJ_TejeduriaDet)
    /// </summary>
 
    public class ETejeduriaDet
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strIdPeriodo = "";
        private string _strIdEmpresa = "";
        private string _strId_producto = "";
        private string _strNu_correficha = "";
        private string _strNu_secuen = "";
        private string _strId_numalim = null;
        private string _strDs_distrib = null;
        private string _strDs_estruct = null;
        private string _strId_prodhilo = null;
        private string _strDs_tipfibra = null;
        private string _strDs_carachilo = null;
        private string _strDs_titulo = null;
        private string _strId_vlustre = null;
        private string _strNu_torsion = null;
        private string _strId_clipro = null;
        private string _strNu_lote = null;
        private string _strId_color = null;
        private string _strDs_etiqueta = null;
        private Nullable<decimal> _decNu_porhilo = null;
        private Nullable<decimal> _decNu_porhiloaca = null;
        private Nullable<decimal> _decNu_longmalla = null;
        private Nullable<decimal> _decNu_tension = null;
        private Nullable<int> _intNu_bobinas = null;
        private Nullable<int> _intNu_alimenta = null;
        private Nullable<decimal> _decMt_preuni = null;
        private Nullable<decimal> _decMt_subtotcon = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucrearec = null;
        private Nullable<DateTime> _datFe_updatrec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";

        private string _strds_prodHilo = "";
        private string _strds_lustre  = "";
        private string _strds_razsoc  = "";

        #endregion

        #region Atributos

      
        public EntityState EntityState
        {
            get { return _intState; }
            set { _intState = value; }
        }

     
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

    
        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
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


        public string Id_numalim
        {
            get { return _strId_numalim; }
            set { _strId_numalim = value; }
        }

        public string Ds_distrib
        {
            get { return _strDs_distrib; }
            set { _strDs_distrib = value; }
        }

      
        public string Ds_estruct
        {
            get { return _strDs_estruct; }
            set { _strDs_estruct = value; }
        }

        public string Id_prodhilo
        {
            get { return _strId_prodhilo; }
            set { _strId_prodhilo = value; }
        }

      
        public string Ds_tipfibra
        {
            get { return _strDs_tipfibra; }
            set { _strDs_tipfibra = value; }
        }

     
        public string Ds_carachilo
        {
            get { return _strDs_carachilo; }
            set { _strDs_carachilo = value; }
        }

     
        public string Ds_titulo
        {
            get { return _strDs_titulo; }
            set { _strDs_titulo = value; }
        }

     
        public string Id_vlustre
        {
            get { return _strId_vlustre; }
            set { _strId_vlustre = value; }
        }

        public string Nu_torsion
        {
            get { return _strNu_torsion; }
            set { _strNu_torsion = value; }
        }

       
        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }

      
        public string Nu_lote
        {
            get { return _strNu_lote; }
            set { _strNu_lote = value; }
        }

       
        public string Id_color
        {
            get { return _strId_color; }
            set { _strId_color = value; }
        }

    
        public string Ds_etiqueta
        {
            get { return _strDs_etiqueta; }
            set { _strDs_etiqueta = value; }
        }

      
        public Nullable<decimal> Nu_porhilo
        {
            get { return _decNu_porhilo; }
            set { _decNu_porhilo = value; }
        }

        public Nullable<decimal> Nu_porhiloaca
        {
            get { return _decNu_porhiloaca; }
            set { _decNu_porhiloaca = value; }
        }

    
        public Nullable<decimal> Nu_longmalla
        {
            get { return _decNu_longmalla; }
            set { _decNu_longmalla = value; }
        }

    
        public Nullable<decimal> Nu_tension
        {
            get { return _decNu_tension; }
            set { _decNu_tension = value; }
        }

        public Nullable<int> Nu_bobinas
        {
            get { return _intNu_bobinas; }
            set { _intNu_bobinas = value; }
        }

       
        public Nullable<int> Nu_alimenta
        {
            get { return _intNu_alimenta; }
            set { _intNu_alimenta = value; }
        }

      
        public Nullable<decimal> Mt_preuni
        {
            get { return _decMt_preuni; }
            set { _decMt_preuni = value; }
        }

     
        public Nullable<decimal> Mt_subtotcon
        {
            get { return _decMt_subtotcon; }
            set { _decMt_subtotcon = value; }
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



        public string ds_prodhilo
        {
            get { return _strds_prodHilo; }
            set { _strds_prodHilo = value; }
        }

        public string ds_lustre
        {
            get { return _strds_lustre; }
            set { _strds_lustre = value; }
        }


        public string ds_razsoc
        {
            get { return _strds_razsoc; }
            set { _strds_razsoc = value; }
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
