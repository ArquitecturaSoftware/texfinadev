using System;
using System.Data;

namespace Texfina.Core.Data
{
   /// <summary>
   /// Interface general para los Data Object que realizan consultas a Tablas
   /// </summary>
   public interface IDOQuery
   {
      /// <summary>
      /// Metodo general para consultar datos por un criterio, es usado en las bandejas de busqueda para llenar un GridView
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      DataTable GetByCriteria(IEntityBase value);

      /// <summary>
      /// Metodo general para consultar datos por la llave primaria
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna una Entidad Base que representa el registro requerido</returns>
      IEntityBase GetByKey(IEntityBase value);

      /// <summary>
      /// Metodo general para consultar datos por la llave de la tabla padre, es usado en para llenar un GridView en un escenario Master/Detail
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      DataTable GetByParentKey(IEntityBase value);

      /// <summary>
      /// Metodo general para consultar datos por la llave de la tabla padre, es usado en para llenar un control Lista
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna un DataTable</returns>
      DataTable GetList(IEntityBase value);

      /// <summary>
      /// Metodo general para consultar si existen datos por la llave primaria
      /// </summary>
      /// <param name="value">Entidad base</param>
      /// <returns>Retorna Verdadero o Falso</returns>
      bool Exists(IEntityBase value);
   }
}
