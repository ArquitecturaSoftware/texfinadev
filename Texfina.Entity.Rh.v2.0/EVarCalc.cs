using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: RH_VarCalc (RH_VarCalc)
   /// </summary>
   [DataContract()]
   public class EVarCalc : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdVarCalc = "";
      private string _strDsVarCalc = "";
      private string _strIdTipo = "";
      private string _strDsCondicion = "";
      private string _strIdTabla = "";
      private string _strIdAcumula = "";
      private string _strIdColumn = "";
      private string _strStCondic1 = "";
      private string _strDsCondic1 = "";
      private decimal _decNuValor1 = 0;
      private string _strStCondic2 = "";
      private string _strDsCondic2 = "";
      private decimal _decNuValor2 = 0;
      private string _strStRegSis = "";
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
      public string IdVarCalc
      {
         get { return _strIdVarCalc; }
         set { _strIdVarCalc = value; }
      }

      [DataMember()]
      public string DsVarCalc
      {
         get { return _strDsVarCalc; }
         set { _strDsVarCalc = value; }
      }

      [DataMember()]
      public string IdTipo
      {
         get { return _strIdTipo; }
         set { _strIdTipo = value; }
      }

      [DataMember()]
      public string DsCondicion
      {
         get { return _strDsCondicion; }
         set { _strDsCondicion = value; }
      }

      [DataMember()]
      public string IdTabla
      {
         get { return _strIdTabla; }
         set { _strIdTabla = value; }
      }

      [DataMember()]
      public string IdAcumula
      {
         get { return _strIdAcumula; }
         set { _strIdAcumula = value; }
      }

      [DataMember()]
      public string IdColumn
      {
         get { return _strIdColumn; }
         set { _strIdColumn = value; }
      }

      [DataMember()]
      public string StCondic1
      {
         get { return _strStCondic1; }
         set { _strStCondic1 = value; }
      }

      [DataMember()]
      public string DsCondic1
      {
         get { return _strDsCondic1; }
         set { _strDsCondic1 = value; }
      }

      [DataMember()]
      public decimal NuValor1
      {
         get { return _decNuValor1; }
         set { _decNuValor1 = value; }
      }

      [DataMember()]
      public string StCondic2
      {
         get { return _strStCondic2; }
         set { _strStCondic2 = value; }
      }

      [DataMember()]
      public string DsCondic2
      {
         get { return _strDsCondic2; }
         set { _strDsCondic2 = value; }
      }

      [DataMember()]
      public decimal NuValor2
      {
         get { return _decNuValor2; }
         set { _decNuValor2 = value; }
      }

      [DataMember()]
      public string StRegSis
      {
         get { return _strStRegSis; }
         set { _strStRegSis = value; }
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