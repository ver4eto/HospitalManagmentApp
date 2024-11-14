using HospitalManagment.ViewModels.Department;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly HMDbContext context;

        public DepartmentController(HMDbContext _context)
        {
            this.context = _context;
        }
        public async Task<IActionResult> Index()
        {
            var dep = await context
                .Departments
                .Where(d => d.IsDeleted == false)
                .Select(d => new DepartmentIndexViewModel()
                {
                    Id = d.Id,
                   Name = d.Name,
                   DepartmentDoctors=d.DepartmentDoctors.Count(),
                   Rooms=d.Rooms.Count(),
                   Nurses=d.Nurses.Count(),

                })
                .ToListAsync();
            return View(dep);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var doctor = new AddDepartmentViewModel();           
            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddDepartmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
              
                return View(model);
            }

            var deparment = new Department()
            {
                Name = model.Name,
            };

            await context.Departments.AddAsync(deparment);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
