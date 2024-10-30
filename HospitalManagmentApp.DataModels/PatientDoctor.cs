using static HospitalManagmentApp.Common.EntityValidationConstants;

namespace HospitalManagmentApp.DataModels
{
    public class PatientDoctor
    {
        public Guid PatientId { get; set; } = Guid.Empty;
        public Patient Patient { get; set; } = null!;

        public Guid DoctorId { get; set; } = Guid.Empty;
        public Doctor Doctor { get; set; } = null!;
    }
}