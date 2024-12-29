using FashionClub.Core.Application.Abstractions.Repositories;
using FashionClub.Infrastructure.Data.Persistence;
using FashionClub.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureData(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FashionClubDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions
                    .MigrationsAssembly(typeof(FashionClubDbContext).Assembly.FullName)
                    .UseNetTopologySuite()));

        services.AddScoped<IFCRepository, FCRepository>();

        return services;
    }

    public static void ApplyMigrations(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<FashionClubDbContext>();
        dbContext.Database.Migrate(); 
    }

}
