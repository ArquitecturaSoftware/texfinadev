using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: PeriodoPlani (RH_PeriodoPlani)
   /// </summary>
   [DataContract()]
   public class EPeriodoPlaniBandeja: IEntityBase
   {
      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private string _strIdmes = "";
      private string _strDsPlanilla = "";
      private string _strIdPlanillaFilter = "";

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
      /// Id de Forma de Pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdForPago
      {
         get { return _strIdForPago; }
         set { _strIdForPago = value; }
      }


      /// <summary>
      /// Id de Planilla
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
      /// Mes
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string Idmes
      {
         get { return _strIdmes; }
         set { _strIdmes = value; }
      }

      /// <summary>
      /// Descripcion Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsPlanilla
      {
         get { return _strDsPlanilla; }
         set { _strDsPlanilla = value; }
      }

      /// <summary>
      /// Id de Planilla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPlanillaFilter
      {
          get { return _strIdPlanillaFilter; }
          set { _strIdPlanillaFilter = value; }
      }

      #endregion


   }
}
