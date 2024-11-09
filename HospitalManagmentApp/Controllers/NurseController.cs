using HospitalManagment.ViewModels.Doctor;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class NurseController : Controller
    {
        private readonly HMDbContext context;

        public NurseController(HMDbContext context)
        {
            this.context = context;
        }
        public async Task< IActionResult> Index()
        {
            var nurses=await context
                .Nurses
                .Where(n=>n.IsDeleted==false)
                .Select(n =>new NurseIndexViewModel
                { 
                FirstName = n.FirstName,
                LastName = n.LastName,
                Department=n.Department.Name,
                })
                .ToListAsync();

            return View(nurses);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var nurse = new AddNurseViewModel();
            nurse.Departments = await GetDepartments();
            return View(nurse);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddNurseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Departments = await GetDepartments();
                return View(model);
            }

            var nurse = new Nurse()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
               
                EmailAddress = model.EmailAddress,
                Salary = model.Salary,
                DepartmentId = model.DepartmentId,
            };

            await context.Nurses.AddAsync(nurse);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<ICollection<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
