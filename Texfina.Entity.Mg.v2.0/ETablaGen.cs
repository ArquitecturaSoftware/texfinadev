using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: Tabla General (MG_TablaGen)
   /// </summary>
   [DataContract()]
   public class ETablaGen : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdTabla = "";
      private string _strDsTabla = "";
      private string _strStRegSist = "";
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
      /// Código de la Tabla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTabla
      {
         get { return _strIdTabla; }
         set { _strIdTabla = value; }
      }

      /// <summary>
      /// Descripción de la Tabla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsTabla
      {
         get { return _strDsTabla; }
         set { _strDsTabla = value; }
      }

      /// <summary>
      /// Estado Registro del Sistema
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StRegSist
      {
         get { return _strStRegSist; }
         set { _strStRegSist = value; }
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
