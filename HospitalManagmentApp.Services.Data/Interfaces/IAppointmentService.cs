using HospitalManagment.ViewModels.Appointment;
using HospitalManagmentApp.DataModels;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentIndexViewModel>> GetAllAppointmentsAsync(/*Guid doctorId*/);
    }
}
