using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: liquidacion (RH_Liquidacion)
   /// </summary>
   [DataContract()]
    public class ELiquidacionBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;

      private string _strIdEmpresa = "";
      private string _strIdPeriodo = "";
      private string _strIdLiquidacion = "";
      private string _strIdPersonal = "";
      private string _strNuDocIden = "";
      private string _strDsApellNom = "";
      private string _strIdPlanilla = "";
      private DateTime _strFeIngreso;
      private DateTime _strFeCese;


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
      /// Código Periodo
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
      /// Código de IDLiquidacion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdLiquidacion
      {
         get { return _strIdLiquidacion; }
          set { _strIdLiquidacion = value; }
      }

      /// <summary>
      /// Código de IdPersonal
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
      /// Código de IdNuDocIden
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
      /// Código de DsApellNom
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
      /// Fecha ingreso a Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public DateTime FeIngreso
      {
          get { return _strFeIngreso; }
          set { _strFeIngreso = value; }
      }

      /// <summary>
      /// Fecha Cese
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public DateTime FeCese
      {
          get { return _strFeCese; }
          set { _strFeCese = value; }
      }
       
      #endregion
   }
}

