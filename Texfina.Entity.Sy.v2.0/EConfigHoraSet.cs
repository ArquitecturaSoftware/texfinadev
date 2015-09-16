using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Sy;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Contenedor para la Entidad EEmpresa
   /// </summary>
   [DataContract()]
   public class EConfigHoraSet : IEntityBase
   {

      #region Campos

      private IList<EConfigHora> _objcol = null;

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
      public IList<EConfigHora> ColConfigHora
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      #endregion

   }
}