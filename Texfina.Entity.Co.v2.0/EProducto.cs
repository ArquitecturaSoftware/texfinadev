using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EProducto
    {
        #region Campos

       
        private string _strId_producto = "";
        private string _strId_prodfox = "";
        private string _strDs_producto = "";
        private string _strDs_prodalias = "";
        private string _strId_grupo = "";
        private string _strId_familia = "";
        private string _strId_subfami = "";
        private string _strId_vunimed = "";
        private string _strId_vunicons = "";
        private decimal _decNu_facequiv = 0;
        private string _strId_vmoneda = "";
        private decimal _decMt_valrepo = 0;
        private string _strSt_igvisc = "";
        private string _strSt_activo = "";
        private string _strId_tipogsto = "";
        private string _strDsTipogsto = "";

        private DateTime _datFe_creatrec;
        private string _strId_ucrearec = "";
        private DateTime _datFe_updatrec;
        private string _strId_uupdarec = "";
        private string _strSt_anulado = "";
        private string _strStAnulado = "";
        private string _strIdEmpresa = "";
        private string _idPrese = "";

        private string _dsPrese = "";

        private int _psintypesel;

        private string _existe = "";
        #endregion

        #region Atributos



        public string existe
        {
            get { return _existe; }
            set { _existe = value; }
        }

        public string Ds_prese
        {
            get { return _dsPrese; }
            set { _dsPrese = value; }
        }

        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }


        public string Id_producto
        {
            get { return _strId_producto; }
            set { _strId_producto = value; }
        }

       
        public string Ds_producto
        {
            get { return _strDs_producto; }
            set { _strDs_producto = value; }
        }

        public string Id_prodFOX
        {
            get { return _strId_prodfox; }
            set { _strId_prodfox = value; }
        }

        public string Ds_prodalias
        {
            get { return _strDs_prodalias; }
            set { _strDs_prodalias = value; }
        }

       
        public string Id_grupo
        {
            get { return _strId_grupo; }
            set { _strId_grupo = value; }
        }

       
        public string Id_familia
        {
            get { return _strId_familia; }
            set { _strId_familia = value; }
        }

       
        public string Id_subfami
        {
            get { return _strId_subfami; }
            set { _strId_subfami = value; }
        }

       
        public string Id_vunimed
        {
            get { return _strId_vunimed; }
            set { _strId_vunimed = value; }
        }

       
        public string Id_vunicons
        {
            get { return _strId_vunicons; }
            set { _strId_vunicons = value; }
        }

       
        public decimal Nu_facequiv
        {
            get { return _decNu_facequiv; }
            set { _decNu_facequiv = value; }
        }

       
        public string Id_vmoneda
        {
            get { return _strId_vmoneda; }
            set { _strId_vmoneda = value; }
        }

       
        public decimal Mt_valrepo
        {
            get { return _decMt_valrepo; }
            set { _decMt_valrepo = value; }
        }

       
        public string St_igvisc
        {
            get { return _strSt_igvisc; }
            set { _strSt_igvisc = value; }
        }

       
        public string St_activo
        {
            get { return _strSt_activo; }
            set { _strSt_activo = value; }
        }

       
        public string Id_tipogsto
        {
            get { return _strId_tipogsto; }
            set { _strId_tipogsto = value; }
        }


        public string ds_tipogsto
        {
            get { return _strDsTipogsto; }
            set { _strDsTipogsto = value; }
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

        public string IdPrese
        {
            get { return _idPrese; }
            set { _idPrese = value; }
        }

       public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        
        #endregion

    }
}
