using HospitalManagment.ViewModels.Patient;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;


namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IPatientService
    {
        Task<List<PatientIndexViewModel>> GetAllPatientsAsync();
        Task<AddPatientViewModel> PrepareAddPatientViewModelAsync();
        Task <bool> AddPatientAsync(AddPatientViewModel model);
        Task<MovePatientToDepartmentViewModel?> GetMovePatientModelAsync(Guid id);
        Task <bool>MovePatientAsync(MovePatientToDepartmentViewModel model);
        Task <DischargePatientViewModel?> GetDischargePatientViewModel(Guid id);
        Task <bool> DischargePatientAsync(DischargePatientViewModel model,Guid id);
        Task<List<PatientIndexViewModel>> Menage();
        Task<List<SelectListItem>> GetFreeRoomsAsync(Guid departmentId);
        Task<List<SelectListItem>> GetFreeRoomsOnMoveAsync(Guid departmentId);
        Task<PatientMedicalInfoViewModel?> SeePatientMedicalInfo(Guid patientId);


        Task<AddTreatmentToPatientViewModel> GetAddTreatmentToPatientViewModel(Guid id);
        Task<bool> AddTreatmentToPatientAsync(AddTreatmentToPatientViewModel model);
        Task<ChangeTreatmentsViewModel> GetChangeTreatmentViewModel(Guid patientId);
        Task <bool> ChangeTreatmentsAsync(ChangeTreatmentsViewModel model);
    }
}
