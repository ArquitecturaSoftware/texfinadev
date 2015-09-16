using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EPerVacaSet
   /// </summary>
   [DataContract()]
    public class EPerVacaDescaSet : IEntityBase
   {

      #region Campos
      
      private EPerVacaDesca _objPerVacaDesca = null;
      private IList<EPerVacaDescaDet> _objcolDesca = null;

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
      public EPerVacaDesca PerVacaDesca
      {
          get { return _objPerVacaDesca; }
          set { _objPerVacaDesca = value; }
      }
      
      [DataMember()]
      public IList<EPerVacaDescaDet> ColVacaDescanso
      {
         get { return _objcolDesca; }
         set { _objcolDesca = value; }
      }

      #endregion

   }
}
