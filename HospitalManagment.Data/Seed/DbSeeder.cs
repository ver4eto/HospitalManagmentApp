using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace HospitalManagmentApp.Data.Seed
{
    public static class DbSeeder
    {
        public static async Task SeedDatabaseAsync(IServiceProvider serviceProvider,string jsonPath)
        {

            try
            {
                await using HMDbContext context = serviceProvider.GetRequiredService<HMDbContext>();

                string jsonInput = await File.ReadAllTextAsync(jsonPath, Encoding.Unicode, CancellationToken.None);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }
}
