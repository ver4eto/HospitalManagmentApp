using HospitalManagment.ViewModels.Treatment;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface ITreatmentService
    {
        Task<List<TreatmentIndexViewModel>> GetAllTreatmentsAsync();
        Task<bool> AddTreatmentAsync(AddTreatmentViewModel model);
        Task<EditTreatmentViewModel> GetEditTreatmentViewModelAsync(Guid id);
        Task<bool> UpdateTreatmentAsync(Guid id, EditTreatmentViewModel model);
        Task<DeleteTreatmentViewModel> GetDeleteTreatmentViewModelAsync(Guid id);
        Task<bool> DeleteTreatmentAsync(Guid id);
    }
}
