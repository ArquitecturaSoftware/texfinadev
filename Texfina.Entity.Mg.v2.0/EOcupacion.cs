using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: MG_Ocupacion (MG_Ocupacion)
   /// </summary>
   [DataContract()]
   public class EOcupacion : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdOcupa = "";
      private string _strDsOcupa = "";
      private string _strStEjecutivo = "";
      private string _strStEmpleado = "";
      private string _strStObrero = "";
      private string _strStSecPrivado = "";
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
      public string IdOcupa
      {
         get { return _strIdOcupa; }
         set { _strIdOcupa = value; }
      }

      [DataMember()]
      public string DsOcupa
      {
         get { return _strDsOcupa; }
         set { _strDsOcupa = value; }
      }

      [DataMember()]
      public string StEjecutivo
      {
         get { return _strStEjecutivo; }
         set { _strStEjecutivo = value; }
      }

      [DataMember()]
      public string StEmpleado
      {
         get { return _strStEmpleado; }
         set { _strStEmpleado = value; }
      }

      [DataMember()]
      public string StObrero
      {
         get { return _strStObrero; }
         set { _strStObrero = value; }
      }

      [DataMember()]
      public string StSecPrivado
      {
         get { return _strStSecPrivado; }
         set { _strStSecPrivado = value; }
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
