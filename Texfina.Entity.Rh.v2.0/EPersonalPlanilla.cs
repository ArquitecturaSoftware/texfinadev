using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
    /// Entidad para la Tabla: Personal planilla (RH_PerPlanilla)
   /// </summary>
   [DataContract()]
    public class EPersonalPlanilla : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strIdPlanilla = "";
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
      /// Código de Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPlanilla
      {
          get { return _strIdPlanilla; }
          set { _strIdPlanilla = value; }
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
