using HospitalManagment.Infrastructure.Repositories;
using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Models;
using HospitalManagmentApp.Services.Mapping;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews();

//TODO extension method
builder.Services.AddRepositories();
builder.Services.AddApplicationServices();

var app = builder.Build();

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
