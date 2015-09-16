using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
    public class ECliente
    {
        #region Campos

        private string _existe = "";
        private string _strIdEmpresa = "";
        private string _strId_clipro = "";
        private string _strId_vptipsocie = null;
        private string _strId_vpersjuri = null;
        private string _strDs_raznombre = null;
        private string _strDs_apellido = null;
        private string _strNu_ruc = null;
        private string _strId_vtipdoc = null;
        private string _strNu_dociden = null;
        private string _strDs_nomcomer = null;
        private string _strId_grupo = null;
        private string _strId_vtipclasi = null;
        private string _strSt_activo = null;
        private string _strId_vtipcalle = null;
        private string _strDs_direccion = null;
        private string _strDs_urbaniza = null;
        private string _strId_pais = null;
        private string _strId_depto = null;
        private string _strId_prov = null;
        private string _strId_dist = null;
        private string _strNu_telf1 = null;
        private string _strNu_telf2 = null;
        private string _strDs_emailco = null;
        private string _strDs_url = null;
        private string _strDs_monreleg = null;
        private string _strDs_appreleg = null;
        private string _strDs_apmreleg = null;
        private string _strNu_anxreleg = null;
        private string _strNu_telfeg = null;
        private string _strDs_emareleg = null;
        private string _strFe_creatrec = null;
        private string _strId_ucrearec = null;
        private string _strFe_updatrec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";

        private string _strIdCliFox = null;
        private string _strid_Vendedor = null;
        private string _strds_Vendedor = null;
        private int _psintypesel = 0;

        #endregion

        #region Atributos


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

        public string Id_cliFox
        {
            get { return _strIdCliFox; }
            set { _strIdCliFox = value; }
        }

        public string id_Vendedor
        {
            get { return _strid_Vendedor; }
            set { _strid_Vendedor = value; }
        }

        public string ds_Vendedor
        {
            get { return _strds_Vendedor; }
            set { _strds_Vendedor = value; }
        }
       
        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }

       
        public string Id_vptipsocie
        {
            get { return _strId_vptipsocie; }
            set { _strId_vptipsocie = value; }
        }

   
        public string Id_vpersjuri
        {
            get { return _strId_vpersjuri; }
            set { _strId_vpersjuri = value; }
        }

    
        public string Ds_raznombre
        {
            get { return _strDs_raznombre; }
            set { _strDs_raznombre = value; }
        }

       
        public string Ds_apellido
        {
            get { return _strDs_apellido; }
            set { _strDs_apellido = value; }
        }

        public string Nu_ruc
        {
            get { return _strNu_ruc; }
            set { _strNu_ruc = value; }
        }

  
        public string Id_vtipdoc
        {
            get { return _strId_vtipdoc; }
            set { _strId_vtipdoc = value; }
        }

        public string Nu_dociden
        {
            get { return _strNu_dociden; }
            set { _strNu_dociden = value; }
        }

       
        public string Ds_nomcomer
        {
            get { return _strDs_nomcomer; }
            set { _strDs_nomcomer = value; }
        }

       
        public string Id_grupo
        {
            get { return _strId_grupo; }
            set { _strId_grupo = value; }
        }

        
        public string Id_vtipclasi
        {
            get { return _strId_vtipclasi; }
            set { _strId_vtipclasi = value; }
        }

      
        public string St_activo
        {
            get { return _strSt_activo; }
            set { _strSt_activo = value; }
        }

   
        public string Id_vtipcalle
        {
            get { return _strId_vtipcalle; }
            set { _strId_vtipcalle = value; }
        }
             
        public string Ds_direccion
        {
            get { return _strDs_direccion; }
            set { _strDs_direccion = value; }
        }

  
        public string Ds_urbaniza
        {
            get { return _strDs_urbaniza; }
            set { _strDs_urbaniza = value; }
        }

   
        public string Id_pais
        {
            get { return _strId_pais; }
            set { _strId_pais = value; }
        }

      
        public string Id_depto
        {
            get { return _strId_depto; }
            set { _strId_depto = value; }
        }

      
        public string Id_prov
        {
            get { return _strId_prov; }
            set { _strId_prov = value; }
        }

     
        public string Id_dist
        {
            get { return _strId_dist; }
            set { _strId_dist = value; }
        }

      
        public string Nu_telf1
        {
            get { return _strNu_telf1; }
            set { _strNu_telf1 = value; }
        }

 
        public string Nu_telf2
        {
            get { return _strNu_telf2; }
            set { _strNu_telf2 = value; }
        }

     
        public string Ds_emailco
        {
            get { return _strDs_emailco; }
            set { _strDs_emailco = value; }
        }

    
        public string Ds_url
        {
            get { return _strDs_url; }
            set { _strDs_url = value; }
        }

        public string Ds_monreleg
        {
            get { return _strDs_monreleg; }
            set { _strDs_monreleg = value; }
        }

      
        public string Ds_appreleg
        {
            get { return _strDs_appreleg; }
            set { _strDs_appreleg = value; }
        }

        
        public string Ds_apmreleg
        {
            get { return _strDs_apmreleg; }
            set { _strDs_apmreleg = value; }
        }

       
        public string Nu_anxreleg
        {
            get { return _strNu_anxreleg; }
            set { _strNu_anxreleg = value; }
        }

       
        public string Nu_telfeg
        {
            get { return _strNu_telfeg; }
            set { _strNu_telfeg = value; }
        }

        public string Ds_emareleg
        {
            get { return _strDs_emareleg; }
            set { _strDs_emareleg = value; }
        }

       
        public string Fe_creatrec
        {
            get { return _strFe_creatrec; }
            set { _strFe_creatrec = value; }
        }

      
        public string Id_ucrearec
        {
            get { return _strId_ucrearec; }
            set { _strId_ucrearec = value; }
        }

    
        public string Fe_updatrec
        {
            get { return _strFe_updatrec; }
            set { _strFe_updatrec = value; }
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
