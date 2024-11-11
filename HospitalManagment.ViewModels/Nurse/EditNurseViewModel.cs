using HospitalManagmentApp.DataModels;
using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Nurse;

namespace HospitalManagment.ViewModels.Nurse
{
    public class EditNurseViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(NurseLastNameMinLength, NurseLastNameMaxLength, ErrorMessage = LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(NurseFirstNameMinLength, NurseFirstNameMaxLength, ErrorMessage = LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;

        

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(1.0d, double.MaxValue, ErrorMessage = SalaryMinValueErrorMessage)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public IEnumerable<Department> Departments { get; set; } = new List<Department>();

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid DepartmentId { get; set; }
    }
}
