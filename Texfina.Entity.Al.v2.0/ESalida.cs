using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class ESalida
    {

        #region Campos

        
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strIdSalida = "";
        private string _strIdreqsalida = null;
        private string _strIdPersonal1 = null;
        private string _strdsPersonal1 = null;
        private string _strIdLocal = null;
        private string _datFe_salida = null;
        private string _strHr_salida = null;
        private string _strId_clipro = null;
        private string _strds_clipro = null;
        private string _strDs_direntrega = null;
        private string _strId_condpago = null;
        private string _strds_condpago = null;
        private string _strDs_placa = null;
        private string _strIdPersonal2 = null;
        private string _strdsPersonal2 = null;
        private string _strId_docucom = null;
        private string _strId_vendedor = null;
        private string _strId_vmoneda = null;
        private string _strds_vendedor = null;
        private string _strDs_observ = null;
        private Nullable<decimal> _decMt_total = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_uupdarec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        
      
        #endregion

        #region Atributos

        
        public string Existe { get; set; }
        public string fe_autorizado { get; set; }
        public string fe_aprobado { get; set; }
        public string id_prioridad { get; set; }
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

       
        public string Idreqsalida
        {
            get { return _strIdreqsalida; }
            set { _strIdreqsalida = value; }
        }

   
        public string IdPersonal1
        {
            get { return _strIdPersonal1; }
            set { _strIdPersonal1 = value; }
        }


        public string dsPersonal1
        {
            get { return _strdsPersonal1; }
            set { _strdsPersonal1 = value; }
        }

        public string IdLocal
        {
            get { return _strIdLocal; }
            set { _strIdLocal = value; }
        }

       
        public string Fe_salida
        {
            get { return _datFe_salida; }
            set { _datFe_salida = value; }
        }

      
        public string Hr_salida
        {
            get { return _strHr_salida; }
            set { _strHr_salida = value; }
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


        public string Ds_direntrega
        {
            get { return _strDs_direntrega; }
            set { _strDs_direntrega = value; }
        }


        public string Id_condpago
        {
            get { return _strId_condpago; }
            set { _strId_condpago = value; }
        }

        public string ds_condpago
        {
            get { return _strds_condpago; }
            set { _strds_condpago = value; }
        }



        public string Ds_placa
        {
            get { return _strDs_placa; }
            set { _strDs_placa = value; }
        }


        public string IdPersonal2
        {
            get { return _strIdPersonal2; }
            set { _strIdPersonal2 = value; }
        }



        public string dsPersonal2
        {
            get { return _strdsPersonal2; }
            set { _strdsPersonal2 = value; }
        }


        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }


        public string Id_vendedor
        {
            get { return _strId_vendedor; }
            set { _strId_vendedor = value; }
        }

        public string Id_vmoneda
        {
            get { return _strId_vmoneda; }
            set { _strId_vmoneda = value; }
        }

        public string ds_vendedor
        {
            get { return _strds_vendedor; }
            set { _strds_vendedor = value; }
        }

        public string Ds_observ
        {
            get { return _strDs_observ; }
            set { _strDs_observ = value; }
        }


        public Nullable<decimal> Mt_total
        {
            get { return _decMt_total; }
            set { _decMt_total = value; }
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
