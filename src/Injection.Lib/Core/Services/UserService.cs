using Injection.Lib.Contract.Interfaces;
using Injection.Lib.Contract.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Injection.Lib.Core.Services
{
    public class UserService : IUserService
	{
		readonly IRepository<User> repository;

		private string? template;

		public ILogger Logger { get; set; } = NullLogger.Instance;

		public string? Template
		{
			get { return template; }
			set
			{
				this.template = value;
			}
		}

		public UserService(IRepository<User> repository)
		{
			this.repository = repository;
		}

		public void AddUser(User user)
		{
			Logger.LogInformation("Adding user {user}", user.Name);

			this.repository.Add(user);
		}

		public User? GetUser(Guid id)
		{
			Logger.LogInformation("Get user with id {id}", id);

			return this.repository.Get(id);
		}

		public IEnumerable<User> GetUsers()
		{
			return this.repository.List();
		}
	}
}