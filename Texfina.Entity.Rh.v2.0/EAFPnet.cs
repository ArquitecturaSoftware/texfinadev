using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para exportar datos a AFPnet
   /// </summary>
   [DataContract()]
    public class EAFPnet : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdForPago = "";
      private string _strIdMes = "";
      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      /// <summary>
      /// Código de Periodo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPeriodo
      {
         get { return _strIdPeriodo; }
         set { _strIdPeriodo = value; }
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

      [DataMember()]
      public string IdForPago
      {
         get { return _strIdForPago; }
         set { _strIdForPago = value; }
      }

      /// <summary>
      /// Código de Mes
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdMes
      {
         get { return _strIdMes; }
         set { _strIdMes = value; }
      }

      #endregion

   }
}
