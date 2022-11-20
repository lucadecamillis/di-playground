using Injection.Lib.Contract.Interfaces;

namespace Injection.Lib.Core.Services
{
	public class TemplateProvider : ITemplate
	{
		public string GetProvider()
		{
			return "injection";
		}
	}
}