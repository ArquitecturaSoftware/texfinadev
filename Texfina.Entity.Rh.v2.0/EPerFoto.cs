using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
	/// <summary>
	/// Entidad para la Tabla: RH_PerFoto (RH_PerFoto)
	/// </summary>
	[DataContract()]
	public class EPerFoto: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdEmpresa = "";
		private string _strIdPersonal = "";
		private string _strDsNombreArch = "";
		private byte[] _IdFotografia = null;

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
		/// Código de Personal
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdPersonal
		{
			get{ return _strIdPersonal; }
			set{ _strIdPersonal = value; }
		}

		[DataMember()]
		public string DsNombreArch
		{
			get{ return _strDsNombreArch; }
			set{ _strDsNombreArch = value; }
		}

		[DataMember()]
		public byte[] IdFotografia
		{
			get{ return _IdFotografia; }
			set{ _IdFotografia = value; }
		}

		#endregion

	}
}
