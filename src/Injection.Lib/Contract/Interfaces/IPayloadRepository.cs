using System;

namespace Injection.Lib.Contract.Interfaces
{
    public interface IPayloadRepository<T> where T : class, IEntity
    {
         Guid AddOrUpdate(T payload);

		 T? GetPayload(Guid id);
    }
}