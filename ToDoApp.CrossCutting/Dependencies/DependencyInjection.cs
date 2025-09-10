using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Reflection;
using ToDoApp.Application.Interfaces;
using ToDoApp.Application.Mappings;
using ToDoApp.Application.Services;
using ToDoApp.Domain.Abstraction;
using ToDoApp.Infrastructure.Context;
using ToDoApp.Infrastructure.Repositories;

namespace ToDoApp.CrossCutting.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<DomainToDTOMappingProfile>();
            });

            services.AddScoped<ITarefaService, TarefaService>();

            services.AddScoped<ITarefaRepository, TarefaRepository>();

            return services;
        }
    }
}
