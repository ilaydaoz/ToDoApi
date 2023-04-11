using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics;
using ToDoDataAccess.Context;
using ToDoDataAccess.Repository.Abstract;
using ToDoDataAccess.Repository.Concrete;

namespace ToDoDataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfContext>(x =>
            {
                x.UseNpgsql(configuration.GetConnectionString("EfContext"))
                  .LogTo(x => Debug.WriteLine(x));
                x.EnableSensitiveDataLogging();
            });
            services.TryAddScoped<DbContext, EfContext>();
            services.AddScoped<IToDoRepository, ToDoRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
