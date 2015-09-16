using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Afp (RH_Afp)
   /// </summary>
   [DataContract()]
   public class EAfpBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdAfp = "";
      private string _strDsAfp = "";
      private string _strDsAbrev = "";
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
      /// Código de Afp
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdAfp
      {
         get { return _strIdAfp; }
         set { _strIdAfp = value; }
      }

      /// <summary>
      /// Razon Social Afp
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsAfp
      {
         get { return _strDsAfp; }
         set { _strDsAfp = value; }
      }

      /// <summary>
      /// Sigla Afp
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
      /// Estado Anulado
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string StAnualdo
      {
          get { return _strStAnulado; }
          set { _strStAnulado = value; }
      }

      #endregion

   }
}
