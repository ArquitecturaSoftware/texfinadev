using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class ElistPrecio_Detalle
    {
        #region Campos


        private int _psintypesel = 0;
        private string _strIdListPrecio = "";
        private string _strId_producto = "";
        private string _strds_producto = "";
        private string _strIdEmpresa = "";
        private string _strNuItem = "";
        private string _strNutf = "";
        private string _stridColor = null;
        private string _strDsColor = null;
        private string _strIdtipventa = null;
        private string _strDsCondPago = null;
        private string _strDsTipoDocumento = null;
        private Nullable<decimal> _decPrecio_mnt = null;
        private Nullable<DateTime> _datFe_ucreatrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_updatrec = null;
        private string _strId_uupdatrec = null;
        private string _strStAnulado = "";

        #endregion

        #region Atributos



        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }
    
        public string IdListPrecio
        {
            get { return _strIdListPrecio; }
            set { _strIdListPrecio = value; }
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

       public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }


        public string NuItem
        {
            get { return _strNuItem; }
            set { _strNuItem = value; }
        }



        public string NuTF
        {
            get { return _strNutf; }
            set { _strNutf = value; }
        }

        public string idColor
        {
            get { return _stridColor; }
            set { _stridColor = value; }
        }


        public string DsColor
        {
            get { return _strDsColor; }
            set { _strDsColor = value; }
        }


        public string Idtipventa
        {
            get { return _strIdtipventa; }
            set { _strIdtipventa = value; }
        }


        public string DsCondPago
        {
            get { return _strDsCondPago; }
            set { _strDsCondPago = value; }
        }

 
        public string DsTipoDocumento
        {
            get { return _strDsTipoDocumento; }
            set { _strDsTipoDocumento = value; }
        }

   
        public Nullable<decimal> Precio_mnt
        {
            get { return _decPrecio_mnt; }
            set { _decPrecio_mnt = value; }
        }


        public Nullable<DateTime> Fe_ucreatrec
        {
            get { return _datFe_ucreatrec; }
            set { _datFe_ucreatrec = value; }
        }

        public string Id_ucreatrec
        {
            get { return _strId_ucreatrec; }
            set { _strId_ucreatrec = value; }
        }

     
        public Nullable<DateTime> Fe_updatrec
        {
            get { return _datFe_updatrec; }
            set { _datFe_updatrec = value; }
        }

        /// <summary>
        /// Estado Anulado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
  
        public string Id_uupdatrec
        {
            get { return _strId_uupdatrec; }
            set { _strId_uupdatrec = value; }
        }



        #endregion

    }
}
