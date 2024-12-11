using HospitalManagment.ViewModels.Department;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartmentIndexViewModel>> GetAllDepartmentsAsync();
        Task<bool> AddDepartmentAsync(AddDepartmentViewModel model);
        Task<EditDepartmentViewModel> GetEditDepartmentViewModelAsync(Guid id);
        Task<bool> UpdateDepartmentAsync(Guid id, EditDepartmentViewModel model);
        Task<DeleteDepartmentViewModel> GetDeleteDepartmentViewModelAsync(Guid id);
        Task<bool> DeleteDepartmentAsync(Guid id);
    }
}
