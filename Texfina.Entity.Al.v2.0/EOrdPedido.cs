using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class EOrdPedido
    {

        #region Campos

      
        private string _strIdreqsalida = "";
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _strId_condpago = null;
        private string _strId_clipro = null;
        private string _datFe_requer = null;
        private string _strIdpersonal1 = null;
        private string _strIdlocal = null;
        private string _datFe_venc = null;
        private string _strDs_direntrega = null;
        private string _strId_vendedor = null;
        private string _strId_tipsalida = null;
        private string _strId_prioridad = null;
        private string _strId_autorizado = null;
        private string _strId_autorizado2 = null;
        private string _strId_aprobado = null;
        private string _strSt_autorizado = null;
        private string _strSt_autorizado2 = null;
        private string _strSt_aprobado = null;
        private string _strDs_observ = null;
        private Nullable<DateTime> _datFe_createrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_uupdatrec = null;
        private string _strId_uupdatrec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";
        public string Existe { get; set; }
        public string ds_condpago { get; set; }
        public string ds_raznombre { get; set; }
        public string dsVendedor { get; set; }
        public string ds_tipsalida { get; set; }

        public string _id_vmoneda { get; set; }
        public string emitidap { get; set; }

        private string _datFe_autorizado = null;
        private string _datFe_aprobado = null;

        private string _strds_prontoPago = null;
        private string _strds_promocion = null;

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

        public string Id_condpago
        {
            get { return _strId_condpago; }
            set { _strId_condpago = value; }
        }

     
        public string Id_clipro
        {
            get { return _strId_clipro; }
            set { _strId_clipro = value; }
        }

   
        public string Fe_requer
        {
            get { return _datFe_requer; }
            set { _datFe_requer = value; }
        }

      
        public string Idpersonal1
        {
            get { return _strIdpersonal1; }
            set { _strIdpersonal1 = value; }
        }


        public string IdLocal
        {
            get { return _strIdlocal; }
            set { _strIdlocal = value; }
        }

  
        public string Fe_venc
        {
            get { return _datFe_venc; }
            set { _datFe_venc = value; }
        }

    
        public string Ds_direntrega
        {
            get { return _strDs_direntrega; }
            set { _strDs_direntrega = value; }
        }

    
        public string Id_vendedor
        {
            get { return _strId_vendedor; }
            set { _strId_vendedor = value; }
        }

      
        public string Id_tipsalida
        {
            get { return _strId_tipsalida; }
            set { _strId_tipsalida = value; }
        }

      
        public string Id_prioridad
        {
            get { return _strId_prioridad; }
            set { _strId_prioridad = value; }
        }

        public string id_vmoneda
        {
            get { return _id_vmoneda; }
            set { _id_vmoneda = value; }
        }



        public string Id_autorizado
        {
            get { return _strId_autorizado; }
            set { _strId_autorizado = value; }
        }

        public string Id_autorizado2
        {
            get { return _strId_autorizado2; }
            set { _strId_autorizado2 = value; }
        }

        public string Id_aprobado
        {
            get { return _strId_aprobado; }
            set { _strId_aprobado = value; }
        }

      
        public string St_autorizado
        {
            get { return _strSt_autorizado; }
            set { _strSt_autorizado = value; }
        }

        public string St_autorizado2
        {
            get { return _strSt_autorizado2; }
            set { _strSt_autorizado2 = value; }
        }

        public string St_aprobado
        {
            get { return _strSt_aprobado; }
            set { _strSt_aprobado = value; }
        }

    
        public string Ds_observ
        {
            get { return _strDs_observ; }
            set { _strDs_observ = value; }
        }

     
        public Nullable<DateTime> Fe_createrec
        {
            get { return _datFe_createrec; }
            set { _datFe_createrec = value; }
        }

  
        public string Id_ucreatrec
        {
            get { return _strId_ucreatrec; }
            set { _strId_ucreatrec = value; }
        }


        public string Ds_prontoPago
        {
            get { return _strds_prontoPago; }
            set { _strds_prontoPago = value; }
        }

        public string Ds_promocion
        {
            get { return _strds_promocion; }
            set { _strds_promocion = value; }
        }

   
        public Nullable<DateTime> Fe_uupdatrec
        {
            get { return _datFe_uupdatrec; }
            set { _datFe_uupdatrec = value; }
        }


        public string Id_uupdatrec
        {
            get { return _strId_uupdatrec; }
            set { _strId_uupdatrec = value; }
        }



        public string fe_autorizado
        {
            get { return _datFe_autorizado; }
            set { _datFe_autorizado = value; }
        }


        public string fe_aprobado
        {
            get { return _datFe_aprobado; }
            set { _datFe_aprobado = value; }
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
