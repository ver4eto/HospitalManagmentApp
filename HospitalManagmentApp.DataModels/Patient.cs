using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static HospitalManagmentApp.Common.EntityValidationConstants.Patient;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Patient Info Table")]
    public class Patient
    {
        [Key]
        [Comment("Unique identifier of Patient")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLenght)]
        [Comment("Patient First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLenght)]
        [Comment("Patient Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Comment("Patient Personal Citizen Number")]
        public string EGN { get; set; } = EGNDefault;

        [Comment("Patient phone number")]
        public string PhoneNumber { get; set; } = PhoneDefaultValue;

        [Required]
        [MaxLength(AdressMaxLength)]
        [Comment("Patient address")]
        public string Address { get; set; } = null!;

        [Required]
        [Comment("Specify if the patient is insured")]
        public bool HasMedicalInsurance { get; set; } = true;

        public IEnumerable<PatientTreatment> PatientTreatments { get; set; } = new HashSet<PatientTreatment>();
        public IEnumerable<PatientDoctor> Doctors { get; set; } = new HashSet<PatientDoctor>();


        [Comment("In which department the patient is assigned")]
        public Guid DepartmentId { get; set; } = Guid.Empty;

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } = null!;


        [Comment("Room of the patient")]
        public Guid RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public Room? Room { get; set; }
    }
}