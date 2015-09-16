using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EEmpresa
   /// </summary>
   [DataContract()]
   public class EPlanillaSet : IEntityBase
   {

      #region Campos

      private EPlanilla _objE = null;
      private IList<EPlanillaDet> _objcol = null;

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
      public EPlanilla Planilla
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<EPlanillaDet> ColPlanilla
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      #endregion

   }
}