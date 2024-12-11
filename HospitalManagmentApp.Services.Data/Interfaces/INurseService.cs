using HospitalManagment.ViewModels.Nurse;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface INurseService
    {
        Task<List<NurseIndexViewModel>> GetAllNursesAsync(string ? search, string?department);
        Task<AddNurseViewModel> GetAddNurseViewModelAsync();
        Task<bool> AddNurseAsync(AddNurseViewModel model);
        Task<EditNurseViewModel> GetEditNurseViewModelAsync(Guid id);
        Task<bool> UpdateNurseAsync(Guid id, EditNurseViewModel model);
        Task<DeleteNurseViewModel> GetDeleteNurseViewModelAsync(Guid id);
        Task<bool> DeleteNurseAsync(Guid id);
        Task<AddNurseToDepartmentViewModel> GetAddNurseToDepartmentViewModelAsync(Guid departmentId);
        Task<bool> AddNurseToDepartmentAsync(Guid departmentId, Guid selectedNurseId);
        //Task<ICollection<Department>> GetAllDepartmentsAsync();
    }
}
