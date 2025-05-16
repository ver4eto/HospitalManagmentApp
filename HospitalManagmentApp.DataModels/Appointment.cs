
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.DataModels
{
    [PrimaryKey(nameof(PatientId), nameof(DoctorId))]
    public class Appointment
    {
        public Guid Id { get; init; } = Guid.Empty;

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public Guid PatientId { get; set; }= Guid.Empty;
        public Patient Patient { get; init; } =null!;


        public DateTime Start { get; init; }
        public DateTime End { get; init; }

        public override string ToString() => $"{Start:yyyy-MM-dd HH:mm} – {End:HH:mm} | Dr. {Doctor.FirstName} {Doctor.LastName} with {Patient.FirstName} {Patient.LastName}";
    }
}
