using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBusiness
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            var assembly = Assembly.GetExecutingAssembly()
                          .ExportedTypes
                          .Where(consumer => consumer.FullName != null && consumer.FullName.Contains("Handler") && consumer.IsClass)
                          .ToArray();
            services.AddMediatR(assembly);

            return services;

        }
    }
}
