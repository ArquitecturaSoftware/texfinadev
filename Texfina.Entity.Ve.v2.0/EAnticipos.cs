using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Ve
{
    public class EAnticipos
    {
        #region Campos

        private Int32 _psintypesel = 0;
        private string _strIdEmpresa = "";
        private string _strIdAnticipo = "";
        private Nullable<DateTime> _datFeAnticipo = null;
        private string _strIdCliente = null;
        private string _strDsCliente = null;
        private string _strDsObs = null;
        private string _strIdTipIng = null;
        private string _strIdPersonal = null;
        private string _strDsPersonal = null;
        private string _strIdVendedor = null;
        private string _strDsVendedor = null;
        private string _strIdMoneda = null;
        private string _strNuDoc = null;
        private Nullable<decimal> _decMtDeposito = null;
        private Nullable<DateTime> _datFeReg = null;
        private string _strStAnulado = null;

        #endregion

        #region Atributos

        public Int32 psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }

        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        
        public string IdAnticipo
        {
            get { return _strIdAnticipo; }
            set { _strIdAnticipo = value; }
        }

        
        public Nullable<DateTime> FeAnticipo
        {
            get { return _datFeAnticipo; }
            set { _datFeAnticipo = value; }
        }

        
        public string IdCliente
        {
            get { return _strIdCliente; }
            set { _strIdCliente = value; }
        }

        
        public string DsCliente
        {
            get { return _strDsCliente; }
            set { _strDsCliente = value; }
        }

        
        public string DsObs
        {
            get { return _strDsObs; }
            set { _strDsObs = value; }
        }

        
        public string IdTipIng
        {
            get { return _strIdTipIng; }
            set { _strIdTipIng = value; }
        }

        
        public string IdPersonal
        {
            get { return _strIdPersonal; }
            set { _strIdPersonal = value; }
        }

        
        public string DsPersonal
        {
            get { return _strDsPersonal; }
            set { _strDsPersonal = value; }
        }

        
        public string IdVendedor
        {
            get { return _strIdVendedor; }
            set { _strIdVendedor = value; }
        }

        
        public string DsVendedor
        {
            get { return _strDsVendedor; }
            set { _strDsVendedor = value; }
        }

        
        public string IdMoneda
        {
            get { return _strIdMoneda; }
            set { _strIdMoneda = value; }
        }

        
        public string NuDoc
        {
            get { return _strNuDoc; }
            set { _strNuDoc = value; }
        }

        
        public Nullable<decimal> MtDeposito
        {
            get { return _decMtDeposito; }
            set { _decMtDeposito = value; }
        }

        
        public Nullable<DateTime> FeReg
        {
            get { return _datFeReg; }
            set { _datFeReg = value; }
        }

        
        public string StAnulado
        {
            get { return _strStAnulado; }
            set { _strStAnulado = value; }
        }

        #endregion



    }
}
