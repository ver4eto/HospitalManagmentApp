using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Doctor info table")]
    public class Doctor 
    {
        [Key]
        [Comment("Doctor`s unique identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Doctor`s Last Name")]
        [MaxLength(LastNameMaxLenght)]
        
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(FirstNameMaxLenght)]
        [Comment("Doctor`s First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(SpecialtyMaxLenght)]
        [Comment("Doctor`s Speciality")]
        public string Specialty { get; set; } = SpecialtyDefaultValue;

        [Required]
        [EmailAddress]
        [Comment("The person email address")]
        public string EmailAddress { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Comment("Doctor`s monthly salary")]
        public decimal Salary { get; set; }

        [Required]
        [Comment("Soft delete property")]
        public bool IsDeleted { get; set; } = false;

       
        [Comment("In which department works the doctor")]
        public Guid DepartmentId { get; set; } 

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } =null!;

        public IEnumerable<PatientDoctor> DoctorPatients { get; set; } = new HashSet<PatientDoctor>();

        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
