using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace HospitalManagmentApp.Controllers
{

    public class PatientController : Controller
    {

        private readonly HMDbContext context;
        private readonly UserManager <ApplicationUser> userManager;
        private readonly IPatientService patientService;
        public PatientController(HMDbContext context, UserManager<ApplicationUser> userManager, IPatientService patientService)
        {
            this.context = context;
            this.userManager = userManager;
            this.patientService = patientService;
        }
        public async Task<IActionResult> Index()
        {
            var patients = await patientService.GetAllPatientsAsync();

            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var patient = await patientService.PrepareAddPatientViewModelAsync() ;
            
            return View(patient);
        }

        //[HttpGet]
        //public async Task< IActionResult> GetFreeRooms(Guid departmentId)
        //{
        //    var freeRooms =await context.Rooms
        //        .Where(r => r.DepartmnetId == departmentId && r.HasFreeBeds == true)
        //        .Select(r => new SelectListItem
        //        {
        //            Value = r.Id.ToString(),
        //            Text = r.RoomNumber.ToString(),
        //        }).ToListAsync();

        //    return Json(freeRooms); 
        //}


        [HttpPost]
        public async Task<IActionResult> Add(AddPatientViewModel model)
        {
            if (!ModelState.IsValid)
            {
               AddPatientViewModel addPatientViewModel =await patientService.PrepareAddPatientViewModelAsync();

                return View(addPatientViewModel);
            }

            var isPatientAdded=await patientService.AddPatientAsync(model);
            if (!isPatientAdded)
            {
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Manage()
        {
            var patients = await patientService.Menage();

            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> MovePatient(Guid id)
        {
            var patient=await patientService.GetMovePatientModelAsync(id);

            if (patient == null)
            {
                return BadRequest();
            }

            return View(patient);
        }

        //[HttpGet]
        //public async Task< IActionResult> GetFreeRoomsOnMove(Guid departmentId)
        //{
        //    var freeRooms =await context.Rooms
        //        .Where(r => r.DepartmnetId == departmentId && !r.Patients.Any())
        //        .Select(r => new { value = r.Id, text = r.RoomNumber })
        //        .ToListAsync();

        //    return Json(freeRooms);
        //}

        [HttpPost]
        public async Task<IActionResult> MovePatient(MovePatientToDepartmentViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var patientIsMoved = await patientService.MovePatientAsync(model);

            if (patientIsMoved == false)
                {
                return BadRequest(); 
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> DischargePatient(Guid id)
        {
            var patient = await patientService.GetDischargePatientViewModel(id);

            if (patient == null)
            {
                return BadRequest();
            }
            //TODO: check if user is in this department!!


            return View(patient);

        }


        [HttpPost]
        public async Task<IActionResult> DischargePatient(DischargePatientViewModel model, Guid id)
        {
            var patientIsDischarged = await patientService.DischargePatientAsync(model,id);

            if (patientIsDischarged == false)
            {
                return BadRequest();
            }
                       
            return RedirectToAction(nameof(Index));
        }

       
    }
}
