using System;
using Injection.Lib.Contract.Interfaces;

namespace Injection.Lib.Contract.Model
{
	public class User : IEntity
    {
		public Guid Id { get; set; }

        public string? Name { get; set; }
    }
}