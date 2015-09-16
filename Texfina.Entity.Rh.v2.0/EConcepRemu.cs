using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Concepto de Remuneracion (RH_ConcepRemu)
   /// </summary>
   [DataContract()]
   public class EConcepRemu : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdConRemu = "";
      private string _strDsConRemu = "";
      private string _strIdTipConcep = "";
      private string _strIdIngtrides = "";
      private string _strStUsaFormu = "";
      private string _strDsFormHra = "";
      private string _strDsFormula = "";
      private string _strDsCondition = "";
      private string _strStProcAdic = "";
      private string _strStAfectaGrati = "";
      private string _strIdTipoRemu = "";
      private string _strStCtaCte = "";
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
      /// Descripción Concepto de Remuneración
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsConRemu
      {
         get { return _strDsConRemu; }
         set { _strDsConRemu = value; }
      }

      /// <summary>
      /// Código Tipo de Concepto de Remuneración
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipConcep
      {
         get { return _strIdTipConcep; }
         set { _strIdTipConcep = value; }
      }

      /// <summary>
      /// Código de Ingreso
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdIngtrides
      {
         get { return _strIdIngtrides; }
         set { _strIdIngtrides = value; }
      }

      /// <summary>
      /// Estado Usa Formulario
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StUsaFormu
      {
         get { return _strStUsaFormu; }
         set { _strStUsaFormu = value; }
      }

      /// <summary>
      /// Descripción de Formula 
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsFormHra
      {
         get { return _strDsFormHra; }
         set { _strDsFormHra = value; }
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
      /// Estado Proc Adicional
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StProcAdic
      {
         get { return _strStProcAdic; }
         set { _strStProcAdic = value; }
      }

      /// <summary>
      /// Estado de afectacion a gratificacion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAfectaGrati
      {
          get { return _strStAfectaGrati; }
          set { _strStAfectaGrati = value; }
      }

      /// <summary>
      /// Tipo de Remuneracion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoRemu
      {
          get { return _strIdTipoRemu; }
          set { _strIdTipoRemu = value; }
      }

      /// <summary>
      /// Estado de Concepto de Cuentas Corrientes
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StCtaCte
      {
          get { return _strStCtaCte; }
          set { _strStCtaCte = value; }
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