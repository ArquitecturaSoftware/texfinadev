using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Personal (RH_Personal)
   /// </summary>
   [DataContract()]
   public class EPersonalBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;

      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strDsApellNom = "";
      private string _strNuDocIden = "";
      private Nullable<DateTime> _dtFeFinA = null;
      private Nullable<DateTime> _dtFeFinB = null;
      private string _strIdPlanilla = "";
      private string _strIdEstable = "";
      private string _strIdUNegocio = "";
      private string _strIdCCosto = "";
      private string _strIdMes = "";
      private string _strIdPeriodo = "";

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

      /// <summary>
      /// Fecha Desde
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public Nullable<DateTime> FeFinA
      {
         get { return _dtFeFinA; }
         set { _dtFeFinA = value; }
      }

      /// <summary>
      /// Fecha Hasta
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public Nullable<DateTime> FeFinB
      {
         get { return _dtFeFinB; }
         set { _dtFeFinB = value; }
      }

      /// <summary>
      /// Planilla
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
      /// Establecimiento
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
      /// Unidad de Negocio
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
      /// Centro de Costo
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
      /// Mes de Inicio de vacaciones
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdMes
      {
          get { return _strIdMes; }
          set { _strIdMes= value; }
      }

      /// <summary>
      /// periodo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPeriodo
      {
          get { return _strIdPeriodo; }
          set { _strIdPeriodo = value; }
      }

      #endregion

   }
}
