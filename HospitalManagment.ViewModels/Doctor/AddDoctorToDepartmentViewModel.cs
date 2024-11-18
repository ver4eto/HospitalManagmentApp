using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;

namespace HospitalManagment.ViewModels.Doctor
{
    public class AddDoctorToDepartmentViewModel
    {
        public Guid DepartmentId { get; set; }
        
        public string DepartmentName { get; set; } = null!;
       
        public List<HospitalManagmentApp.DataModels.Doctor> Doctors { get; set; } = new List<HospitalManagmentApp.DataModels.Doctor>();// List of Doctor objects
       
        public Guid SelectedDoctorId { get; set; }
      
       
        public string LastName { get; set; } = null!;

        
        public string FirstName { get; set; } = null!;

       
        public string Specialty { get; set; }=null!;


    }
}
