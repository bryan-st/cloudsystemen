using FashionClub.Core.Application.Abstractions.Services;
using FashionClub.Core.Application.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddCoreApplication(this IServiceCollection services)
    {
        services.AddScoped<IKlantenService, KlantenService>();
        services.AddScoped<IReportService, ReportService>();
        services.AddScoped<IBrandsService, BrandsService>();
        
        return services;
    }
}