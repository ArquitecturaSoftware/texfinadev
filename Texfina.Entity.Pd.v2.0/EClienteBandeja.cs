using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Pd
{
   /// <summary>
   /// Entidad para la Tabla: Cliente (PD_Clientes)
   /// </summary>
   [DataContract()]
   public class EClienteBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      
      private string _strIdEmpresa = "";
      private string _strIdCliente = "";
      private string _strDsRazSocial = "";
      private string _strNuNif = "";
      private string _strDsDistrito = "";


      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }


      /// <summary>
      /// Código de Empresa
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEmpresa
      {
         get { return _strIdEmpresa; }
         set { _strIdEmpresa = value; }
      }

      /// <summary>
      /// Código de Cliente
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCliente
      {
         get { return _strIdCliente; }
         set { _strIdCliente = value; }
      }


      /// <summary>
      /// Razon Social
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsRazSocial
      {
         get { return _strDsRazSocial; }
         set { _strDsRazSocial = value; }
      }


      /// <summary>
      /// Número Documento de Identidad
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuNif
      {
         get { return _strNuNif; }
         set { _strNuNif = value; }
      }


      /// <summary>
      /// Distrito
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string dsDistrito
      {
          get { return _strDsDistrito; }
          set { _strDsDistrito = value; }
      }
       

      #endregion

   }
}
