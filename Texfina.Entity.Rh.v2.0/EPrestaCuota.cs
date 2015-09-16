using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Prestamo-Cuota (RH_PrestaCuota)
   /// </summary>
   [DataContract()]
   public class EPrestaCuota : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strIdPrestamo = "";
      private int _intNuCuota = 0;
      private decimal _decMtCuota = 0;
      private string _strIdForPago = "";
      private string _strIdPeriProc = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnual = 0;
      private Nullable<DateTime> _datFeCancela = null;
      private string _strIdTipoCance = "";
      private string _strIdLiquidacion = "";
      private string _strStCuota = "";
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
      /// Código de Prestamo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPrestamo
      {
         get { return _strIdPrestamo; }
         set { _strIdPrestamo = value; }
      }

      /// <summary>
      /// Número de Cuota
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuCuota
      {
         get { return _intNuCuota; }
         set { _intNuCuota = value; }
      }

      /// <summary>
      /// Monto de Cuota
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtCuota
      {
         get { return _decMtCuota; }
         set { _decMtCuota = value; }
      }

      /// <summary>
      /// Periodo de proceso
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPeriProc
      {
          get { return _strIdPeriProc; }
          set { _strIdPeriProc = value; }
      }

      /// <summary>
      /// Forma de pago
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdForPago
      {
          get { return _strIdForPago; }
          set { _strIdForPago = value; }
      }


      [DataMember()]
      public string IdPlanilla
      {
         get { return _strIdPlanilla; }
         set { _strIdPlanilla = value; }
      }

      [DataMember()]
      public int NuProcAnual
      {
         get { return _intNuProcAnual; }
         set { _intNuProcAnual = value; }
      }

      /// <summary>
      /// Fecha de Cancelación
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeCancela
      {
         get { return _datFeCancela; }
         set { _datFeCancela = value; }
      }

      /// <summary>
      /// Código Tipo de Cancelación
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoCance
      {
         get { return _strIdTipoCance; }
         set { _strIdTipoCance = value; }
      }

      /// <summary>
      /// Código Liquidacion
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
      /// Estado de Cuota
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StCuota
      {
         get { return _strStCuota; }
         set { _strStCuota = value; }
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
