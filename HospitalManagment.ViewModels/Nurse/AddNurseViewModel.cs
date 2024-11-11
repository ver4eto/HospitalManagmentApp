using HospitalManagmentApp.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Nurse;

namespace HospitalManagment.ViewModels.Nurse
{
    public class AddNurseViewModel
    {
        [Required(ErrorMessage =RequiredErrorMessage)]
        [Length(NurseFirstNameMinLength,NurseFirstNameMaxLength,ErrorMessage =LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;


        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(NurseLastNameMinLength, NurseFirstNameMaxLength, ErrorMessage = LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Column(TypeName = "money")]
        [Range(1.00,double.MaxValue)]
        public decimal Salary { get; set; }

        public Guid DepartmentId { get; set; }
        public IEnumerable<Department> Departments { get; set; }=new List<Department>();

    }
}
