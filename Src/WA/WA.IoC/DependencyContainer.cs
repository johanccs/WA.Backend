using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WA.Contracts;
using WA.Data.DbCtx;
using WA.Data.Entities;
using WA.Data.Helpers;
using WA.Services;
using WA.Services.Helpers;

namespace WA.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IRecalcProjectCost<EmployeeEntity>, RecalculateProjectCost>();
            services.AddScoped<IProjectEmployeeMapping, ProjectEmployeeMapping>();
        }

        public static void RegisterDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(
                opt=> opt.UseSqlServer(config.GetConnectionString("sqlConnection")));
        }
    }
}

