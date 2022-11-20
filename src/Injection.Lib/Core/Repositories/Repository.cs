using System;
using System.Collections.Generic;
using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Injection.Lib.Core.Repositories
{
	public class Repository<T> : IRepository<T> where T : class, IEntity
	{
		readonly IContext context;

		public ILogger Logger { get; set; } = NullLogger.Instance;

		public Repository(IContext context)
		{
			this.context = context;
		}

		public Guid Add(T entity)
		{
			Logger.LogInformation("Add entity");

            IDbSet<T>? dbSet = this.context.GetSet<T>();
            if (dbSet != null)
            {
                return dbSet.Add(entity);
            }

            return Guid.Empty;
        }

		public T? Get(Guid id)
		{
			Logger.LogInformation("Get entity");

			IDbSet<T>? dbSet = this.context.GetSet<T>();
            if (dbSet != null)
            {
                return dbSet.Get(id);
            }

            return null;
        }

		public IEnumerable<T> List()
		{
			IDbSet<T>? dbSet = this.context.GetSet<T>();
            if (dbSet != null)
            {
                return dbSet.List();
            }

            return Enumerable.Empty<T>();
        }

		public bool Remove(Guid id)
		{
			IDbSet<T>? dbSet = this.context.GetSet<T>();
            if (dbSet != null)
            {
                return dbSet.Remove(id);
            }

            return false;
        }

		public void Update(T entity)
		{
			IDbSet<T>? dbSet = this.context.GetSet<T>();
            if (dbSet != null)
            {
                dbSet.Update(entity);
            }
		}
	}
}