using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
	/// <summary>
   /// Entidad para la Tabla: Empresa (SY_Empresa)
	/// </summary>
	[DataContract()]
	public class EEmpresa: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdEmpresa = "";
		private string _strDsEmpresa = "";
		private string _strDsAbrev = "";
		private string _strNuRuc = "";
		private string _strDsDireccion = "";
		private DateTime _datFeAcogmtpe;
		private string _strNuAcogmtpe = "";
		private string _strIdRegLaboral = "";
		private string _strIdPais = "";
		private string _strIdDepa = "";
		private string _strIdProv = "";
		private string _strIdDist = "";
		private string _strStAdmPublica = "";
		private string _strStAgenEmple = "";
		private string _strStEmpIntLab = "";
		private string _strStAfecSenati = "";
		private string _strStMicroEmp = "";
		private string _strStActivo = "";
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
		/// C�digo de Empresa
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
		/// Descripci�n de Empresa
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string DsEmpresa
		{
			get{ return _strDsEmpresa; }
			set{ _strDsEmpresa = value; }
		}

		/// <summary>
		/// Descripci�n de Abreviatura Corta
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string DsAbrev
		{
			get{ return _strDsAbrev; }
			set{ _strDsAbrev = value; }
		}

		/// <summary>
		/// N�mero de RUC
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string NuRuc
		{
			get{ return _strNuRuc; }
			set{ _strNuRuc = value; }
		}

		/// <summary>
		/// Descripci�n de Direcci�n
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string DsDireccion
		{
			get{ return _strDsDireccion; }
			set{ _strDsDireccion = value; }
		}

		[DataMember()]
		public DateTime FeAcogmtpe
		{
			get{ return _datFeAcogmtpe; }
			set{ _datFeAcogmtpe = value; }
		}

		[DataMember()]
		public string NuAcogmtpe
		{
			get{ return _strNuAcogmtpe; }
			set{ _strNuAcogmtpe = value; }
		}

		[DataMember()]
		public string IdRegLaboral
		{
			get{ return _strIdRegLaboral; }
			set{ _strIdRegLaboral = value; }
		}

		/// <summary>
		/// C�digo de Pa�s
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdPais
		{
			get{ return _strIdPais; }
			set{ _strIdPais = value; }
		}

		/// <summary>
		/// C�digo de Departamento
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdDepa
		{
			get{ return _strIdDepa; }
			set{ _strIdDepa = value; }
		}

		/// <summary>
		/// C�digo de Provincia
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdProv
		{
			get{ return _strIdProv; }
			set{ _strIdProv = value; }
		}

		/// <summary>
		/// C�digo de Distrito
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdDist
		{
			get{ return _strIdDist; }
			set{ _strIdDist = value; }
		}

		[DataMember()]
		public string StAdmPublica
		{
			get{ return _strStAdmPublica; }
			set{ _strStAdmPublica = value; }
		}

		[DataMember()]
		public string StAgenEmple
		{
			get{ return _strStAgenEmple; }
			set{ _strStAgenEmple = value; }
		}

		[DataMember()]
		public string StEmpIntLab
		{
			get{ return _strStEmpIntLab; }
			set{ _strStEmpIntLab = value; }
		}

		[DataMember()]
		public string StAfecSenati
		{
			get{ return _strStAfecSenati; }
			set{ _strStAfecSenati = value; }
		}

		[DataMember()]
		public string StMicroEmp
		{
			get{ return _strStMicroEmp; }
			set{ _strStMicroEmp = value; }
		}

		/// <summary>
		/// Estado Activo
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StActivo
		{
			get{ return _strStActivo; }
			set{ _strStActivo = value; }
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
