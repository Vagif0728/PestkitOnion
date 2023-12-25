using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories;
using PestKitOnion.Persistence.Implementations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Persistence.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("default")));

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<ITagRepository, TagRepository>();

            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<ITagService, TagService>();

            return services;
        }
    }
}
