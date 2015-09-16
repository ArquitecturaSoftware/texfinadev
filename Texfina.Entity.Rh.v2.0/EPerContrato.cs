using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_PerContrato (RH_PerContrato)
   /// </summary>
   [DataContract()]
   public class EPerContrato : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private int _intNuSecuen = 0;
      private DateTime _datFeSuscripcion;
      private DateTime _datFeInicio;
      private DateTime _datFeFin;
      private string _strIdMotivFin = "";
      private Nullable<DateTime> _datFeCese = null;
      private string _strDsObservacion = "";
      private string _strIdPuesto = "";
      private string _strDsFuncion = "";
      private string _strIdRegLaboral = "";
      private string _strStMype = "";
      private string _strStDiscapacid = "";
      private string _strIdModalidad = "";
      private string _strIdSubModal = "";
      private string _strIdTipo = "";
      private string _strIdGrpOcupac = "";
      private string _strIdMoneda = "";
      private string _strIdPeriRemu = "";
      private decimal _decMtRemunera = 0;
      private string _strIdRemVariable = "";
      private string _strStRemuEspecie = "";
      private string _strStRemuMinima = "";
      private string _strStProrroga = "";
      private string _strStContrato = "";
      private string _strStAnulado = "";
      private string _strDsAdenda = "";

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
      public int NuSecuen
      {
         get { return _intNuSecuen; }
         set { _intNuSecuen = value; }
      }

      [DataMember()]
      public DateTime FeSuscripcion
      {
         get { return _datFeSuscripcion; }
         set { _datFeSuscripcion = value; }
      }

      [DataMember()]
      public DateTime FeInicio
      {
         get { return _datFeInicio; }
         set { _datFeInicio = value; }
      }

      [DataMember()]
      public DateTime FeFin
      {
         get { return _datFeFin; }
         set { _datFeFin = value; }
      }

      [DataMember()]
      public string IdMotivFin
      {
         get { return _strIdMotivFin; }
         set { _strIdMotivFin = value; }
      }

      [DataMember()]
      public Nullable<DateTime> FeCese
      {
          get { return _datFeCese; }
          set { _datFeCese = value; }
      }

      /// <summary>
      /// Observaciones de Motivo Cese
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsObservacion
      {
         get { return _strDsObservacion; }
         set { _strDsObservacion = value; }
      }

      [DataMember()]
      public string IdPuesto
      {
         get { return _strIdPuesto; }
         set { _strIdPuesto = value; }
      }

      /// <summary>
      /// Descripcion de Funcion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsFuncion
      {
         get { return _strDsFuncion; }
         set { _strDsFuncion = value; }
      }

      [DataMember()]
      public string IdRegLaboral
      {
         get { return _strIdRegLaboral; }
         set { _strIdRegLaboral = value; }
      }

      [DataMember()]
      public string StMype
      {
         get { return _strStMype; }
         set { _strStMype = value; }
      }

      [DataMember()]
      public string StDiscapacid
      {
         get { return _strStDiscapacid; }
         set { _strStDiscapacid = value; }
      }

      [DataMember()]
      public string IdModalidad
      {
         get { return _strIdModalidad; }
         set { _strIdModalidad = value; }
      }

      [DataMember()]
      public string IdSubModal
      {
         get { return _strIdSubModal; }
         set { _strIdSubModal = value; }
      }

      [DataMember()]
      public string IdTipo
      {
         get { return _strIdTipo; }
         set { _strIdTipo = value; }
      }

      [DataMember()]
      public string IdGrpOcupac
      {
         get { return _strIdGrpOcupac; }
         set { _strIdGrpOcupac = value; }
      }

      [DataMember()]
      public string IdMoneda
      {
         get { return _strIdMoneda; }
         set { _strIdMoneda = value; }
      }

      /// <summary>
      /// Periodo de Remuneracion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPeriRemu
      {
         get { return _strIdPeriRemu; }
         set { _strIdPeriRemu = value; }
      }

      [DataMember()]
      public decimal MtRemunera
      {
         get { return _decMtRemunera; }
         set { _decMtRemunera = value; }
      }

      [DataMember()]
      public string IdRemVariable
      {
         get { return _strIdRemVariable; }
         set { _strIdRemVariable = value; }
      }

      [DataMember()]
      public string StRemuEspecie
      {
         get { return _strStRemuEspecie; }
         set { _strStRemuEspecie = value; }
      }


      [DataMember()]
      public string StRemuMinima
      {
         get { return _strStRemuMinima; }
         set { _strStRemuMinima = value; }
      }

      /// <summary>
      /// Estado prorroga
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StProrroga
      {
         get { return _strStProrroga; }
         set { _strStProrroga = value; }
      }

      [DataMember()]
      public string StContrato
      {
         get { return _strStContrato; }
         set { _strStContrato = value; }
      }

      [DataMember()]
      public string StAnulado
      {
         get { return _strStAnulado; }
         set { _strStAnulado = value; }
      }

      /// <summary>
      /// Descripcion de Funcion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAdenda
      {
         get { return _strDsAdenda; }
         set { _strDsAdenda = value; }
      }

      #endregion

   }
}
