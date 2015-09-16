using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Texfina.Core.Data;
using Texfina.Entity.Mg;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Contenedor para la Entidad EEmpresa
   /// </summary>
   [DataContract()]
   public class EPersonalSet : IEntityBase
   {

      #region Campos

      private EPersonal _objE = null;
      private ECliProv _objECli = null;
      private EPerFoto _objEFoto = null;
      private IList<EPerContraArch> _objColContraArch = null;
      private EPerHistoAprob _objEHistoAprob = null;
      private IList<EPerDepen> _objColPerDepen = null;
      private IList<EPerContrato> _objColPerContrato = null;
      private IList<EPerPlanilla> _objColPerPlanilla = null;
      private IList<EPerExpeLabo> _objColPerExpeLabo = null;
      private IList<EPerEducacion> _objColPerEducacion = null;
      private IList<EPerRemu> _objColPerRemu = null;
      #endregion

      #region IEntityBase Members

      public EntityState EntityState
      {
         get
         {
            throw new NotImplementedException();
         }
         set
         {
            throw new NotImplementedException();
         }
      }

      #endregion

      #region Atributos

      [DataMember()]
      public EPersonal Personal
      {
         get { return _objE; }
         set { _objE = value; }
      }

      [DataMember()]
      public ECliProv CliProv
      {
         get { return _objECli; }
         set { _objECli = value; }
      }

      [DataMember()]
      public EPerFoto PerFoto
      {
         get { return _objEFoto; }
         set { _objEFoto = value; }
      }
       
      public IList<EPerContraArch> ColContraArch
      {
          get { return _objColContraArch; }
          set { _objColContraArch = value; }
      }

      [DataMember()]
      public EPerHistoAprob HistoAprob
      {
         get { return _objEHistoAprob; }
         set { _objEHistoAprob = value; }
      }

      [DataMember()]
      public IList<EPerDepen> ColPerDepen
      {
         get { return _objColPerDepen; }
         set { _objColPerDepen = value; }
      }

      [DataMember()]
      public IList<EPerContrato> ColPerContrato
      {
         get { return _objColPerContrato; }
         set { _objColPerContrato = value; }
      }

      [DataMember()]
      public IList<EPerPlanilla> ColPerPlanilla
      {
         get { return _objColPerPlanilla; }
         set { _objColPerPlanilla = value; }
      }

      [DataMember()]
      public IList<EPerExpeLabo> ColPerExpeLabo 
      {
          get { return _objColPerExpeLabo; }
          set { _objColPerExpeLabo = value; }
      }

      [DataMember()]
      public IList<EPerEducacion> ColPerEducacion
      {
          get { return _objColPerEducacion; }
          set { _objColPerEducacion = value; }
      }

      [DataMember()]
      public IList<EPerRemu> ColPerRemu
      {
          get { return _objColPerRemu; }
          set { _objColPerRemu = value; }
      }

      #endregion

   }
}