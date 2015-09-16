using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_PeriodoPlani (RH_PeriodoPlani)
   /// </summary>
   [DataContract()]
   public class EPeriodoPlani : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnual = 0;
      private string _strIdMes = "";
      private DateTime _datFeDesde;
      private DateTime _datFeHasta;
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
      /// Codigo Forma de Pago(B N)
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
      /// Proceso Anual
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuProcAnual
      {
         get { return _intNuProcAnual; }
         set { _intNuProcAnual = value; }
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

      /// <summary>
      /// Fecha - Desde
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public DateTime FeDesde
      {
         get { return _datFeDesde; }
         set { _datFeDesde = value; }
      }

      /// <summary>
      /// Fecha - Hasta
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public DateTime FeHasta
      {
         get { return _datFeHasta; }
         set { _datFeHasta = value; }
      }

      [DataMember()]
      public string StAnulado
      {
         get { return _strStAnulado; }
         set { _strStAnulado = value; }
      }

      #endregion

   }
}
