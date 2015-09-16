using System;

namespace Texfina.Core.Web
{
   public enum FormEditAction
   {
      AddNew = 0,
      Edit = 1,
      Copy = 2,
      Delete = 3,
      Process = 4
   }

   public enum GridEditAction
   {

      AddNew = 0,
      Edit = 1,
      Copy = 2,
      Delete = 3
   }

   public enum NumericType
   {
      Integer = 0,
      Decimal = 1
   }

   public enum DateTimeType
   {
      Date = 0,
      DateTime = 1
   }
}
