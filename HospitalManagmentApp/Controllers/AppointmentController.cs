using HospitalManagment.ViewModels.Appointment;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using static HospitalManagmentApp.Common.EntityValidationConstants;

namespace HospitalManagmentApp.Controllers
{
    public class AppointmentController : Controller
    {
        //private readonly UserManager<ApplicationUser> userManager;
        private readonly IAppointmentService appointmentService;
        public AppointmentController( IAppointmentService appointmentService)
        {

           
            this.appointmentService = appointmentService;
        }

        //public IActionResult Details(Guid id)
        //{
        //    var appointment = _appointments.FirstOrDefault(a => a.Id == id);
        //    if (appointment == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(appointment);
        //}

        public async Task <IActionResult> Index()
        {
            IEnumerable<AppointmentIndexViewModel> appointments =await this.appointmentService.GetAllAppointmentsAsync();



            //if (!appointmentService.Any())
            //{
            //    ViewBag.Message = "No doctors available.";
            //    doctors = await this.doctorService.IndexGetAllDoctorsAsync(null, null, null);
            //}

            var vm = (appointments ?? Enumerable.Empty<AppointmentIndexViewModel>())
              .ToList();

            return View(vm);

        }
    }
}
