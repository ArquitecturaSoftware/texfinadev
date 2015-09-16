using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_PerVacaProg (RH_PerVacaProg)
   /// </summary>
   [DataContract()]
   public class EPerVacaProg : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private string _strIdPeriVac = "";
      private int _intNuSecuen = 0;
      private string _strIdForPago = "";
      private string _strIdPlanilla = "";
      private string _strIdConRemu = "";
      private int _intNuDiasVaca = 0;
      private decimal _decMtVaca = 0;
      private string _strIdPeriAnualIni = "";
      private int _intNuProcAnualIni = 0;
      private Nullable<DateTime> _datFeVacaIni = null;
      private string _strIdPeriAnualFin = "";
      private int _intNuProcAnualFin = 0;
      private Nullable<DateTime> _datFeVacaFin = null;
      private decimal _decNuDiasGozado = 0;
      private string _strStVaca = "";
      private string _strStAnulado = "";

      #endregion

      #region Atributos

      [DataMember()]
      public EntityState EntityState
      {
         get { return _intState; }
         set { _intState = value; }
      }

      [DataMember()]
      public string IdEmpresa
      {
         get { return _strIdEmpresa; }
         set { _strIdEmpresa = value; }
      }

      [DataMember()]
      public string IdPersonal
      {
         get { return _strIdPersonal; }
         set { _strIdPersonal = value; }
      }

      [DataMember()]
      public string IdPeriVac
      {
         get { return _strIdPeriVac; }
         set { _strIdPeriVac = value; }
      }

      [DataMember()]
      public int NuSecuen
      {
         get { return _intNuSecuen; }
         set { _intNuSecuen = value; }
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
      public string IdConRemu
      {
         get { return _strIdConRemu; }
         set { _strIdConRemu = value; }
      }

      [DataMember()]
      public int NuDiasVaca
      {
         get { return _intNuDiasVaca; }
         set { _intNuDiasVaca = value; }
      }

      [DataMember()]
      public decimal MtVaca
      {
         get { return _decMtVaca; }
         set { _decMtVaca = value; }
      }

      [DataMember()]
      public string IdPeriAnualIni
      {
         get { return _strIdPeriAnualIni; }
         set { _strIdPeriAnualIni = value; }
      }

      [DataMember()]
      public int NuProcAnualIni
      {
         get { return _intNuProcAnualIni; }
         set { _intNuProcAnualIni = value; }
      }

      [DataMember()]
      public Nullable<DateTime> FeVacaIni
      {
         get { return _datFeVacaIni; }
         set { _datFeVacaIni = value; }
      }

      [DataMember()]
      public string IdPeriAnualFin
      {
         get { return _strIdPeriAnualFin; }
         set { _strIdPeriAnualFin = value; }
      }

      [DataMember()]
      public int NuProcAnualFin
      {
         get { return _intNuProcAnualFin; }
         set { _intNuProcAnualFin = value; }
      }

      [DataMember()]
      public Nullable<DateTime> FeVacaFin
      {
         get { return _datFeVacaFin; }
         set { _datFeVacaFin = value; }
      }

      [DataMember()]
      public decimal NuDiasGozado
      {
         get { return _decNuDiasGozado; }
         set { _decNuDiasGozado = value; }
      }

      [DataMember()]
      public string StVaca
      {
         get { return _strStVaca; }
         set { _strStVaca = value; }
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
