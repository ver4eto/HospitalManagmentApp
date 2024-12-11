using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Controllers
{
    [Authorize(Roles = "Manager,Admin")]
    public class DoctorController : Controller
    {
       
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDoctorService doctorService;
        public DoctorController(UserManager<ApplicationUser> userManager, IDoctorService doctorService)
        {
           
            this.userManager = userManager;
            this.doctorService = doctorService;
        }
        public async Task< IActionResult> Index(string? search, string? specialty, string? department)
        {
           IEnumerable<DoctorIndexViewModel> doctors= await this.doctorService.IndexGetAllDoctorsAsync(search,specialty,department);

            ViewData["SearchQuery"]=search;
            ViewData["Sepecialty"] = specialty;
            ViewData["Department"]= department;

            if (!doctors.Any())
            {
                ViewBag.Message = "No doctors available.";
                doctors= await this.doctorService.IndexGetAllDoctorsAsync(null, null, null);
            }

            return View(doctors);
        }

        
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var doctor = await doctorService.GetAddDoctorViewModel();
            return View(doctor);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddDoctorViewModel model)
        {
            if (!ModelState.IsValid) 
            {                 
                return View(model);
            }

           await this.doctorService.AddDoctorAsync(model);
            return RedirectToAction(nameof(Index));
        }

        
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            EditDoctorViewModel? model=null;
            model = await doctorService.GetEditDoctorViewModel(id);           

            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditDoctorViewModel model,Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool doctorIsUpdated= await this.doctorService
                .EditDoctorAsync(model);

            if (!doctorIsUpdated)
            {
                ModelState.AddModelError(string.Empty, "Error occured while updating doctor!");
                return this.View(model);
            }

            return RedirectToAction(nameof(Index));

        }

       
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model= await this.doctorService.GetDeleteDoctorViewModel(id);
            return View(model);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DeleteDoctorViewModel model, Guid id)
        {
            var doctorIsDeleted = await doctorService.DeleteDoctorAsync(model,id);

            if (doctorIsDeleted == false)
            {
                return BadRequest();
            }
                        
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AddDoctorToDepartment(Guid depId) 
        {
            var model=  await doctorService.GetAddDoctorToDepartmentViewModel(depId);

            if (model == null)
            {
                return BadRequest();
            }
            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> AddDoctorToDepartment(AddDoctorToDepartmentViewModel model,Guid depId)
        {
            var success = await doctorService.GetAddDoctorToDepartmentAsync(model, depId);

            if (!success)
            {
                return BadRequest("Failed to add the doctor to the department.");
            }

            return RedirectToAction("Index", "Department");
            
        }

        
    }
}
