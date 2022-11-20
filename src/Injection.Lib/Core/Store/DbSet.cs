using System;
using System.Collections.Generic;
using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Injection.Lib.Core.Store
{
	public class DbSet<T> : IDbSet<T> where T : class, IEntity
	{
		public ILogger Logger { get; set; } = NullLogger.Instance;

		readonly IDictionary<Guid, T> store;

		internal DbSet()
		{
			this.store = new Dictionary<Guid, T>();
		}

		public Guid Add(T entity)
		{
			if (entity.Id == Guid.Empty)
			{
				entity.Id = Guid.NewGuid();
			}

			this.store[entity.Id] = entity;

			return entity.Id;
		}

		public T? Get(Guid id)
		{
			T? entity;
			if (this.store.TryGetValue(id, out entity))
			{
				return entity;
			}

			return null;
		}

		public IEnumerable<T> List()
		{
			return this.store.Values;
		}

		public bool Remove(Guid id)
		{
			if (this.store.ContainsKey(id))
			{
				this.store.Remove(id);
				return true;
			}

			return false;
		}

		public void Update(T entity)
		{
			this.store[entity.Id] = entity;
		}
	}
}