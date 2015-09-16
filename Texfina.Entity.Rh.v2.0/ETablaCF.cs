using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Campos disponibles en el Editor de Formulas (RH_TablaCF)
   /// </summary>
   [DataContract()]
   public class ETablaCF : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEditor = "";
      private string _strNuSeccion = "";
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
      /// Codigo del Editor
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEditor
      {
         get { return _strIdEditor; }
         set { _strIdEditor = value; }
      }

      /// <summary>
      /// Seccion del Editor
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuSeccion
      {
         get { return _strNuSeccion; }
         set { _strNuSeccion = value; }
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