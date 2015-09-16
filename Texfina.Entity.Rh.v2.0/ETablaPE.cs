using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Tabla Parametrica de la Planilla Electronica (RH_TablaPE)
   /// </summary>
   [DataContract()]
   public class ETablaPE : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdTabla = "";
      private string _strDsTabla = "";
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
