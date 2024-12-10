using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Models;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});

builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login"; 
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.LogoutPath = "/Account/Logout"; 
});

//TODO extension method
builder.Services.AddRepositories();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<INurseService, NurseService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<ITreatmentService, TreatmentService>();
builder.Services.AddScoped<IManagerService, ManagerService>();
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IUserEntityService, UserEntityService>();
builder.Services.AddApplicationServices();

var app = builder.Build();
AutoMapperConfig.RegisterMappings(typeof(Program).Assembly, typeof(DoctorIndexViewModel).Assembly);
AutoMapperConfig.RegisterMappings(typeof(Program).Assembly, typeof(AddDoctorViewModel).Assembly);
AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).Assembly);

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/500"); // Handles unhandled exceptions
    app.UseStatusCodePagesWithReExecute("/Error/{0}"); // Handles 404 and other status codes
    app.UseHsts();
    //app.UseMigrationsEndPoint();
}
else
{
    //app.UseExceptionHandler("/Error/500");
    //app.UseStatusCodePagesWithReExecute("/Error/{0}");
   app.UseExceptionHandler("/Home/Error");    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.Use((context, next) =>
{
    if (context.User.Identity?.IsAuthenticated == true && context.Request.Path == "/")
    {
        if (context.User.IsInRole("Admin"))
        {
            context.Response.Redirect("Admin/Home/Index");
            return Task.CompletedTask;
        }
    }
    return next();
});
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using(var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "Admin", "Manager", "Doctor", "Nurse", "Patient","User" };

    foreach (var role in roles)
    {
        if(!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    string email = "admin@abv.bg";
    string password = "Test123*";
    string roleName = "Admin";

    try
    {
        // Ensure the role exists
        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }

        // Ensure the admin user exists
        if (await userManager.FindByEmailAsync(email) == null)
        {
            var user = new ApplicationUser
            {
                Email = email,
                UserName = email,
                UserType=roleName,
               
            };

            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, roleName);
            }
            else
            {
                throw new Exception($"Failed to create admin user: {string.Join(", ", result.Errors.Select(e => e.Description))}");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error seeding admin user: {ex.Message}");
    }
}

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

   
    var usersToAssign = new List<(string Email, string Role)>
    {
        ("smith@abv.bg", "Doctor"),
        ("ivanovst@abv.bg", "Manager"),
        ("petrovlazar@abv.bg", "Patient"),        
        ("jhonson@abv.bg", "Doctor"),
        ("jhondoe@abv.bg","Doctor"),
        ("petrovp@abv.bg","Doctor"),
        ("petrovai@abv.bg","Doctor"),
        ("miller@abv.bg","Nurse"),
        ("davissophia@abv.bg","Nurse"),
        ("brown@abv.bg","Nurse"),
        ("williams@abv.bg","Nurse"),
        ("taylor@abv.bg","Nurse"),
        ("petrovskaem@abv.bg","Nurse"),
        ("petrovlazar@abv.bg","Patient"),
        ("ivanovivan@abv.bg","Patient"),
        ("petrovavanya@abv.bg","Patient"),
        ("stefanovp@abv.bg","Patient"),
        ("sokolovs@abv.bg","Patient")
    };

    foreach (var (email, role) in usersToAssign)
    {
        var user = await userManager.FindByEmailAsync(email);
        if (user != null && !await userManager.IsInRoleAsync(user, role))
        {
            await userManager.AddToRoleAsync(user, role);
        }
    }
}

await app.RunAsync();
