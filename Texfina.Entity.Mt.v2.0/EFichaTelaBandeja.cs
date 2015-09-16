using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Mt
{
   /// <summary>
   /// Entidad para la Tabla: FichaTela (MT_FichaTela)
   /// </summary>
   [DataContract()]
   public class EFichaTelaBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;

      private string _strIdEmpresa = "";
      private string _strIdPeriodo = "";
      private Nullable<DateTime> _dtFeFinA = null;
      private Nullable<DateTime> _dtFeFinB = null;
      private string _strIdProducto = "";
      private string _strDsProducto = "";
      private string _strNuTF = "";
      private string _strNuMaquina = "";

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
      /// Fecha Desde
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public Nullable<DateTime> FeFinA
      {
         get { return _dtFeFinA; }
         set { _dtFeFinA = value; }
      }

      /// <summary>
      /// Fecha Hasta
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public Nullable<DateTime> FeFinB
      {
         get { return _dtFeFinB; }
         set { _dtFeFinB = value; }
      }

      /// <summary>
      /// Código personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdProducto
      {
         get { return _strIdProducto; }
         set { _strIdProducto = value; }
      }

      /// <summary>
      /// Descripcion del Producto
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsProducto
      {
         get { return _strDsProducto; }
         set { _strDsProducto = value; }
      }

      /// <summary>
      /// Numero de TF
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuTF
      {
          get { return _strNuTF; }
          set { _strNuTF = value; }
      }

      /// <summary>
      /// Numero de Maquina
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuMaquina
      {
          get { return _strNuMaquina; }
          set { _strNuMaquina = value; }
      }
      #endregion
   }
}

