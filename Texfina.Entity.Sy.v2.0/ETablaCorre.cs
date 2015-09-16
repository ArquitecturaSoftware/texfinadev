using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Entidad para la Tabla: Tabla Correlativo (SY_TablaCorre)
   /// </summary>
   [DataContract()]
   public class ETablaCorre : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdTabla = "";
      private int _intNuIni = 0;
      private int _intNuFin = 0;
      private int _intNuIntervalo = 0;
      private int _intNuUltGen = 0;
      private string _strDsFormato = "";
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
      /// C�digo de Periodo
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
      /// C�digo de Empresa
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
      /// C�digo de Tabla
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTabla
      {
         get { return _strIdTabla; }
         set { _strIdTabla = value; }
      }

      /// <summary>
      /// N�mero Inicial
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuIni
      {
         get { return _intNuIni; }
         set { _intNuIni = value; }
      }

      /// <summary>
      /// N�mero Final
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuFin
      {
         get { return _intNuFin; }
         set { _intNuFin = value; }
      }

      /// <summary>
      /// N�mero Intervalo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuIntervalo
      {
         get { return _intNuIntervalo; }
         set { _intNuIntervalo = value; }
      }

      /// <summary>
      /// �ltimo N�mero Generado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuUltGen
      {
         get { return _intNuUltGen; }
         set { _intNuUltGen = value; }
      }

      /// <summary>
      /// Descripci�n del Formato
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsFormato
      {
         get { return _strDsFormato; }
         set { _strDsFormato = value; }
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