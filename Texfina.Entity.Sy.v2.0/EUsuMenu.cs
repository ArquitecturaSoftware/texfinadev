using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
	/// <summary>
	/// Entidad para la Tabla: Usuario - Menu (SY_UsuMenu)
	/// </summary>
	[DataContract()]
	public class EUsuMenu: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdUser = "";
		private string _strIdMenu = "";
		private byte[] _bytIdDerechos = null;
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
		public string IdUser
		{
			get{ return _strIdUser; }
			set{ _strIdUser = value; }
		}

		/// <summary>
		/// Código de Menu
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdMenu
		{
			get{ return _strIdMenu; }
			set{ _strIdMenu = value; }
		}

		/// <summary>
		/// Código de Derechos
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public byte[] IdDerechos
		{
			get{ return _bytIdDerechos; }
			set{ _bytIdDerechos = value; }
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
