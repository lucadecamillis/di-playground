using System;
using System.Collections.Generic;
using Injection.Lib.Contract.Model;

namespace Injection.Lib.Contract.Interfaces
{
	public interface IUserService
    {
		User? GetUser(Guid id);

		IEnumerable<User> GetUsers();

		void AddUser(User user);
    }
}