using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Drawing.Printing;
using static HospitalManagmentApp.Common.EntityValidationConstants;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;


using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace HospitalManagmentApp.Controllers
{
    [Authorize(Roles ="Doctor, Nurse, Manager,Admin")]
    public class PatientController : Controller
    {
        private readonly UserManager <ApplicationUser> userManager;
        private readonly IPatientService patientService;

        public PatientController(UserManager<ApplicationUser> userManager, IPatientService patientService)
        {
            this.userManager = userManager;
            this.patientService = patientService;
        }
        public async Task<IActionResult> Index(string? search, string? department, int? room, int pageNumber = 1, int pageSize = 3)   
        {
            var totalPatients = await patientService.GetTotalPatientsCountAsync(search, department, room);
            var totalPages = (int)Math.Ceiling((double)totalPatients / pageSize);

            // all patients for the current page
            var patients = await patientService.GetAllPatientsAsync(search, department, room, pageSize, pageNumber);

            // add info for pagination and filters
            ViewData["SearchQuery"] = search;
            ViewData["Department"] = department;
            ViewData["Room"] = room;
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            if (!patients.Any())
            {
                ViewBag.Message = "No patients available for the searched criteria. Displaying all patients below.";
                patients = await patientService.GetAllPatientsAsync(null, null, null, pageSize, pageNumber);
            }

            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var patient = await patientService.PrepareAddPatientViewModelAsync() ;
            
            return View(patient);
        }

        [HttpGet]
        public async Task<IActionResult> GetFreeRooms(Guid departmentId)
        {
            var freeRooms = await patientService.GetFreeRoomsAsync(departmentId);

            return Json(freeRooms);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
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

        [HttpGet]
        public async Task<IActionResult> GetFreeRoomsOnMove(Guid departmentId)
        {
            var freeRooms = await patientService.GetFreeRoomsOnMoveAsync(departmentId);

            return Json(freeRooms);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DischargePatient(DischargePatientViewModel model, Guid id)
        {
            var patientIsDischarged = await patientService.DischargePatientAsync(model,id);

            if (patientIsDischarged == false)
            {
                return BadRequest();
            }
                       
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> SeePatientMedicalInfo(Guid patientId)
        {
            var patientMedicalInfo=await patientService.SeePatientMedicalInfo(patientId);

            if (patientMedicalInfo == null)
            {
                return NotFound();
            }
            return View(patientMedicalInfo);
        }

        [HttpGet]
        [Route("Patient/AddTreatmentToPatient")]
        public async Task<IActionResult> AddTreatmentToPatient(Guid patientId)
        {
           
            var patient = await patientService.GetAddTreatmentToPatientViewModel(patientId);

            if (patient == null)
            {
                return NotFound("Patient not found.");
            }

            return View(patient);
        }

        [HttpPost]
        [Route("Patient/AddTreatmentToPatientAsync")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTreatmentToPatientAsync(AddTreatmentToPatientViewModel model)
        {
            
            if (!ModelState.IsValid)
            {               
                return View( model);
            }

            // Save changes to the database
           var result = await patientService.AddTreatmentToPatientAsync(model);
            if (result == true)
            {
                TempData["SuccessMessage"] = "Treatment was successfully added to the patient.";

                // Redirect to the Index action
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(AddTreatmentToPatient),new { patientId=model.PatientId});
            }

            else
            {
                ModelState.AddModelError("", "Failed to add treatment.");
                return View(model);
            }

            
        }

        [HttpGet]
        public async Task<IActionResult> ChangeTreatments(Guid patientId)
        {
           var model=await patientService.GetChangeTreatmentViewModel(patientId);

            if (model == null)
            {
                return NotFound("Patient not found.");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeTreatments(ChangeTreatmentsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); 
            }

            var result= await patientService.ChangeTreatmentsAsync(model);
            if (result == true)
            {

                TempData["SuccessMessage"] = "Treatments updated successfully.";
                return RedirectToAction("Index");
            }

            else
            {
               
                TempData["ErrorMessage"] = "Failed to update treatments. Please try again.";
                return RedirectToAction("ChangeTreatments", new { patientId = model.PatientId });
            }
        }
    }
}
