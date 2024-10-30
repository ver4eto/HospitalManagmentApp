using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HospitalManagmentApp.Common.EntityValidationConstants.Treatment;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Treatment info table")]
    public class Treatment
    {
        [Key]
        [Comment("Treatment unique identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TreatmentMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public IEnumerable<PatientTreatment> Patients { get; set; } = new HashSet<PatientTreatment>();
    }
}
