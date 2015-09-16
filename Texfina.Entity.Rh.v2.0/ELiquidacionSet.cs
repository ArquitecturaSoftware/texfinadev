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
    public class ELiquidacionSet : IEntityBase
   {

      #region Campos

      private ELiquidacion _objE = null;
      private IList<ELiquidacionDet> _objcol = null;

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
      public ELiquidacion Liquidacion
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<ELiquidacionDet> LiquidacionDet
      {
          get { return _objcol; }
          set { _objcol = value; }
      }

      #endregion

   }
}