﻿using System;

namespace Texfina.Core.Data
{
   /// <summary>
   /// Interface general para las Entidades
   /// </summary>
   public interface IEntityBase
   {
      /// <summary>
      /// Estado de la Entidad, representa los valores de la enumeracion EntityState
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      /// <remarks></remarks>
      EntityState EntityState { get; set; }
   }
}
