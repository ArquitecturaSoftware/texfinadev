using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Proceso de Planilla (RH_ProcPlani)
   /// </summary>
   [DataContract()]
   public class EConstCTS : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdCTS = "";
      private string _strIdPlanilla = "";

      private string _strIdEstable = "";
      private string _strIdUNegocio = "";
      private string _strIdCCosto = "";
      private string _strIdPersonal = "";


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
      /// Código de CTS
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCTS
      {
         get { return _strIdCTS; }
         set { _strIdCTS = value; }
      }

      /// <summary>
      /// Código de Establecimiento
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
      /// Código de UNegocio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdUNegocio
      {
         get { return _strIdUNegocio; }
         set { _strIdUNegocio = value; }
      }

      /// <summary>
      /// Código de UCCosto
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
      /// Código de Personal Inicio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPersonal
      {
         get { return _strIdPersonal; }
         set { _strIdPersonal = value; }
      }


      #endregion

   }
}
