using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Prestamo (RH_Prestamo)
   /// </summary>
   [DataContract()]
   public class EPrestamo : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strIdPrestamo = "";
      private string _strIdConRemu = "";
      private DateTime _datFePrestamo;
      private string _strIdMoneda = "";
      private decimal _decMtTC = 0;
      private decimal _decMtPrestamo = 0;
      private int _intQtCuotas = 0;
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private int _intNuProcAnual = 0;
      private string _strIdTipoPrest = "";
      private string _strStDocumento = "";
      private string _strStAnulado = "";
      //Agregando el comentario u Observacion
      private string _strDsObserva = "";

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
      /// Código Concepto de Remuneración
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdConRemu
      {
         get { return _strIdConRemu; }
         set { _strIdConRemu = value; }
      }

      /// <summary>
      /// Fecha de Prestamo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public DateTime FePrestamo
      {
         get { return _datFePrestamo; }
         set { _datFePrestamo = value; }
      }

      /// <summary>
      /// Código de Moneda
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdMoneda
      {
         get { return _strIdMoneda; }
         set { _strIdMoneda = value; }
      }

      /// <summary>
      /// Monto Tipo de Cambio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtTC
      {
         get { return _decMtTC; }
         set { _decMtTC = value; }
      }

      /// <summary>
      /// Monto Prestamo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal MtPrestamo
      {
         get { return _decMtPrestamo; }
         set { _decMtPrestamo = value; }
      }

      /// <summary>
      /// Cantidad de Cuotas
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int QtCuotas
      {
         get { return _intQtCuotas; }
         set { _intQtCuotas = value; }
      }
      
      /// <summary>
      /// Forma de Pago
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
      /// Tipo de Prestamo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoPrest
      {
         get { return _strIdTipoPrest; }
         set { _strIdTipoPrest = value; }
      }

      /// <summary>
      /// Estado de Documento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StDocumento
      {
         get { return _strStDocumento; }
         set { _strStDocumento = value; }
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

      /// <summary>
      /// Observacion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsObserva
      {
         get { return _strDsObserva; }
         set { _strDsObserva = value; }
      }

      #endregion

   }
}
