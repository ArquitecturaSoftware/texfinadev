using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
	/// <summary>
	/// Entidad para la Tabla: Usuario - Grupo (SY_UsuGrupo)
	/// </summary>
	[DataContract()]
	public class EUsuGrupo: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdUsuario = "";
		private string _strIdGrupo = "";
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
		/// Código de Usuario
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdUsuario
		{
			get{ return _strIdUsuario; }
			set{ _strIdUsuario = value; }
		}

		/// <summary>
		/// Código de Grupo
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdGrupo
		{
			get{ return _strIdGrupo; }
			set{ _strIdGrupo = value; }
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
