using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Injection.Lib.Core.Store
{
    public class MemoryContext : IContext
	{
		readonly IDictionary<Type, object> setsCache;

		public ILogger Logger { get; set; } = NullLogger.Instance;

		public MemoryContext()
		{
			this.setsCache = new Dictionary<Type, object>();
		}

		IDbSet<T>? IContext.GetSet<T>()
		{
			Type entityType = typeof(T);
			if(!this.setsCache.ContainsKey(entityType))
			{
				// Create a new instance
				IDbSet<T> set = new DbSet<T>();

				this.setsCache.Add(entityType, set);
			}

			return this.setsCache[entityType] as IDbSet<T>;
		}
	}
}