using HospitalManagmentApp.DataModels;
using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;

namespace HospitalManagment.ViewModels.Doctor
{
    public class EditDoctorViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(LastNameMinLenght, LastNameMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(FirstNameMinLenght, FirstNameMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(SpecialtyMinLenght, SpecialtyMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string Specialty { get; set; } = SpecialtyDefaultValue;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(1.0d, double.MaxValue, ErrorMessage = SalaryMinValueErrorMessage)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public IEnumerable<HospitalManagmentApp.DataModels.Department> Departments { get; set; } =new List<HospitalManagmentApp.DataModels.Department>();

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid DepartmentId { get; set; }
    }
}
