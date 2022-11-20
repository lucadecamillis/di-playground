using System;
using Injection.Lib.Contract.Interfaces;

namespace Injection.Lib.Contract.Model
{
    public class UserPayload : IEntity
    {
        public Guid Id { get; set; }

		public byte[] Avatar { get; set; }

		public string? Bio { get; set; }

        public UserPayload()
        {
            this.Avatar = Array.Empty<byte>();
        }
    }
}