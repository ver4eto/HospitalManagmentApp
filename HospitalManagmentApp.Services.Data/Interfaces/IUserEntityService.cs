namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IUserEntityService
    {
        Task<string> CreateApplicationUserAsync(string email, string password, string role);
        //Task<bool> IsUserDoctorAsync(string userId);
        //Task<bool> IsUserNurseAsync(string userId);
       
    }
}
