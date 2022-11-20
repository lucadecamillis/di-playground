using System;
using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Injection.Lib.Core.Repositories
{
	public class PayloadRepository<T> : IPayloadRepository<T> where T : class, IEntity
	{
		readonly string connectionString;

		public ILogger Logger { get; set; } = NullLogger.Instance;

		public PayloadRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public Guid AddOrUpdate(T payload)
		{
			return Guid.Empty;
		}

		public T? GetPayload(Guid id)
		{
			return null;
		}
	}
}