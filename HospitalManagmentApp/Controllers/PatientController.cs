using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{

    public class PatientController : Controller
    {

        private readonly HMDbContext context;

        public PatientController(HMDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var patients = await context
                .Patients
                .Where(p => p.IsDeleted == false)
                .Select(p => new PatientIndexViewModel()
                {
                    Name = $"{p.FirstName} {p.LastName}",
                    EGN = p.EGN,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address,
                    Department = p.Department.Name,
                    Room = p.Room.RoomNumber,
                    HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
                    EmailAddress = p.EmailAddress,

                })
                .ToListAsync();

            return View(patients);
        }

        private static string HasMedicalInsurance(bool hasMedicalInsurance)
        {
            if (hasMedicalInsurance==true)
            {
                return "Yes";
            }
            return "No";

        }
    }
}
