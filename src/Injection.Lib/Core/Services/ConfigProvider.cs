using Injection.Lib.Contract.Interfaces;

namespace Injection.Lib.Core.Services
{
	public class ConfigProvider : IConfigProvider
	{
		private ITemplate? template;
		private ITemplate? member;
		private ITemplate? attribute;

		public ITemplate? Template
		{
			get { return template; }
			set
			{
				this.template = value;
			}
		}

		public ITemplate? Member
		{
			get { return member; }
			set
			{
				this.member = value;
			}
		}

		public ITemplate? Attribute
		{
			get { return attribute; }
			set
			{
				this.attribute = value;
			}
		}

		public ConfigProvider()
		{

		}

		public string GetUri()
		{
			return "http://localhost";
		}
	}
}