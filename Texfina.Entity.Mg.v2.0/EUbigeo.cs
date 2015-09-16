using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mg
{
   /// <summary>
   /// Entidad para la Tabla: Ubigeo (MG_Ubigeo)
   /// </summary>
   [DataContract()]
   public class EUbigeo : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdPais = "";
      private string _strIdDepa = "";
      private string _strIdProv = "";
      private string _strIdDist = "";
      private string _strDsNombre = "";
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
      /// Código de País
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPais
      {
         get { return _strIdPais; }
         set { _strIdPais = value; }
      }

      /// <summary>
      /// Código de Departamento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdDepa
      {
         get { return _strIdDepa; }
         set { _strIdDepa = value; }
      }

      /// <summary>
      /// Código de Provincia
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdProv
      {
         get { return _strIdProv; }
         set { _strIdProv = value; }
      }

      /// <summary>
      /// Código de Distrito
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdDist
      {
         get { return _strIdDist; }
         set { _strIdDist = value; }
      }

      /// <summary>
      /// Descripción de Nombre
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsNombre
      {
         get { return _strDsNombre; }
         set { _strDsNombre = value; }
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
