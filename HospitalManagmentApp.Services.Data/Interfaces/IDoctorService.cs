using HospitalManagment.ViewModels.Doctor;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IDoctorService
    {

        Task<IEnumerable<DoctorIndexViewModel>> IndexGetAllDoctorsAsync();
        Task AddDoctorAsync(AddDoctorViewModel model);
        Task <MenageDoctorViewModel?> MenageDoctor(Guid id);
        Task <EditDoctorViewModel?> GetEditDoctorViewModel(Guid id);
        Task <bool> EditDoctorAsync(EditDoctorViewModel model);
      
        Task<AddDoctorToDepartmentViewModel> GetAddDoctorToDepartmentViewModel(Guid id);
        Task<bool> GetAddDoctorToDepartmentAsync(AddDoctorToDepartmentViewModel model,Guid depId);
        Task<bool> AddDoctorToDepartmentAsync(AddDoctorViewModel model,Guid id);

        Task<DeleteDoctorViewModel> GetDeleteDoctorViewModel(Guid id);
        Task<bool> DeleteDoctorAsync(DeleteDoctorViewModel model);
       // Task<IEnumerable<Department>> GetDepartments();
    }
}
