using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
	/// <summary>
	/// Entidad para la Tabla: Empresa Periodo (SY_EmpPeriodo)
	/// </summary>
	[DataContract()]
	public class EEmpPeriodo: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdEmpresa = "";
		private string _strIdPeriodo = "";
		private Nullable<DateTime> _datFePerIni = null;
		private Nullable<DateTime> _datFePerFin = null;
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
		/// Código de Empresa
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdEmpresa
		{
			get{ return _strIdEmpresa; }
			set{ _strIdEmpresa = value; }
		}

		/// <summary>
		/// Código de Periodo
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdPeriodo
		{
			get{ return _strIdPeriodo; }
			set{ _strIdPeriodo = value; }
		}

		/// <summary>
		/// Fecha de Periodo Inicial
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public Nullable<DateTime> FePerIni
		{
			get{ return _datFePerIni; }
			set{ _datFePerIni = value; }
		}

		/// <summary>
		/// Fecha de Periodo Final
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public Nullable<DateTime> FePerFin
		{
			get{ return _datFePerFin; }
			set{ _datFePerFin = value; }
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
