using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: Centro de Costo (MG_CCosto)
   /// </summary>
   [DataContract()]
   public class ECCosto : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdCCosto = "";
      private string _strDsCCosto = "";
      private string _strDsAbrev = "";
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
      /// Código Centro de Costo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCCosto
      {
         get { return _strIdCCosto; }
         set { _strIdCCosto = value; }
      }

      /// <summary>
      /// Descripción del Centro de Costo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsCCosto
      {
         get { return _strDsCCosto; }
         set { _strDsCCosto = value; }
      }

      /// <summary>
      /// Descripción de Abreviatura del Centro de Costo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAbrev
      {
         get { return _strDsAbrev; }
         set { _strDsAbrev = value; }
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
