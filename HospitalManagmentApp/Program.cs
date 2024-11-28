using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Models;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//TODO extension method
builder.Services.AddRepositories();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<INurseService, NurseService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<ITreatmentService, TreatmentService>();
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<UserEntityService>();
builder.Services.AddApplicationServices();

var app = builder.Build();
AutoMapperConfig.RegisterMappings(typeof(Program).Assembly, typeof(DoctorIndexViewModel).Assembly);
AutoMapperConfig.RegisterMappings(typeof(Program).Assembly, typeof(AddDoctorViewModel).Assembly);
AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).Assembly);

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using(var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "Admin", "Manager", "Doctor", "Nurse", "Patient" };

    foreach (var role in roles)
    {
        if(!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

//using (var scope = app.Services.CreateScope())
//{
//    var userManager=scope.ServiceProvider.GetService<UserManager<ApplicationUser>>();

//    string email = "admin@abv.bg";
//    string password = "Test123*";

//   if(await userManager.FindByEmailAsync(email) == null)
//    {
//        var user = new ApplicationUser();
//        user.Email = email;
//        user.UserName = email;

//       await userManager.CreateAsync(user, password);

//        await userManager.AddToRoleAsync(user, "Admin");
//    }
//}


await app.RunAsync();
