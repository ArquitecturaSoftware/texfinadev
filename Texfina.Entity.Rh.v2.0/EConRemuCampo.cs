using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Campos Usados en el Concepto Remunerativo (RH_ConRemuCampo)
   /// </summary>
   [DataContract()]
   public class EConRemuCampo : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdConremu = "";
      private string _strIdCampo = "";
      private int _intNuNivel = 0;
      private string _strIdTipo = "";
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
      /// Código Concepto de Remuneración
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdConremu
      {
         get { return _strIdConremu; }
         set { _strIdConremu = value; }
      }

      /// <summary>
      /// Campo o Variable
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCampo
      {
         get { return _strIdCampo; }
         set { _strIdCampo = value; }
      }

      /// <summary>
      /// Nivel
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public int NuNivel
      {
         get { return _intNuNivel; }
         set { _intNuNivel = value; }
      }

      /// <summary>
      /// Tipo de Campo (Variable o Acumulador)
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipo
      {
         get { return _strIdTipo; }
         set { _strIdTipo = value; }
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