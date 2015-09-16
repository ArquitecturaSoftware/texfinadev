using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Sy
{
   /// <summary>
   /// Entidad para la Tabla: SY_ConfigHora (SY_ConfigHora)
   /// </summary>
   [DataContract()]
   public class EConfigHora : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private int _intIdHoraExcel = 0;
      private string _strDsHoraExcel = "";
      private string _strIdHora = "";
      private string _strStIdPersonal = "";
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

      [DataMember()]
      public int IdHoraExcel
      {
         get { return _intIdHoraExcel; }
         set { _intIdHoraExcel = value; }
      }

      [DataMember()]
      public string DsHoraExcel
      {
         get { return _strDsHoraExcel; }
         set { _strDsHoraExcel = value; }
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

      [DataMember()]
      public string StIdPersonal
      {
         get { return _strStIdPersonal; }
         set { _strStIdPersonal = value; }
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
