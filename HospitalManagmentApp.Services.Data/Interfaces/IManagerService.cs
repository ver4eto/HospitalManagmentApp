using HospitalManagment.ViewModels.Manager;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Views.Manager;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IManagerService 
    {
        Task<ManagerIndexViewModel> GetIndexManagerViewModel();
        Task<ManagerDepartmentReportsViewModel> GetDepartmentReportsViewModel();
        Task<ManagerDoctorsReportsViewModel> GetDoctorsReportViewModel();
        Task<ManagerPatientsReportViewModel> GetPatientsReportViewModel();
        Task<ManagerGeneralReportViewModel> GetGeneralReportViewModel();
        Task<IEnumerable<Manager>> GetAllManagersASync();
    }
}
