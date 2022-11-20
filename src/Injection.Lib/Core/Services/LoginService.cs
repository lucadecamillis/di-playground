using System.Threading.Tasks;
using Injection.Lib.Contract.DataContract;
using Injection.Lib.Contract.Enums;
using Injection.Lib.Contract.Interfaces;

namespace Injection.Lib.Core.Services
{
	public class LoginService : ILoginService
	{
		public LoginLevel GetLoginLevel()
		{
            return LoginLevel.SecondFactor;
		}

		public async Task<LoginResponse> Login(LoginRequest request)
		{
            await Task.Delay(500).ConfigureAwait(false);

            return new LoginResponse { Success = true };
		}

		public async Task Logout()
		{
			await Task.Delay(500).ConfigureAwait(false);
		}
	}
}