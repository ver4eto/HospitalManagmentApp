using HospitalManagment.ViewModels.Doctor;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IDoctorService
    {

        Task<IEnumerable<DoctorIndexViewModel>> IndexGetAllDoctorsAsync(string? searcheQuery, string? specialty, string? department );
        Task AddDoctorAsync(AddDoctorViewModel model);
        
        Task <EditDoctorViewModel?> GetEditDoctorViewModel(Guid id);
        Task <bool> EditDoctorAsync(EditDoctorViewModel model);
      
        Task<AddDoctorToDepartmentViewModel> GetAddDoctorToDepartmentViewModel(Guid id);
        Task<bool> GetAddDoctorToDepartmentAsync(AddDoctorToDepartmentViewModel model,Guid depId);

        Task<AddDoctorViewModel> GetAddDoctorViewModel();
        Task<DeleteDoctorViewModel> GetDeleteDoctorViewModel(Guid id);
        Task<bool> DeleteDoctorAsync(DeleteDoctorViewModel model,Guid id);
       
    }
}
