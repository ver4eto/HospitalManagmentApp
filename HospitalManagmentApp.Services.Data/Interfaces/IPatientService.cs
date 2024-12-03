using HospitalManagment.ViewModels.Patient;
using Microsoft.AspNetCore.Mvc;


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
        Task<List<System.Web.Mvc.SelectListItem>> GetFreeRoomsAsync(Guid departmentId);
        Task<List<System.Web.Mvc.SelectListItem>> GetFreeRoomsOnMoveAsync(Guid departmentId);
        Task<PatientMedicalInfoViewModel?> SeePatientMedicalInfo(Guid patientId);
    }
}
