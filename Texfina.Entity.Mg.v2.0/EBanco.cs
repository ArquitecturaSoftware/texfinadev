using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: Banco (MG_Banco)
   /// </summary>
   [DataContract()]
   public class EBanco : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdBanco = "";
      private string _strDsBanco = "";
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
      /// Código de Banco
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdBanco
      {
         get { return _strIdBanco; }
         set { _strIdBanco = value; }
      }

      /// <summary>
      /// Descripción de Banco
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsBanco
      {
         get { return _strDsBanco; }
         set { _strDsBanco = value; }
      }

      /// <summary>
      /// Abreviatura de Banco 
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
