using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;

namespace Texfina.Entity.Co
{
   /// <summary>
   /// Contenedor para la Entidad EEmpresa
   /// </summary>
   [DataContract()]
   public class EBienFiscaEstableSet : IEntityBase
   {

      #region Campos

       private EBienFiscaEstable _objE = null;

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
      public EBienFiscaEstable BienFiscaEstable
      {
         get { return _objE; }
         set { _objE = value; }
      }

      #endregion

   }
}