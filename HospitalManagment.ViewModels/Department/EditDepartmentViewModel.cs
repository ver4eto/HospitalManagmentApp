using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Department;

namespace HospitalManagment.ViewModels.Department
{
    public class EditDepartmentViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(DepartmentMaxLength, MinimumLength = DepartmentMinLength, ErrorMessage = LenghtErrorMessage)]

        public string Name { get; set; } = null!;

        public Guid DepartmentId { get; set; }

    }
}
