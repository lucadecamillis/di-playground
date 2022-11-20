using Injection.Lib.Contract.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Injection.Conf.Default;

public static class DefaultConfiguration
{
    public static IServiceProvider SetUp()
    {
        IServiceCollection services = new ServiceCollection();

        // services.AddSingleton(typeof(IDbSet<>), typeof(Injection.Lib.Core.Store.DbSet<>));
        services.AddSingleton<IContext, Injection.Lib.Core.Store.MemoryContext>();

        services.AddTransient(typeof(IRepository<>), typeof(Injection.Lib.Core.Repositories.Repository<>));
        services.AddTransient<IPayloadRepositoryFactory, Injection.Lib.Core.Repositories.PayloadRepositoryFactory>();

        services.AddTransient<IUserService, Injection.Lib.Core.Services.UserService>();
        services.AddTransient<ILoginService, Injection.Lib.Core.Services.LoginService>();
        services.AddTransient<ITemplate, Injection.Lib.Core.Services.TemplateProvider>();
        services.AddTransient<IConfigProvider, Injection.Lib.Core.Services.ConfigProvider>();

        IServiceProvider provider = services.BuildServiceProvider();

        return provider;
    }
}