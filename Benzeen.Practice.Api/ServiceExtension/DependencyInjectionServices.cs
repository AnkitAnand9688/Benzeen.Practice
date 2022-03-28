using Benzeen.Practice.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Benzeen.Practice.Api.ServiceExtension
{
    public static class DependencyInjectionServices
    {
    public static IServiceCollection AddDependencyInjectionServices (this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeDataAccess, EmployeeDataAccess>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentDataAccess, DepartmentDataAccess>();
            return services;

        }
        
           
        

    }
}
