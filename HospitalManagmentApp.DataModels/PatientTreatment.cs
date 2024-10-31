using Microsoft.EntityFrameworkCore;
using static HospitalManagmentApp.Common.EntityValidationConstants;

namespace HospitalManagmentApp.DataModels
{
    [PrimaryKey(nameof(PatientId), nameof(TreatmentId))]
    public class PatientTreatment
    {
        public Guid PatientId { get; set; } = Guid.Empty;
        public Patient Patient { get; set; } = null!;

        public Guid TreatmentId { get; set; } = Guid.Empty;
        public Treatment Treatment { get; set; } = null!;
    }
}