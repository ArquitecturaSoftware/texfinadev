using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
	/// <summary>
   /// Entidad para la Tabla: Usuario (SY_Usuario)
	/// </summary>
	[DataContract()]
	public class EUsuario: IEntityBase
	{

		#region Campos

		private EntityState _intState = EntityState.Unchanged;
		private string _strIdUser = "";
		private string _strIdLogon = "";
		private string _strStGrupo = "";
		private string _strDsNombres = "";
		private string _bytIdPassword = "";
		private byte[] _bytIdClavePub = null;
		private string _strStCamPswPrx = "";
		private string _strStNoCamPsw = "";
		private string _strStNoExpira = "";
		private Nullable<DateTime> _datFeExpira = null;
		private string _strStRegSist = "";
		private string _strStAnulado = "";
        private string _strpassword= "";

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
		/// Código Login
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdLogon
		{
			get{ return _strIdLogon; }
			set{ _strIdLogon = value; }
		}

		/// <summary>
		/// Estado de Grupo
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StGrupo
		{
			get{ return _strStGrupo; }
			set{ _strStGrupo = value; }
		}

		/// <summary>
		/// Descripción de Nombres
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string DsNombres
		{
			get{ return _strDsNombres; }
			set{ _strDsNombres = value; }
		}

		/// <summary>
		/// Código de Password
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string IdPassword
		{
			get{ return _bytIdPassword; }
			set{ _bytIdPassword = value; }
		}

		/// <summary>
		/// Código de Clave Publica
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public byte[] IdClavePub
		{
			get{ return _bytIdClavePub; }
			set{ _bytIdClavePub = value; }
		}

		/// <summary>
		/// Estado Cambio de Password
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StCamPswPrx
		{
			get{ return _strStCamPswPrx; }
			set{ _strStCamPswPrx = value; }
		}

		/// <summary>
		/// Estado no Cambia de Password
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StNoCamPsw
		{
			get{ return _strStNoCamPsw; }
			set{ _strStNoCamPsw = value; }
		}

		/// <summary>
		/// Estado No Expira
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StNoExpira
		{
			get{ return _strStNoExpira; }
			set{ _strStNoExpira = value; }
		}

		/// <summary>
		/// Fecha de Expiración
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public Nullable<DateTime> FeExpira
		{
			get{ return _datFeExpira; }
			set{ _datFeExpira = value; }
		}

		/// <summary>
		/// Estado Registro del Sistema
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		[DataMember()]
		public string StRegSist
		{
			get{ return _strStRegSist; }
			set{ _strStRegSist = value; }
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





        /// <summary>
        /// password
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        [DataMember()]
        public string ds_password
        {
            get { return _strpassword; }
            set { _strpassword = value; }
        }


		#endregion

	}
}