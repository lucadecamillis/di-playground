using System;
using System.Threading.Tasks;

namespace Injection.Lib.Contract.Interfaces
{
    public interface IPayloadRepositoryFactory
    {
         Task<IPayloadRepository<T>> ResolveById<T>(Guid id) where T : class, IEntity;
    }
}