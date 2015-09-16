using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_VarCalcDet (RH_VarCalcDet)
   /// </summary>
   [DataContract()]
   public class EVarCalcDet : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdVarCalc = "";
      private string _strStFiltro = "";
      private string _strNuValor = "";

      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      [DataMember()]
      public string IdVarCalc
      {
         get { return _strIdVarCalc; }
         set { _strIdVarCalc = value; }
      }

      [DataMember()]
      public string StFiltro
      {
         get { return _strStFiltro; }
         set { _strStFiltro = value; }
      }

      [DataMember()]
      public string NuValor
      {
         get { return _strNuValor; }
         set { _strNuValor = value; }
      }

      #endregion

   }
}
