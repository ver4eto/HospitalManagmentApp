using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Patient;

using System.Web.Mvc;
using System.ComponentModel;

namespace HospitalManagment.ViewModels.Patient
{
    public class AddPatientViewModel
    {
        [Required(ErrorMessage =RequiredErrorMessage)]
        [StringLength(FirstNameMaxLenght, MinimumLength = FirstNameMinLenght, ErrorMessage = LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(LastNameMaxLenght,MinimumLength = LastNameMinLenght, ErrorMessage = LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string EGN { get; set; }=null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [PasswordPropertyText]
        public string Password { get; set; } = null!;
        public string? PhoneNumber { get; set; } 

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength( AdressMaxLength,MinimumLength =AdressMinLength, ErrorMessage = LenghtErrorMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public bool HasMedicalInsurance { get; set; } = true;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid DepartmentId { get; set; }

        public IEnumerable<HospitalManagmentApp.DataModels.Department> Departments { get; set; }=new List<HospitalManagmentApp.DataModels.Department>();

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid RoomId { get; set; }

        public List<SelectListItem> Rooms { get; set; } = new List<SelectListItem>();

        public Guid SelectedDoctorId { get; set; } 
        public List<SelectListItem> Doctors { get; set; } = new List<SelectListItem>();
       
    }
}
