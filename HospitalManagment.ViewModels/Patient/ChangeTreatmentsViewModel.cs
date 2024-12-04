

using System.Web.Mvc;

namespace HospitalManagment.ViewModels.Patient
{
    public class ChangeTreatmentsViewModel
    {
        public Guid PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }

        public List<SelectListItem> AssignedTreatments { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> AvailableTreatments { get; set; } = new List<SelectListItem>();

        public List<Guid> NewTreatmentIds { get; set; } = new List<Guid>();
        public List<Guid> RemovedTreatmentIds { get; set; } = new List<Guid>();
    }
}
