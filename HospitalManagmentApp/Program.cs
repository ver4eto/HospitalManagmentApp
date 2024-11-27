using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Models;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//TODO extension method
builder.Services.AddRepositories();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<INurseService, NurseService>();
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

await app.RunAsync();
