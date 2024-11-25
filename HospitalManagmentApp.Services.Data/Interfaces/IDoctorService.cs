using HospitalManagment.ViewModels.Doctor;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IDoctorService
    {

        Task<IEnumerable<DoctorIndexViewModel>> IndexGetAllDoctorsAsync();
        Task AddDoctorAsync(AddDoctorViewModel model);
        Task <IActionResult> MenageDoctor(Guid id);
        Task <EditDoctorViewModel> GetEditDoctorViewModel(Guid id);
        Task <bool> EditDoctorAsync(EditDoctorViewModel model);
      
        Task<AddDoctorToDepartmentViewModel> GetAddDoctorToDepartmentViewModel(Guid id);
        Task<bool> AddDoctorToDepartmentAsync(AddDoctorViewModel model,Guid id);

        Task<DeleteDoctorViewModel> GetDeleteDoctorViewModel(Guid id);
        Task<bool> DeleteDoctorAsync(DeleteDoctorViewModel model);

    }
}
