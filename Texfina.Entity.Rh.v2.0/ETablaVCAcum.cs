using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Acumuladores de la Tabla Origen para la Variable de Calculo (RH_TablaVCAcum)
   /// </summary>
   [DataContract()]
   public class ETablaVCAcum : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdTablaVC = "";
      private string _strIdAcumula = "";
      private string _strDsAcumula = "";
      private string _strDsDescrip = "";
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
      /// Codigo de la Tabla Origen
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTablaVC
      {
         get { return _strIdTablaVC; }
         set { _strIdTablaVC = value; }
      }

      /// <summary>
      /// Codigo del Acumulador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdAcumula
      {
         get { return _strIdAcumula; }
         set { _strIdAcumula = value; }
      }

      /// <summary>
      /// Nombre del Acumulador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAcumula
      {
         get { return _strDsAcumula; }
         set { _strDsAcumula = value; }
      }

      /// <summary>
      /// Descripcion del Acumulador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsDescrip
      {
         get { return _strDsDescrip; }
         set { _strDsDescrip = value; }
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