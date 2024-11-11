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
                    Id=n.Id,
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

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var nurse = await context
                .Nurses
                .Where(d => d.Id == id && d.IsDeleted == false)
                .Include(d => d.Department)
                .FirstOrDefaultAsync();

            if (nurse == null)
            {
                return this.View();
            }

            EditNurseViewModel model = new()
            {
                Id = nurse.Id,
                FirstName = nurse.FirstName,
                LastName = nurse.LastName,
                
                EmailAddress = nurse.EmailAddress,
                Salary = nurse.Salary,
                DepartmentId = nurse.Department.Id,
                Departments = await GetDepartments()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditNurseViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var nurse = await context
                .Nurses
                .FindAsync(id);

            if (nurse == null)
            {
                return BadRequest();
            }

            nurse.FirstName = model.FirstName;
            nurse.LastName = model.LastName;
            nurse.Salary = model.Salary;           
            nurse.DepartmentId = model.DepartmentId;
            nurse.EmailAddress = model.EmailAddress;


            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var nurse = await context
                .Nurses
                .FindAsync(id);

            if (nurse == null)
            {
                return BadRequest();
            }

            var model = new DeleteNurseViewModel
            {
                Id = id,
                FirstName = nurse.FirstName,
                LastName = nurse.LastName,
                DepartmentName = nurse.Department.Name,
               
            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteNurseViewModel model, Guid id)
        {
            var nurse = await context
                .Nurses
                .Where(d => d.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (nurse == null)
            {
                return BadRequest();
            }

            nurse.IsDeleted = true;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private async Task<ICollection<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
