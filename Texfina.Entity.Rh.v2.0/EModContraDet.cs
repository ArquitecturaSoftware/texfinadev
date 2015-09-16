using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_ModalidadContraDet (RH_ModalidadContraDet)
   /// </summary>
   [DataContract()]
   public class EModContraDet : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdModalidad = "";
      private string _strIdSubModalidad = "";
      private string _strDsSubModalidad = "";
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
      public string IdSubModalidad
      {
         get { return _strIdSubModalidad; }
         set { _strIdSubModalidad = value; }
      }

      [DataMember()]
      public string DsSubModalidad
      {
         get { return _strDsSubModalidad; }
         set { _strDsSubModalidad = value; }
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
