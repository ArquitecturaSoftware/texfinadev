using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_PerHistoAprob (RH_PerHistoAprob)
   /// </summary>
   [DataContract()]
   public class EPerHistoAprob : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPersonal = "";
      private int _intNuSecuen = 0;
      private string _strIdEstado = "";
      private string _strIdUser = "";
      private DateTime _datFeAccion;
      private string _strDsObservacion = "";
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

      [DataMember()]
      public int NuSecuen
      {
         get { return _intNuSecuen; }
         set { _intNuSecuen = value; }
      }

      [DataMember()]
      public string IdEstado
      {
         get { return _strIdEstado; }
         set { _strIdEstado = value; }
      }

      [DataMember()]
      public string IdUser
      {
         get { return _strIdUser; }
         set { _strIdUser = value; }
      }

      [DataMember()]
      public DateTime FeAccion
      {
         get { return _datFeAccion; }
         set { _datFeAccion = value; }
      }

      [DataMember()]
      public string DsObservacion
      {
         get { return _strDsObservacion; }
         set { _strDsObservacion = value; }
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
