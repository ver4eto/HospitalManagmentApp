using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Treatment;

namespace HospitalManagment.ViewModels.Treatment
{
    public class AddTreatmentViewModel
    {
        

        [Required(ErrorMessage =RequiredErrorMessage)]
        [StringLength(TreatmentMaxLength,MinimumLength =TreatmentMinLength,ErrorMessage =LenghtErrorMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage =RequiredErrorMessage)]
        [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Price must be at least 0.01 !")]
        public decimal Price { get; set; }
    }
}
