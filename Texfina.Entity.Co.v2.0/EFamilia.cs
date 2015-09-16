using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EFamilia
    {
        #region Campos

        private int _psintypesel = 0;
		private string _strId_grupo = "";
		private string _strId_familia = "";
		private string _strId_subfami = "";
		private string _strDs_familia = "";
		private int _intNu_ultgen = 0;
		private DateTime _datFe_creatrec;
		private string _strId_ucrearec = "";
		private DateTime _datFe_updatrec;
		private string _strId_uupdarec = "";
		private string _strSt_anulado = "";
		private string _strStAnulado = "";

        private string _idEmpresa = "";

		#endregion

		#region Atributos

        public int psintypesel
        {
            get { return _psintypesel; }
            set { _psintypesel = value; }
        }


        public string idEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }
		
		public string Id_grupo
		{
			get{ return _strId_grupo; }
			set{ _strId_grupo = value; }
		}

		
		public string Id_familia
		{
			get{ return _strId_familia; }
			set{ _strId_familia = value; }
		}

		
		public string Id_subfami
		{
			get{ return _strId_subfami; }
			set{ _strId_subfami = value; }
		}

		
		public string Ds_familia
		{
			get{ return _strDs_familia; }
			set{ _strDs_familia = value; }
		}

		
		public int Nu_ultgen
		{
			get{ return _intNu_ultgen; }
			set{ _intNu_ultgen = value; }
		}

		
		public DateTime Fe_creatrec
		{
			get{ return _datFe_creatrec; }
			set{ _datFe_creatrec = value; }
		}

		
		public string Id_ucrearec
		{
			get{ return _strId_ucrearec; }
			set{ _strId_ucrearec = value; }
		}

		
		public DateTime Fe_updatrec
		{
			get{ return _datFe_updatrec; }
			set{ _datFe_updatrec = value; }
		}

		
		public string Id_uupdarec
		{
			get{ return _strId_uupdarec; }
			set{ _strId_uupdarec = value; }
		}

		
		public string St_anulado
		{
			get{ return _strSt_anulado; }
			set{ _strSt_anulado = value; }
		}

		/// <summary>
		/// Estado Anulado
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		
		public string StAnulado
		{
			get{ return _strStAnulado; }
			set{ _strStAnulado = value; }
		}

		#endregion


    }
}
