using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EAfp
   /// </summary>
   [DataContract()]
   public class EAfpSet : IEntityBase
   {

      #region Campos

      private EAfp _objE = null;
      private IList<EAfpComi> _objColAfpComi = null;

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
      public EAfp Afp
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<EAfpComi> AfpComi
      {
          get { return _objColAfpComi; }
          set { _objColAfpComi = value; }
      }
      #endregion

   }
}