using System;
using System.Threading.Tasks;
using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Injection.Lib.Core.Repositories
{
	public class PayloadRepositoryFactory : IPayloadRepositoryFactory
	{
		public ILogger Logger { get; set; } = NullLogger.Instance;
		
		Task<IPayloadRepository<T>> IPayloadRepositoryFactory.ResolveById<T>(Guid id)
		{
			IPayloadRepository<T> repository = new PayloadRepository<T>(id.ToString());

			return Task.FromResult(repository);
		}
	}
}