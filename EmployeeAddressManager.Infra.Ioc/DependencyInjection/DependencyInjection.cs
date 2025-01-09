using EmployeeAddressManager.Application.Interfaces;
using EmployeeAddressManager.Application.Mappings;
using EmployeeAddressManager.Application.Services;
using EmployeeAddressManager.Domain.Interfaces;
using EmployeeAddressManager.Infra.Data.Context;
using EmployeeAddressManager.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeAddressManager.Infra.Ioc.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration
            .GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddAutoMapper(typeof(DomainToDtoMappingProfile));
        
        return services;
    }
}