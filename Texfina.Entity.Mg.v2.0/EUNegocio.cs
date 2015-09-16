using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: MG_UNegocio (MG_UNegocio)
   /// </summary>
   [DataContract()]
   public class EUNegocio : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdUNegocio = "";
      private string _strDsUNegocio = "";
      private string _strDsAbrev = "";
      private string _strStAnulado = "";

      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      /// <summary>
      /// Codigo de Empresa
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
      /// Codigo de Unidad de Negocio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdUNegocio
      {
         get { return _strIdUNegocio; }
         set { _strIdUNegocio = value; }
      }

      /// <summary>
      /// Descripcion de Unidad de Negocio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsUNegocio
      {
         get { return _strDsUNegocio; }
         set { _strDsUNegocio = value; }
      }

      /// <summary>
      /// Abreviacion de Unidad de Negocio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAbrev
      {
         get { return _strDsAbrev; }
         set { _strDsAbrev = value; }
      }

      /// <summary>
      /// Estado Anulado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAnulado
      {
         get { return _strStAnulado; }
         set { _strStAnulado = value; }
      }

      #endregion

   }
}
