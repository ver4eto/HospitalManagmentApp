using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static HospitalManagmentApp.Common.EntityValidationConstants.Nurse;
namespace HospitalManagmentApp.DataModels
{

    [Comment("Nurse info table")]
    public class Nurse
    {
        [Key]
        [Comment("Nurse unnique identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NurseFirstNameMaxLength)]
        [Comment("Nurse first name")]
        public string FirstName { get; set; } = null!;


        [Required]
        [MaxLength(NurseLastNameMaxLength)]
        [Comment("Nurse last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Comment("Nurse monthly salary")]
        public decimal Salary { get; set; }

        [Required]
        [Comment("Nurse`s department")]
        public Guid DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } = null!;
    }
}