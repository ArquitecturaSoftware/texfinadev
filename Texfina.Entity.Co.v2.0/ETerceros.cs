using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
   public  class ETerceros
    {

        #region Campos

       
        private string _strId_clipro = "";
        private string _strId_empresa = "";
        private string _strId_vpersjuri = "";
        private string _strId_vtipsocie = null;
        private string _strDs_raznombre = "";
        private string _strDs_apellido = "";
        private string _strNu_ruc = "";
        private string _strId_vtipdoc = null;
        private string _strNu_dociden = "";
        private string _strDs_nomcomer = "";
        private string _strId_grupo = "";
        private string _strId_vtipclasi = "";
        private string _strSt_activo = "";
        private string _strId_vtipcalle = "";
        private string _strDs_direccion = "";
        private string _strDs_urbaniza = "";
        private string _strId_pais = "";
        private string _strId_depto = "";
        private string _strId_prov = "";
        private string _strId_dist = "";
        private string _strDs_pobox = "";
        private string _strNu_telf1 = null;
        private string _strNu_telf2 = null;
        private string _strNu_telf3 = null;
        private string _strNu_fax1 = null;
        private string _strNu_fax2 = null;
        private string _strDs_emailco = null;
        private string _strDs_url = null;
        private string _strDs_nomreleg = "";
        private string _strDs_appreleg = "";
        private string _strDs_apmreleg = "";
        private string _strNu_tlfreleg = "";
        private string _strNu_anxreleg = "";
        private string _strNu_nxtreleg = null;
        private string _strDs_emareleg = "";
        private string _strId_vendedor = "";
        private decimal _decMt_valorprod = 0;
        private int _intNu_maquinas = 0;
        private int _intNu_trabaja = 0;
        private string _strId_cpago = "";
        private decimal _decNu_lcredit = 0;
        private int _intNu_placredit = 0;
        private string _strNu_diapag1 = "";
        private string _strNu_diapag2 = "";
        private string _strNu_diapag3 = "";
        private string _strNu_diapag4 = "";
        private string _strNu_diapag5 = "";
        private string _strNu_diapag6 = "";
        private string _strNu_diapag7 = "";
        private string _strHo_diapag1_1 = null;
        private string _strHo_diapag1_2 = null;
        private string _strHo_diapag2_1 = null;
        private string _strHo_diapag2_2 = null;
        private string _strHo_diapag3_1 = null;
        private string _strHo_diapag3_2 = null;
        private string _strHo_diapag4_1 = null;
        private string _strHo_diapag4_2 = null;
        private string _strHo_diapag5_1 = null;
        private string _strHo_diapag5_2 = null;
        private string _strHo_diapag6_1 = null;
        private string _strHo_diapag6_2 = null;
        private string _strHo_diapag7_1 = null;
        private string _strHo_diapag7_2 = null;

        private string _strSt_vtipcli = "";
        private string _strSt_vtippro = "";

        private string _strSt_prospecto = "";
        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";

        private string _existe = "";

        #endregion

        #region Atributos



        public string existe 
        {
            get { return _existe; }
            set { _existe = value; }
        }
        
        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }

        
        public string Id_empresa
        {
            get { return _strId_empresa; }
            set { _strId_empresa = value; }
        }

        
        public string Id_vpersjuri
        {
            get { return _strId_vpersjuri; }
            set { _strId_vpersjuri = value; }
        }

        
        public string Id_vtipsocie
        {
            get { return _strId_vtipsocie; }
            set { _strId_vtipsocie = value; }
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

        
        public string Ds_pobox
        {
            get { return _strDs_pobox; }
            set { _strDs_pobox = value; }
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

        
        public string Nu_telf3
        {
            get { return _strNu_telf3; }
            set { _strNu_telf3 = value; }
        }

        
        public string Nu_fax1
        {
            get { return _strNu_fax1; }
            set { _strNu_fax1 = value; }
        }

        
        public string Nu_fax2
        {
            get { return _strNu_fax2; }
            set { _strNu_fax2 = value; }
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

        
        public string Ds_nomreleg
        {
            get { return _strDs_nomreleg; }
            set { _strDs_nomreleg = value; }
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

        
        public string Nu_tlfreleg
        {
            get { return _strNu_tlfreleg; }
            set { _strNu_tlfreleg = value; }
        }

        
        public string Nu_anxreleg
        {
            get { return _strNu_anxreleg; }
            set { _strNu_anxreleg = value; }
        }

        
        public string Nu_nxtreleg
        {
            get { return _strNu_nxtreleg; }
            set { _strNu_nxtreleg = value; }
        }

        
        public string Ds_emareleg
        {
            get { return _strDs_emareleg; }
            set { _strDs_emareleg = value; }
        }

        
        public string Id_vendedor
        {
            get { return _strId_vendedor; }
            set { _strId_vendedor = value; }
        }

        
        public decimal Mt_valorprod
        {
            get { return _decMt_valorprod; }
            set { _decMt_valorprod = value; }
        }

        
        public int Nu_maquinas
        {
            get { return _intNu_maquinas; }
            set { _intNu_maquinas = value; }
        }

        
        public int Nu_trabaja
        {
            get { return _intNu_trabaja; }
            set { _intNu_trabaja = value; }
        }

        
        public string Id_cpago
        {
            get { return _strId_cpago; }
            set { _strId_cpago = value; }
        }

        
        public decimal Nu_lcredit
        {
            get { return _decNu_lcredit; }
            set { _decNu_lcredit = value; }
        }

        
        public int Nu_placredit
        {
            get { return _intNu_placredit; }
            set { _intNu_placredit = value; }
        }

        
        public string Nu_diapag1
        {
            get { return _strNu_diapag1; }
            set { _strNu_diapag1 = value; }
        }

        
        public string Nu_diapag2
        {
            get { return _strNu_diapag2; }
            set { _strNu_diapag2 = value; }
        }

        
        public string Nu_diapag3
        {
            get { return _strNu_diapag3; }
            set { _strNu_diapag3 = value; }
        }

        
        public string Nu_diapag4
        {
            get { return _strNu_diapag4; }
            set { _strNu_diapag4 = value; }
        }

        
        public string Nu_diapag5
        {
            get { return _strNu_diapag5; }
            set { _strNu_diapag5 = value; }
        }

        
        public string Nu_diapag6
        {
            get { return _strNu_diapag6; }
            set { _strNu_diapag6 = value; }
        }

        
        public string Nu_diapag7
        {
            get { return _strNu_diapag7; }
            set { _strNu_diapag7 = value; }
        }

        
        public string Ho_diapag1_1
        {
            get { return _strHo_diapag1_1; }
            set { _strHo_diapag1_1 = value; }
        }

        
        public string Ho_diapag1_2
        {
            get { return _strHo_diapag1_2; }
            set { _strHo_diapag1_2 = value; }
        }

        
        public string Ho_diapag2_1
        {
            get { return _strHo_diapag2_1; }
            set { _strHo_diapag2_1 = value; }
        }

        
        public string Ho_diapag2_2
        {
            get { return _strHo_diapag2_2; }
            set { _strHo_diapag2_2 = value; }
        }

        
        public string Ho_diapag3_1
        {
            get { return _strHo_diapag3_1; }
            set { _strHo_diapag3_1 = value; }
        }

        
        public string Ho_diapag3_2
        {
            get { return _strHo_diapag3_2; }
            set { _strHo_diapag3_2 = value; }
        }

        
        public string Ho_diapag4_1
        {
            get { return _strHo_diapag4_1; }
            set { _strHo_diapag4_1 = value; }
        }

        
        public string Ho_diapag4_2
        {
            get { return _strHo_diapag4_2; }
            set { _strHo_diapag4_2 = value; }
        }

        
        public string Ho_diapag5_1
        {
            get { return _strHo_diapag5_1; }
            set { _strHo_diapag5_1 = value; }
        }

        
        public string Ho_diapag5_2
        {
            get { return _strHo_diapag5_2; }
            set { _strHo_diapag5_2 = value; }
        }

        
        public string Ho_diapag6_1
        {
            get { return _strHo_diapag6_1; }
            set { _strHo_diapag6_1 = value; }
        }


        public string Ho_diapag6_2
        {
            get { return _strHo_diapag6_2; }
            set { _strHo_diapag6_2 = value; }
        }

        
        public string Ho_diapag7_1
        {
            get { return _strHo_diapag7_1; }
            set { _strHo_diapag7_1 = value; }
        }

        
        public string Ho_diapag7_2
        {
            get { return _strHo_diapag7_2; }
            set { _strHo_diapag7_2 = value; }
        }

        
        public string St_vtipcli
        {
            get { return _strSt_vtipcli; }
            set { _strSt_vtipcli = value; }
        }


        public string St_vtippro
        {
            get { return _strSt_vtippro; }
            set { _strSt_vtippro = value; }
        }
        
        public string St_prospecto
        {
            get { return _strSt_prospecto; }
            set { _strSt_prospecto = value; }
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
