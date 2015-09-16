using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Hora (RH_Hora)
   /// </summary>
   [DataContract()]
   public class EHora : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdHora = "";
      private string _strDsHora = "";
      private string _strDsAbrev = "";
      private string _strIdVar = "";
      private decimal _decNuValHora = 0;
      private string _strStEventual = "";
      private int _intNuOrden = 0;
      private string _strStImportar = "";
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
      /// Código de Hora
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdHora
      {
         get { return _strIdHora; }
         set { _strIdHora = value; }
      }

      /// <summary>
      /// Descripción de Hora Larga
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsHora
      {
         get { return _strDsHora; }
         set { _strDsHora = value; }
      }

      /// <summary>
      /// Descripción de Hora Corta
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
      /// Código Variable
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
      /// Valor de Hora
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public decimal NuValHora
      {
         get { return _decNuValHora; }
         set { _decNuValHora = value; }
      }

      /// <summary>
      /// Estado Eventual
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StEventual
      {
         get { return _strStEventual; }
         set { _strStEventual = value; }
      }

      /// <summary>
      /// Numero de Orden de importacion
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuOrden
      {
         get { return _intNuOrden; }
         set { _intNuOrden = value; }
      }

      [DataMember()]
      public string StImportar
      {
         get { return _strStImportar; }
         set { _strStImportar = value; }
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
