using HospitalManagment.ViewModels.Manager;
using HospitalManagmentApp.Views.Manager;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IManagerService 
    {
        Task<ManagerIndexViewModel> GetIndexManagerViewModel();
        Task<ManagerDepartmentReportsViewModel> GetDepartmentReportsViewModel();
    }
}
