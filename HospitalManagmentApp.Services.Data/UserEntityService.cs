using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Services.Data
{
    public class UserEntityService : IUserEntityService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly HMDbContext context;

        public UserEntityService(UserManager<ApplicationUser> userManager, HMDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public async Task<string> CreateApplicationUserAsync(string email, string password, string role)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true,
                UserType=role
            };

            var result = await userManager.CreateAsync(user, password);

            if (!result.Succeeded)
            {
                throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
            }

            if (!string.IsNullOrEmpty(role))
            {
                await userManager.AddToRoleAsync(user, role);
            }
            user.UserType=role;
            return user.Id; // Return the created user's ID
        }

        //public async Task<bool> IsUserDoctorAsync(string userId)
        //{
        //    string? user =  this.user
        //    bool IsUserDoctor =await this.userManager.GetUserIdAsync(user);
        //    return IsUserDoctor;
        //}

    }
}
