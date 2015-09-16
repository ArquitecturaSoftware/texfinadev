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
   public class EVarCalcSet : IEntityBase
   {

      #region Campos

      private EVarCalc _objE = null;
      private IList<EVarCalcDet> _objcol = null;

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
      public EVarCalc VarCalc
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<EVarCalcDet> VarCalcDet
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      #endregion

   }
}