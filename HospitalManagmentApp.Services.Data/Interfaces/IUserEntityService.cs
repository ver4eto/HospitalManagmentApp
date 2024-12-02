using HospitalManagmentApp.DataModels;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IUserEntityService
    {
        Task<string> CreateApplicationUserAsync(string email, string password, string role);

    }
}
