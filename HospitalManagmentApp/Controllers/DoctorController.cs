using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Controllers
{
    public class DoctorController : Controller
    {
       
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDoctorService doctorService;
        public DoctorController(UserManager<ApplicationUser> userManager, IDoctorService doctorService)
        {
           
            this.userManager = userManager;
            this.doctorService = doctorService;
        }
        public async Task< IActionResult> Index()
        {
           IEnumerable<DoctorIndexViewModel> doctors= await this.doctorService.IndexGetAllDoctorsAsync();
            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var doctor = await doctorService.GetAddDoctorViewModel();
            return View(doctor);
        }

        [HttpPost]
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
        public async Task<IActionResult> Menage(Guid id)
        {
            MenageDoctorViewModel? model = await this.doctorService.MenageDoctor(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            EditDoctorViewModel? model=null;
            model = await doctorService.GetEditDoctorViewModel(id);           

            return View(model);
        }

        [HttpPost]
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

            //doctor.FirstName = model.FirstName;
            //doctor.LastName = model.LastName;
            //doctor.Salary = model.Salary;
            //doctor.Specialty = model.Specialty;
            //doctor.DepartmnetId=model.DepartmentId;
            //doctor.EmailAddress = model.EmailAddress;
           
            
            //await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            //var doctor = await context
            //    .Doctors
            //    .FindAsync(id);

            //if(doctor == null)
            //{
            //    return BadRequest();
            //}

            //var model = new DeleteDoctorViewModel
            //{
            //    Id = id,
            //    FirstName = doctor.FirstName,
            //    LastName = doctor.LastName,
            //    DepartmentName = doctor.Department.Name,
            //    Specialty = doctor.Specialty,
            //};
            var model= await this.doctorService.GetDeleteDoctorViewModel(id);
            return View(model);

        }


        [HttpPost]
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
