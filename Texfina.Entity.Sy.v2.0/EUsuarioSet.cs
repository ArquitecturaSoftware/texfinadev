using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Contenedor para la Entidad EUsuario
   /// </summary>
   [DataContract()]
   public class EUsuarioSet : IEntityBase
   {

      #region "Campos"

      private EUsuario _objE = null;
      private IList<EUsuMenu> _col = null;

      #endregion

      #region "IEntityBase Members"

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

      #region "Atributos"

      [DataMember()]
      public EUsuario Usuario
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public IList<EUsuMenu> UsuMenu
      {
         get { return _col; }
         set { _col = value; }
      }

      #endregion

   }
}