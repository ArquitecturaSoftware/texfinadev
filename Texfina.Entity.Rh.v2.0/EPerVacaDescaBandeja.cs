using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Personal (RH_Personal)
   /// </summary>
   [DataContract()]
    public class EPerVacaDescaBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;

      private string _strIdEmpresa = "";
      private string _strIdPeriodo = "";
      private string _strIdPersonal = "";
      private string _strIdPerVaca = "";
      private string _strDsApellNom = "";
      private string _strNuDocIden = "";
       
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
      /// Código de Personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdVacaDesca
      {
          get { return _strIdPerVaca; }
          set { _strIdPerVaca = value; }
      }

      /// <summary>
      /// Código de Personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPersonal
      {
         get { return _strIdPersonal; }
         set { _strIdPersonal = value; }
      }
       
      /// <summary>
      /// Nombres
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsApellNom
      {
         get { return _strDsApellNom; }
         set { _strDsApellNom = value; }
      }
       
      /// <summary>
      /// Número Documento de Identidad
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuDocIden
      {
         get { return _strNuDocIden; }
         set { _strNuDocIden = value; }
      }

      #endregion

   }
}
