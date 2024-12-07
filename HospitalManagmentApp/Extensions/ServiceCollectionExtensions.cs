using HospitalManagment.Infrastructure.Repositories;
using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
           
            services.AddScoped(typeof(IRepository<Doctor, Guid>), typeof(BaseRepository<Doctor, Guid>));
            services.AddScoped(typeof(IRepository<Manager, Guid>), typeof(BaseRepository<Manager, Guid>));
            services.AddScoped(typeof(IRepository<Nurse, Guid>), typeof(BaseRepository<Nurse, Guid>));
            services.AddScoped(typeof(IRepository<Patient, Guid>), typeof(BaseRepository<Patient, Guid>));
            services.AddScoped(typeof(IRepository<Department, Guid>), typeof(BaseRepository<Department, Guid>));
            services.AddScoped(typeof(IRepository<Room, Guid>), typeof(BaseRepository<Room, Guid>));
            services.AddScoped(typeof(IRepository<Treatment, Guid>), typeof(BaseRepository<Treatment, Guid>));
            services.AddScoped(typeof(IRepository<PatientDoctor, object>), typeof(BaseRepository<PatientDoctor, object>));
            services.AddScoped(typeof(IRepository<PatientTreatment, object>), typeof(BaseRepository<PatientTreatment, object>));

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
                    .AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
               
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            })
                    .AddRoles<IdentityRole>()                   
                    .AddEntityFrameworkStores<HMDbContext>()
                    .AddDefaultTokenProviders();

           
            return services;
        }
    }
}
