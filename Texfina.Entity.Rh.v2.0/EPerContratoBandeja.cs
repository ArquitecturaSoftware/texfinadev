using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Personal (RH_Personal)
   /// </summary>
   [DataContract()]
   public class EPerContratoBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;

      private string _strIdEmpresa = "";
      private Nullable<DateTime> _dtFeInicioA = null;
      private Nullable<DateTime> _dtFeInicioB = null;
      private string _strIdPersonal = "";
      private string _strIdEstable = "";
      private string _strIdUNegocio = "";
      private string _strIdCCosto = "";

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
      /// Fecha Desde
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public Nullable<DateTime> FeInicioA
      {
         get { return _dtFeInicioA; }
         set { _dtFeInicioA = value; }
      }

      /// <summary>
      /// Fecha Hasta
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public Nullable<DateTime> FeInicioB
      {
         get { return _dtFeInicioB; }
         set { _dtFeInicioB = value; }
      }

      /// <summary>
      /// Código personal
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPersonal
      {
         get { return _strIdPersonal; }
         set { _strIdPersonal = value; }
      }

      /// <summary>
      /// Código de Establecimiento
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
      /// Código de UNegocio
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
      /// Código de UCCosto
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdCCosto
      {
         get { return _strIdCCosto; }
         set { _strIdCCosto = value; }
      }
      #endregion
   }
}

