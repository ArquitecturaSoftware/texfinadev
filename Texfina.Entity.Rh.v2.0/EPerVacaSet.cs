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
   public class EPerVacaSet : IEntityBase
   {

      #region Campos
      
      private IList<EPerVacaProg> _objcolProg = null;
      private IList<EPerVacaDesca> _objcolDesca = null;

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
      public IList<EPerVacaProg> ColVacaProg
      {
         get { return _objcolProg; }
         set { _objcolProg = value; }
      }
      
      [DataMember()]
      public IList<EPerVacaDesca> ColVacaDescanso
      {
         get { return _objcolDesca; }
         set { _objcolDesca = value; }
      }

      #endregion

   }
}
