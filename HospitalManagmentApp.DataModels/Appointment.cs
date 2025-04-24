
namespace HospitalManagmentApp.DataModels
{
    public class Appointment
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public Doctor Doctor { get; init; } = default!;
        public Patient Patient { get; init; } = default!;
        public DateTime Start { get; init; }
        public DateTime End { get; init; }

        public override string ToString() => $"{Start:yyyy-MM-dd HH:mm} – {End:HH:mm} | Dr. {Doctor.FirstName} {Doctor.LastName} with {Patient.FirstName} {Patient.LastName}";
    }
}
