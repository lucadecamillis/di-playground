using Injection.Lib.Contract.DataContract;
using Injection.Lib.Contract.Enums;

namespace Injection.Lib.Contract.Interfaces
{
    public interface ILoginService
    {
        LoginLevel GetLoginLevel();

        Task<LoginResponse> Login(LoginRequest request);

        Task Logout();
    }
}