using System.ComponentModel.DataAnnotations;

namespace HospitalManagment.ViewModels.Appointment

{
    public class AppointmentIndexViewModel
    {

        public Guid Id { get; set; }


        public string DoctorFirstName { get; set; } = null!;
        public string DoctorLastName { get; set; } = null!;

        public string PatientFirstName { get; set; } = null!;
        public string PatientLastName { get; set; } = null!;

        public DateTime Start { get; set; }
              
        public DateTime End { get; set; }
    }
}
