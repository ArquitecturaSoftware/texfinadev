using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Tabla Origen para la Variable de Calculo (RH_TablaVC)
   /// </summary>
   [DataContract()]
   public class ETablaVC : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdTablaVC = "";
      private string _strDsTabla = "";
      private string _strDsDescrip = "";
      private string _strDsCondicion = "";
      private string _strStEnlazado = "";
      private string _strDsColAgrupa = "";
      private string _strDsEnlace = "";
      private string _strDsVisibleEn = "";
      private string _strStPerSubCond = "";
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
      /// Nombre de la Tabla Origen
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsTabla
      {
         get { return _strDsTabla; }
         set { _strDsTabla = value; }
      }

      /// <summary>
      /// Descripcion de la Tabla
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
      /// Codigo SQL para el WHERE
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsCondicion
      {
         get { return _strDsCondicion; }
         set { _strDsCondicion = value; }
      }

      /// <summary>
      /// Estado que indica si esta en un JOIN
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StEnlazado
      {
         get { return _strStEnlazado; }
         set { _strStEnlazado = value; }
      }

      /// <summary>
      /// Columna(s) para agrupar
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsColAgrupa
      {
         get { return _strDsColAgrupa; }
         set { _strDsColAgrupa = value; }
      }

      /// <summary>
      /// Codigo SQL para el JOIN
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsEnlace
      {
         get { return _strDsEnlace; }
         set { _strDsEnlace = value; }
      }

      /// <summary>
      /// Visible en Variable o Acumulador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsVisibleEn
      {
         get { return _strDsVisibleEn; }
         set { _strDsVisibleEn = value; }
      }

      [DataMember()]
      public string StPerSubCond
      {
         get { return _strStPerSubCond; }
         set { _strStPerSubCond = value; }
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