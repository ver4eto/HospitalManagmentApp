using System.Web.Mvc;

namespace HospitalManagment.ViewModels.Patient
{
    public class AddTreatmentToPatientViewModel
    {
        public Guid PatientId { get; set; }

        
        public string FirstName { get; set; } = null!;

       
        public string LastName { get; set; }=null!;
        public string DepartmentName { get; set; } = null!;

        public IList<SelectListItem> AvailableTreatments { get; set; } = new List<SelectListItem>();

        public List<Guid> SelectedTreatmentIds { get; set; } = new List<Guid>(); 
    }
}
