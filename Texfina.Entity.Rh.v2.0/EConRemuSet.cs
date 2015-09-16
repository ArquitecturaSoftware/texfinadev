using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EConcepRemu
   /// </summary>
   [DataContract()]
   public class EConRemuSet : IEntityBase
   {

      #region Campos

      private EConcepRemu _objE = null;
      private IList<EConRemuDet> _objcol = null;
      private IList<EConRemuCampo> _objColFld = null;

      #endregion

      #region IEntityBase Members

      public EntityState EntityState
      {
         get
         {
            throw new NotImplementedException();
         }
         set
         {
            throw new NotImplementedException();
         }
      }

      #endregion

      #region Atributos

      [DataMember()]
      public EConcepRemu ConcepRemu
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<EConRemuDet> ConRemuDet
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      [DataMember()]
      public IList<EConRemuCampo> ConRemuCampo
      {
         get { return _objColFld; }
         set { _objColFld = value; }
      }

      #endregion

   }
}