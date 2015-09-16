
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Contenedor para la Entidad EEmpresa
   /// </summary>
   [DataContract()]
   public class ETablaGenSet : IEntityBase
   {

      #region Campos

      private ETablaGen _objE = null;
      private IList<ETablaGenDet> _objcol = null;

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
      public ETablaGen TablaGen
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<ETablaGenDet> ColTablaGen
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      #endregion

   }
}