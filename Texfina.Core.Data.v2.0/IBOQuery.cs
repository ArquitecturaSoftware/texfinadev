using System;
using System.ServiceModel;
using System.Data;

namespace Texfina.Core.Data
{
   /// <summary>
   /// Interface general para los Business Objects que realizan consultas a Tablas
   /// </summary>
   [ServiceContract()]
   public interface IBOQuery
   {
      [OperationContract()]
      [NetDataContract()]
      DataTable GetByCriteria(IEntityBase value);

      [OperationContract()]
      [NetDataContract()]
      IEntityBase GetByKey(IEntityBase value);

      [OperationContract()]
      [NetDataContract()]
      DataTable GetByParentKey(IEntityBase value);

      [OperationContract()]
      [NetDataContract()]
      DataTable GetList(IEntityBase value);

      [OperationContract()]
      [NetDataContract()]
      bool Exists(IEntityBase value);

   }
}
