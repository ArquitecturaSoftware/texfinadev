using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: Tabla General Detalle (MG_TablaGenDet)
   /// </summary>
   [DataContract()]
   public class ETablaGenDet : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdTabla = "";
      private string _strIdCodigo = "";
      private string _strDsDescrip = "";
      private string _strDsAbrev = "";
      private string _strIdVar = "";
      private string _strIdCodAlter = "";
      private decimal _decMtValor = 0;
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
      /// Código de la Tabla
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
      /// Código
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCodigo
      {
         get { return _strIdCodigo; }
         set { _strIdCodigo = value; }
      }

      /// <summary>
      /// Descripción Larga
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
      /// Descripción Corta
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAbrev
      {
         get { return _strDsAbrev; }
         set { _strDsAbrev = value; }
      }

      /// <summary>
      /// Nombre de Variable, para PIVOT
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdVar
      {
         get { return _strIdVar; }
         set { _strIdVar = value; }
      }

      /// <summary>
      /// Código Alterno, usado para interfaces con otros aplicativos
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCodAlter
      {
         get { return _strIdCodAlter; }
         set { _strIdCodAlter = value; }
      }

      [DataMember()]
      public decimal MtValor
      {
         get { return _decMtValor; }
         set { _decMtValor = value; }
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
