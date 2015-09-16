using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
     public class EParOCFillrpt
    {

        #region Campos

        private string _strIdEmpresa = "";
        private string _strAnio = "";
        private string _strMesIni = "";
        private string _strMesFin = "";
        private string _idOrdenCompra = "";
        private string _idProv = "";
        private string _nufactura = "";
        private string _nuImportacion = "";
        private string _nuExportacion = "";
        private string _local = "";

        private string _fechaini;
        private string _fechafin;
        private string _st_aprueba;
        private string _idproducto = "";
        private int _psintypesel;

        private string _dsRazonSoc = "";

        #endregion

        #region Atributos




        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }

        public string dsRazonSoc
        {
            get { return _dsRazonSoc; }
            set { _dsRazonSoc = value; }
        }

        public string idProducto
        {
            get { return _idproducto; }
            set { _idproducto = value; }
        }


        public string fechaini
        {
            get { return _fechaini; }
            set { _fechaini = value; }
        }

        public string fechaFin
        {
            get { return _fechafin; }
            set { _fechafin = value; }
        }

        public string local
        {
            get { return _local; }
            set { _local = value; }
        }


        public string nuImportacion
        {
            get { return _nuImportacion; }
            set { _nuImportacion = value; }
        }


        public string nuExportacion
        {
            get { return _nuExportacion; }
            set { _nuExportacion = value; }
        }

        public string idProv
        {
            get { return _idProv; }
            set { _idProv = value; }
        }
        
        public string nuFactura
        {
            get { return _nufactura; }
            set { _nufactura = value; }
        
        }

        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
        }

        public string IdAnio
        {
            get { return _strAnio; }
            set { _strAnio = value; }
        }

        public string IdMesIni
        {
            get { return _strMesIni; }
            set { _strMesIni = value; }
        }


        public string IdMesfin
        {
            get { return _strMesFin; }
            set { _strMesFin = value; }
        }


        public string st_aprueba
        {
            get { return _st_aprueba; }
            set { _st_aprueba = value; }
        }


        public string IdOrdenCompra
        {
            get { return _idOrdenCompra; }
            set { _idOrdenCompra = value; }
        }
        
        #endregion

    }
}
