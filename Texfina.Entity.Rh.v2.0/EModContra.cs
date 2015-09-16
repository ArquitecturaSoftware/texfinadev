using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_ModalidadContra (RH_ModalidadContra)
   /// </summary>
   [DataContract()]
   public class EModContra : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdModalidad = "";
      private string _strDsModalidad = "";
      private string _strStAnulado = "";

      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      [DataMember()]
      public string IdModalidad
      {
         get { return _strIdModalidad; }
         set { _strIdModalidad = value; }
      }

      [DataMember()]
      public string DsModalidad
      {
         get { return _strDsModalidad; }
         set { _strDsModalidad = value; }
      }

      [DataMember()]
      public string StAnulado
      {
         get { return _strStAnulado; }
         set { _strStAnulado = value; }
      }

      #endregion

   }
}
