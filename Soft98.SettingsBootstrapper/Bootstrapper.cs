using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Soft98.Data;

namespace Soft98.SettingsBootstrapper;

public class Bootstrapper
{
    public static void AddService(IServiceCollection service, string connection)
    {
        service.AddDbContext<Soft98Context>
            (op => op.UseSqlServer(connection, x => x.MigrationsAssembly("Soft98.Data")));
    }
}