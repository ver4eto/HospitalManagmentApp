using HospitalManagment.ViewModels.Department;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Room;
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
        public IActionResult Add()
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

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var department = await context
                .Departments
                .Where(d => d.Id == id && d.IsDeleted == false)                
                .FirstOrDefaultAsync();

            if (department == null)
            {
                return this.View();
            }

            EditDepartmentViewModel model = new()
            {
              Name= department.Name,
              DepartmentId= department.Id
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditDepartmentViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var dep = await context
                .Departments
                .FindAsync(id);

            if (dep == null)
            {
                return BadRequest();
            }

            dep.Name = model.Name;


            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var department = await context
                .Departments
                .FindAsync(id);

            if (department == null)
            {
                return BadRequest();
            }

            var model = new DeleteDepartmentViewModel
            {
               DepartmentId = department.Id,
               Name = department.Name
            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDepartmentViewModel model, Guid id)
        {
            var dep = await context
                .Departments
                .Where(d => d.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (dep == null)
            {
                return BadRequest();
            }

            dep.IsDeleted = true;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      
    }
}
