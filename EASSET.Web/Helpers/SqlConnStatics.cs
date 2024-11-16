using Microsoft.Extensions.DependencyInjection;

namespace EASSET.Helpers;

public static class SqlConnStatics
{
    public static ISqlConnections SqlConnections { get; set; }

    public static void InitializeServices(IServiceProvider services)
    {
        SqlConnections = services.GetRequiredService<ISqlConnections>();
    }
}
