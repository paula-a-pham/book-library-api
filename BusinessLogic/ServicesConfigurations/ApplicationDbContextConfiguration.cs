using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.ServicesConfigurations;

public static class ApplicationDbContextConfiguration
{
    public static void ApplicationDbContextConfigurator(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
    }
}
