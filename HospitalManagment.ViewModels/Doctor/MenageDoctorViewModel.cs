using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;
using static HospitalManagmentApp.Common.ApplicationConstants;
using HospitalManagmentApp.DataModels;

namespace HospitalManagment.ViewModels.Doctor
{
    public class MenageDoctorViewModel
    {
        public Guid Id { get; set; }

       
        public string LastName { get; set; } = null!;

       
        public string FirstName { get; set; } = null!;

       
        public string Specialty { get; set; } = SpecialtyDefaultValue;

       
        public string EmailAddress { get; set; } = null!;

       
        public decimal Salary { get; set; }

       
        public string DepartmentName { get; set; } = null!;

       
    }
}
