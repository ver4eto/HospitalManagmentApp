using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Appointment;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Services.Data
{
    public class AppointmentService : IAppointmentService
    {
        private IRepository<Appointment, Guid> appointmentRepository;
        private IRepository<Doctor, Guid> doctorRepository;
        private IRepository<Patient, Guid> patientRepository;

        public AppointmentService(IRepository<Appointment, Guid> appointmentRepository, IRepository<Doctor, Guid> doctorRepository, IRepository<Patient, Guid> patientRepository)
        {
            this.appointmentRepository = appointmentRepository;
            this.doctorRepository = doctorRepository;
            this.patientRepository = patientRepository;
        }

        public async  Task<IEnumerable<AppointmentIndexViewModel>> GetAllAppointmentsAsync(/*Guid doctorId*/)
        {
            try
            {
                var appointments = this.appointmentRepository
                    .GetAllAttcahed()
                    /*.Where(a => a.DoctorId == doctorId)*/;

                var appointmentsTodisplay = await appointments   
                    .Include(a=>a.Doctor)
                    .Include(a=>a.Patient)
                    .Select(a => new AppointmentIndexViewModel 
                    { 
                        DoctorFirstName= a.Doctor.FirstName,
                        DoctorLastName= a.Doctor.LastName,
                        PatientFirstName= a.Patient.FirstName,
                        PatientLastName= a.Patient.LastName,
                        Start= a.Start,
                        End= a.End,
                    })
                    .ToArrayAsync();

                return appointmentsTodisplay;

            }
            catch (Exception ex)
            {

                throw new NotImplementedException(ex.Message);
            }
            
            
        }
    }
}
