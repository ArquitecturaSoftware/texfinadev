/// <summary>
/// Representa los estados en que se encuentra una entidad, es usado para determinar la actualizacion a realizar.
/// </summary>
public enum EntityState
{
   /// <summary>
   /// Nuevo
   /// </summary>
   /// <remarks></remarks>
   Added = 0,

   /// <summary>
   /// Modificado
   /// </summary>
   /// <remarks></remarks>
   Modified = 1,

   /// <summary>
   /// Eliminado
   /// </summary>
   /// <remarks></remarks>
   Deleted = 2,

   /// <summary>
   /// Sin cambios
   /// </summary>
   /// <remarks></remarks>
   Unchanged = 3
}
