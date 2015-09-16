using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EFeriado
   /// </summary>
   [DataContract()]
   public class EDiaDescansoSet : IEntityBase
   {

      #region Campos


      private IList<EDiaDescanso> _objcol = null;

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
      public IList<EDiaDescanso> ColDiaDescanso
      {
         get { return _objcol; }
         set { _objcol = value; }
      }

      #endregion

   }
}
