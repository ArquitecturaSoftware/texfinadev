using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class EIngreso
    {
        #region Campos

       
        private string _strIdIngreso = "";
        private string _strIdEmpresa = "";
        private string _strIdPeriodo = "";
        private string _datFeguia = null;
        private string _strId_local = null;
        private string _strId_Personal1 = null;
        private string _strId_local2 = null;
        private string _strId_Personal2 = null;
        private string _strId_docucom = null;
        private string _strNu_doc = null;
        private string _strId_Almacen = null;
        private string _strds_Observ = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucreatrec = null;
        private Nullable<DateTime> _datFe_uupdatrec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";
        private string _strdsPersonal1 = null;
        private string _strdsPersonal2 = null;
        private string _existe = "";
        #endregion

        #region Atributos

   
        public string IdIngreso
        {
            get { return _strIdIngreso; }
            set { _strIdIngreso = value; }
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


        public string Feguia
        {
            get { return _datFeguia; }
            set { _datFeguia = value; }
        }

    
        public string Id_local
        {
            get { return _strId_local; }
            set { _strId_local = value; }
        }

        public string Id_Personal1
        {
            get { return _strId_Personal1; }
            set { _strId_Personal1 = value; }
        }


        public string Id_local2
        {
            get { return _strId_local2; }
            set { _strId_local2 = value; }
        }


        public string Id_Personal2
        {
            get { return _strId_Personal2; }
            set { _strId_Personal2 = value; }
        }

 
        public string Id_docucom
        {
            get { return _strId_docucom; }
            set { _strId_docucom = value; }
        }

     
        public string Nu_doc
        {
            get { return _strNu_doc; }
            set { _strNu_doc = value; }
        }

 
        public string Id_Almacen
        {
            get { return _strId_Almacen; }
            set { _strId_Almacen = value; }
        }


        public string ds_observ
        {
            get { return _strds_Observ; }
            set { _strds_Observ = value; }
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

      
        public Nullable<DateTime> Fe_uupdatrec
        {
            get { return _datFe_uupdatrec; }
            set { _datFe_uupdatrec = value; }
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


       public string dsPesonal1
       {
           get { return _strdsPersonal1; }
           set { _strdsPersonal1 = value; }
       }

       public string dsPesonal2
       {
           get { return _strdsPersonal2; }
           set { _strdsPersonal2 = value; }
       }
       public string existe
       {
           get { return _existe; }
           set { _existe = value; }
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
