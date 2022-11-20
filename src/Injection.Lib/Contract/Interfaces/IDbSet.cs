using System;
using System.Collections.Generic;

namespace Injection.Lib.Contract.Interfaces
{
    public interface IDbSet<T> where T : class, IEntity
    {
		Guid Add(T entity);

		IEnumerable<T> List();

		T? Get(Guid id);

		void Update(T entity);

		bool Remove(Guid id);
    }
}