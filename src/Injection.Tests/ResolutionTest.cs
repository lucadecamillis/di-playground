using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Injection.Tests;

public class ResolutionTest
{
    [Fact]
    public void Resolution_CanResolveService()
    {
        IServiceProvider serviceProvider = Injection.Conf.Default.DefaultConfiguration.SetUp();

        IUserService? userService = serviceProvider.GetService<IUserService>();

        Assert.NotNull(userService); 
    }
}