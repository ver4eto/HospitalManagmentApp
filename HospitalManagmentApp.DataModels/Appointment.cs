
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagmentApp.DataModels
{
    
    public class Appointment
    {
        [Key]
        public Guid Id { get; init; } = Guid.Empty;

        public Guid DoctorId { get; set; }= Guid.Empty; 
        public Doctor Doctor { get; set; } = null!;

        public Guid PatientId { get; set; }= Guid.Empty;
        public Patient Patient { get; set; } =null!;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime End { get; set; }

        public override string ToString() => $"{Start:yyyy-MM-dd HH:mm} – {End:HH:mm} | Dr. {Doctor.FirstName} {Doctor.LastName} with {Patient.FirstName} {Patient.LastName}";
    }
}
