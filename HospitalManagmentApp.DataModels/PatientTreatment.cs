using static HospitalManagmentApp.Common.EntityValidationConstants;

namespace HospitalManagmentApp.DataModels
{
    public class PatientTreatment
    {
        public Guid PatientId { get; set; } = Guid.Empty;
        public Patient Patient { get; set; } = null!;

        public Guid TreatmentId { get; set; } = Guid.Empty;
        public Treatment Treatment { get; set; } = null!;
    }
}