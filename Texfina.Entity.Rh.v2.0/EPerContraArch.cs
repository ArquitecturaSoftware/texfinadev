using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
	/// <summary>
	/// Entidad para la Tabla: RH_PerContraArch (RH_PerContraArch)
	/// </summary>
	[DataContract()]
	public class EPerContraArch: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdEmpresa = "";
		private string _strIdPersonal = "";
		private int _intNuSecuen = 0;
		private string _strDsNombreArch = "";
		private byte[] _IdContrato= null;
		private string _strStAnulado = "";

		#endregion

		#region Atributos

		[DataMember()]
		public EntityState EntityState
		{
			get{ return _intState; }
			set{ _intState = value; }
		}

		[DataMember()]
		public string IdEmpresa
		{
			get{ return _strIdEmpresa; }
			set{ _strIdEmpresa = value; }
		}

		[DataMember()]
		public string IdPersonal
		{
			get{ return _strIdPersonal; }
			set{ _strIdPersonal = value; }
		}

		[DataMember()]
		public int NuSecuen
		{
			get{ return _intNuSecuen; }
			set{ _intNuSecuen = value; }
		}

		[DataMember()]
		public string DsNombreArch
		{
			get{ return _strDsNombreArch; }
			set{ _strDsNombreArch = value; }
		}

		[DataMember()]
      public byte[] IdContrato
		{
			get{ return _IdContrato; }
			set{ _IdContrato = value; }
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
