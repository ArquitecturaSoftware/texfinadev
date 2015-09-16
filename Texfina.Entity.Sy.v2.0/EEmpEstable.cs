using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Entidad para la Tabla: Empresa Establecimiento (SY_EmpEstable)
   /// </summary>
   [DataContract()]
   public class EEmpEstable : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdEstable = "";
      private string _strDsEstable = "";
      private string _strStCentRiesgo = "";
      private string _strStAnulado = "";

      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      /// <summary>
      /// Código de Empresa
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEmpresa
      {
         get { return _strIdEmpresa; }
         set { _strIdEmpresa = value; }
      }

      /// <summary>
      /// Código Establecimiento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEstable
      {
         get { return _strIdEstable; }
         set { _strIdEstable = value; }
      }

      /// <summary>
      /// Descripción Establecimiento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsEstable
      {
         get { return _strDsEstable; }
         set { _strDsEstable = value; }
      }

      /// <summary>
      /// Estado Centro de Riesgo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StCentRiesgo
      {
         get { return _strStCentRiesgo; }
         set { _strStCentRiesgo = value; }
      }

      /// <summary>
      /// Estado Anulado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAnulado
      {
         get { return _strStAnulado; }
         set { _strStAnulado = value; }
      }

      #endregion

   }
}
