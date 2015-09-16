using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Concepto de Remuneracion - Detalle (RH_ConRemuDet)
   /// </summary>
   [DataContract()]
   public class EConRemuDet : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdConRemu = "";
      private int _intNuSecuen = 0;
      private string _strDsFormula = "";
      private string _strDsCondition = "";
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
      /// Código de Remuneración
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
      /// Número de Secuencia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuSecuen
      {
         get { return _intNuSecuen; }
         set { _intNuSecuen = value; }
      }

      /// <summary>
      /// Descripción de Formula
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsFormula
      {
         get { return _strDsFormula; }
         set { _strDsFormula = value; }
      }

      /// <summary>
      /// Descripción de Condición
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsCondition
      {
         get { return _strDsCondition; }
         set { _strDsCondition = value; }
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
