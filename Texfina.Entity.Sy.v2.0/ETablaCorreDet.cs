using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Entidad para la Tabla: Tabla Correlativo Detalle (SY_TablaCorreDet)
   /// </summary>
   [DataContract()]
   public class ETablaCorreDet : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPeriodo = "";
      private string _strIdEmpresa = "";
      private string _strIdTabla = "";
      private string _strIdItem = "";
      private int _intNuIni = 0;
      private int _intNuFin = 0;
      private int _intNuIntervalo = 0;
      private int _intNuUltGen = 0;
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
      /// Código de Periodo
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
      /// Código de Tabla
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
      /// Item
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdItem
      {
         get { return _strIdItem; }
         set { _strIdItem = value; }
      }

      /// <summary>
      /// Número Inicial
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
      /// Número Final
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
      /// Número Intervalo
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
      /// Último Número Generado
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