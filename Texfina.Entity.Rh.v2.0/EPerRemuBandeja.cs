using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: PersonalRemuneración (RH_PerRemu)
   /// </summary>
   [DataContract()]
    public class EPerRemuBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;

      private string _strIdEmpresa = "";
      private string _strIdEstable = "";
      private string _strIdUNegocio = "";
      private string _strIdCCosto = "";
      private string _strIdTipoTrab = "";
      private Nullable<DateTime> _dtfeIngplaA = null;
      private Nullable<DateTime> _dtfeIngplaB = null;
      private string _strStContrato = "";



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
      /// Código Establecimiento
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdEstable
      {
          get { return _strIdEstable; }
          set { _strIdEstable = value; }
      }

      /// <summary>
      /// Código Unidad de Negocio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdUNegocio
      {
          get { return _strIdUNegocio; }
          set { _strIdUNegocio = value; }
      }

      /// <summary>
      /// Código centro de costo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCCosto
      {
          get { return _strIdCCosto; }
          set { _strIdCCosto = value; }
      }

      /// <summary>
      /// Código Tipo Trabajador
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdTipoTrab
      {
          get { return _strIdTipoTrab; }
          set { _strIdTipoTrab = value; }
      }

      /// <summary>
      ///Fecha Desde
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> feIngplaA
      {
          get { return _dtfeIngplaA; }
          set { _dtfeIngplaA = value; }
      }

      /// <summary>
      /// Fecha Hasta
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]

      public Nullable<DateTime> feIngplaB
      {
          get { return _dtfeIngplaB; }
          set { _dtfeIngplaB = value; }
      }

      /// <summary>
      /// Estado de Contrato
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]

      public string StContrato
      {
         get { return _strStContrato; }
         set { _strStContrato = value; }
      }
      #endregion
   }
}
