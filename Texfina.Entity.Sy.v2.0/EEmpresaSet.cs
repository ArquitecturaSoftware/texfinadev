using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Contenedor para la Entidad EEmpresa
   /// </summary>
   [DataContract()]
   public class EEmpresaSet : IEntityBase
   {

      #region Campos

      private EEmpresa _objE = null;

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
      public EEmpresa Empresa
      {
         get { return _objE; }
         set { _objE = value; }
      }

      #endregion

   }
}