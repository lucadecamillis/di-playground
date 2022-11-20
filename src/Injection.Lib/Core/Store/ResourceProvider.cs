using System;
using Injection.Lib.Contract.Interfaces;

namespace Injection.Lib.Core.Store
{
	public class ResourceProvider : IResourceProvider, IDisposable
	{
		public bool Disposed { get; set; }

		public string GetResource()
		{
			return "resource";
		}

		public void Dispose()
		{
			Disposed = true;
		}
	}
}