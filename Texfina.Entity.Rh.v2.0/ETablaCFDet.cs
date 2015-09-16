using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
	/// <summary>
	/// Entidad para la Tabla: Campos disponibles en el Editor de Formulas Detalle (RH_TablaCFDet)
	/// </summary>
	[DataContract()]
	public class ETablaCFDet: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdEditor = "";
		private string _strNuSeccion = "";
		private int _intNuSecuen = 0;
		private string _strStFromTbl = "";
		private string _strIdTabla = "";
		private string _strIdColumna = "";
		private string _strIdTipo = "";
		private string _strDsToolTip = "";
		private string _strDsCondicion = "";
		private string _strStAnulado = "";

		#endregion

		#region Atributos

		[DataMember()]
		public EntityState EntityState
		{
			get{ return _intState; }
			set{ _intState = value; }
		}

		/// <summary>
		/// Codigo del Editor
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdEditor
		{
			get{ return _strIdEditor; }
			set{ _strIdEditor = value; }
		}

		/// <summary>
		/// Seccion del Editor
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string NuSeccion
		{
			get{ return _strNuSeccion; }
			set{ _strNuSeccion = value; }
		}

		/// <summary>
		/// Secuencia
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public int NuSecuen
		{
			get{ return _intNuSecuen; }
			set{ _intNuSecuen = value; }
		}

		/// <summary>
		/// Estado si el dato se extrae de una tabla (0=No, 1 =Si)
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StFromTbl
		{
			get{ return _strStFromTbl; }
			set{ _strStFromTbl = value; }
		}

		/// <summary>
		/// Nombre de la Tabla desde donde se extraen los datos
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdTabla
		{
			get{ return _strIdTabla; }
			set{ _strIdTabla = value; }
		}

		/// <summary>
		/// Columna desde donde se extraen los datos
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdColumna
		{
			get{ return _strIdColumna; }
			set{ _strIdColumna = value; }
		}

		/// <summary>
		/// Tipo
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdTipo
		{
			get{ return _strIdTipo; }
			set{ _strIdTipo = value; }
		}

		/// <summary>
		/// Tooltip
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string DsToolTip
		{
			get{ return _strDsToolTip; }
			set{ _strDsToolTip = value; }
		}

		/// <summary>
		/// Condicion (WHERE)
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string DsCondicion
		{
			get{ return _strDsCondicion; }
			set{ _strDsCondicion = value; }
		}

		/// <summary>
		/// Estado Anulado
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StAnulado
		{
			get{ return _strStAnulado; }
			set{ _strStAnulado = value; }
		}

		#endregion

	}
}
