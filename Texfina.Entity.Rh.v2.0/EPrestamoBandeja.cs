using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Rh
{
   /// <summary>
   /// Entidad para la Tabla: Prestamo (RH_Prestamo)
   /// </summary>
   [DataContract()]
   public class EPrestamoBandeja : IEntityBase
   {

      #region Campos

      private EntityState _intState = EntityState.Unchanged;
      private string _strIdEmpresa = "";
      private string _strIdPrestamo = "";
      private string _strDsApellNom = "";
      private string _strNuDocIden = "";
      private string _strIdPersonal = "";
      private Nullable<DateTime> _datFeInicio = null;
      private Nullable<DateTime> _datFeFin = null;

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
      /// Código de Prestamo
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string IdPrestamo
      {
         get { return _strIdPrestamo; }
         set { _strIdPrestamo = value; }
      }

      /// <summary>
      /// Nombres
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string DsApellNom
      {
         get { return _strDsApellNom; }
         set { _strDsApellNom = value; }
      }
      
      /// <summary>
      /// Número Documento de Identidad
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public string NuDocIden
      {
         get { return _strNuDocIden; }
         set { _strNuDocIden = value; }
      }

      /// <summary>
      /// Codigo de Personal
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
      /// Rango de fechas Inicio
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeInicio
      {
         get { return _datFeInicio; }
         set { _datFeInicio = value; }
      }

      /// <summary>
      /// Rango de fechas Fin
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      [DataMember()]
      public Nullable<DateTime> FeFin
      {
         get { return _datFeFin; }
         set { _datFeFin = value; }
      }
      
      #endregion

   }
}
