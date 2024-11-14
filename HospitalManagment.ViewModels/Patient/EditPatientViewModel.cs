using HospitalManagmentApp.DataModels;
using System.ComponentModel.DataAnnotations;

using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Patient;

namespace HospitalManagment.ViewModels.Patient
{
    public class EditPatientViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(FirstNameMaxLenght, MinimumLength = FirstNameMinLenght, ErrorMessage = LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(LastNameMaxLenght, MinimumLength = LastNameMinLenght, ErrorMessage = LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string EGN { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;


        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(AdressMaxLength, MinimumLength = AdressMinLength, ErrorMessage = LenghtErrorMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public bool HasMedicalInsurance { get; set; } = true;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid DepartmentId { get; set; }

        public IEnumerable<HospitalManagmentApp.DataModels.Department> Departments { get; set; } = new List<HospitalManagmentApp.DataModels.Department>();

        public int MyProperty { get; set; }
    }
}
