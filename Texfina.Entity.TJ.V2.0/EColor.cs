using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.TJ
{
    /// <summary>
    /// Entidad para la Tabla: MG_Color (MG_Color)
    /// </summary>

    public class EColor 
    {

        #region Campos

        private EntityState _intState = EntityState.Unchanged;
        private string _strId_color = "";
        private string _strDs_color = null;
        private string _strId_vtipcolor = null;
        private Nullable<DateTime> _datFe_creacion = null;
        private string _strId_cartacol = null;
        private string _strNu_opcion = null;
        private Nullable<DateTime> _datFe_creatrec = null;
        private string _strId_ucrearec = null;
        private Nullable<DateTime> _datFe_updarec = null;
        private string _strId_uupdarec = null;
        private string _strSt_anulado = null;
        private string _strStAnulado = "";
        private string _strIdEmpresa = "";

        private int _strpsintypesel = 0;
        private int _RowNumber = 0;
        #endregion

        #region Atributos

        public EntityState EntityState
        {
            get { return _intState; }
            set { _intState = value; }
        }


        public string Id_color
        {
            get { return _strId_color; }
            set { _strId_color = value; }
        }

  
        public string Ds_color
        {
            get { return _strDs_color; }
            set { _strDs_color = value; }
        }

      
        public string Id_vtipcolor
        {
            get { return _strId_vtipcolor; }
            set { _strId_vtipcolor = value; }
        }

     
        public Nullable<DateTime> Fe_creacion
        {
            get { return _datFe_creacion; }
            set { _datFe_creacion = value; }
        }

      
        public string Id_cartacol
        {
            get { return _strId_cartacol; }
            set { _strId_cartacol = value; }
        }


        public string Nu_opcion
        {
            get { return _strNu_opcion; }
            set { _strNu_opcion = value; }
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


        public Nullable<DateTime> Fe_updarec
        {
            get { return _datFe_updarec; }
            set { _datFe_updarec = value; }
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


        public int psintypesel
        {
            get { return _strpsintypesel; }
            set { _strpsintypesel = value; }
        }


        public int RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

     

        public string IdEmpresa
        {
            get { return _strIdEmpresa; }
            set { _strIdEmpresa = value; }
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
