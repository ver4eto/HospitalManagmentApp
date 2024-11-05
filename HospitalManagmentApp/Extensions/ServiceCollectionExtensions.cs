using HospitalManagmentApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configue)
        {

            var connectionString = configue.GetConnectionString("DefaultConnection");

            services.AddDbContext<HMDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configue)
        {
            services
                    .AddDefaultIdentity<IdentityUser>(options =>
                    { 
                        options.SignIn.RequireConfirmedAccount = false; 
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequireDigit = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequiredLength = 6;
                    })
                    .AddEntityFrameworkStores<HMDbContext>();

            return services;
        }
    }
}
