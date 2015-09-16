using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EProcPlaHora
   /// </summary>
   [DataContract()]
   public class EProcPlaHoraSet : IEntityBase
   {

      #region Campos

      private IList<EProcPlaHora> _objcol = null;

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
      public IList<EProcPlaHora> EProcPlaHora
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      #endregion

   }
}