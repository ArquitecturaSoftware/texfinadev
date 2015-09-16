using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EDetFactura
    {
        #region Campos

		
		private string _strId_periodo = "";
		private string _strId_serie = "";
		private string _strId_factura = "";
		private string _strNu_correla = "";
		private string _strId_producto = "";
		private string _strId_prodprese = "";
		private decimal _decQt_producto = 0;
		private string _strId_vmoneda = "";
		private decimal _decQt_pesobruto = 0;
		private decimal _decQt_pesoneto = 0;
		private decimal _decMt_precuni = 0;
		private decimal _decMt_igv = 0;
		private decimal _decMt_subtotal = 0;
		private decimal _decMt_dscto = 0;
		private DateTime _datFe_creatrec;
		private string _strId_ucrearec = "";
		private DateTime _datFe_updatrec;
		private string _strId_uupdarec = "";
		private string _strSt_anulado = "";
		private string _strId_empresa = null;
		private string _strStAnulado = "";
        private string _strDetalle = "";
		#endregion

		#region Atributos


		
		public string Id_periodo
		{
			get{ return _strId_periodo; }
			set{ _strId_periodo = value; }
		}

		
		public string Id_serie
		{
			get{ return _strId_serie; }
			set{ _strId_serie = value; }
		}

		
		public string Id_factura
		{
			get{ return _strId_factura; }
			set{ _strId_factura = value; }
		}

		
		public string Nu_correla
		{
			get{ return _strNu_correla; }
			set{ _strNu_correla = value; }
		}

		
		public string Id_producto
		{
			get{ return _strId_producto; }
			set{ _strId_producto = value; }
		}

		
		public string Id_prodprese
		{
			get{ return _strId_prodprese; }
			set{ _strId_prodprese = value; }
		}

		
		public decimal Qt_producto
		{
			get{ return _decQt_producto; }
			set{ _decQt_producto = value; }
		}

		
		public string Id_vmoneda
		{
			get{ return _strId_vmoneda; }
			set{ _strId_vmoneda = value; }
		}

		
		public decimal Qt_pesobruto
		{
			get{ return _decQt_pesobruto; }
			set{ _decQt_pesobruto = value; }
		}

		
		public decimal Qt_pesoneto
		{
			get{ return _decQt_pesoneto; }
			set{ _decQt_pesoneto = value; }
		}

		
		public decimal Mt_precuni
		{
			get{ return _decMt_precuni; }
			set{ _decMt_precuni = value; }
		}

		
		public decimal Mt_igv
		{
			get{ return _decMt_igv; }
			set{ _decMt_igv = value; }
		}

		
		public decimal Mt_subtotal
		{
			get{ return _decMt_subtotal; }
			set{ _decMt_subtotal = value; }
		}

		
		public decimal Mt_dscto
		{
			get{ return _decMt_dscto; }
			set{ _decMt_dscto = value; }
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

		
		public string Id_empresa
		{
			get{ return _strId_empresa; }
			set{ _strId_empresa = value; }
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


        public string detalle
        {
            get { return _strDetalle; }
            set { _strDetalle = value; }
        }

		#endregion

	}


    
}
