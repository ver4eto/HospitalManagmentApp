using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class DoctorController : Controller
    {
        private readonly HMDbContext context;

        public DoctorController(HMDbContext _context)
        {
            this.context = _context;
        }
        public async Task< IActionResult> Index()
        {
            var doctors=await context
                .Doctors    
                .Where(d=>d.IsDeleted==false)
                .Select(d=>new DoctorIndexViewModel()
                {
                    Id = d.Id,
                   FirstName= d.FirstName,
                  LastName=  d.LastName,
                   Specialty= d.Specialty,
                   DepartmentName= d.Department.Name,

                })
                .ToListAsync();
            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var doctor = new AddDoctorViewModel();
            doctor.Departents = await GetDepartments();
            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddDoctorViewModel model)
        {
            if (!ModelState.IsValid) 
            { 
                model.Departents=await GetDepartments();
                return View(model);
            }

            var doctor = new Doctor()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Specialty= model.Specialty,
                EmailAddress= model.EmailAddress,
                Salary= model.Salary,
                DepartmnetId=model.DepartmentId,
            };

           await context.Doctors.AddAsync(doctor);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Menage(Guid id)
        {
            var doctor  =await context
                .Doctors                
                .Where(d=>d.Id==id /*&& d.IsDeleted==false*/)  
                .Include(d=>d.Department)
                .FirstOrDefaultAsync();

            if (doctor == null)
            {
                return RedirectToAction(nameof (Index));
            }

            MenageDoctorViewModel model = new MenageDoctorViewModel()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialty = doctor.Specialty,
                EmailAddress = doctor.EmailAddress,
                Salary = doctor.Salary,
                DepartmentName = doctor.Department.Name
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var doctor = await context
                .Doctors
                .Where(d => d.Id == id && d.IsDeleted == false)
                .Include(d => d.Department)
                .FirstOrDefaultAsync();

            if(doctor == null)
            {
                return this.View();
            }

            EditDoctorViewModel model = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialty = doctor.Specialty,
                EmailAddress = doctor.EmailAddress,
                Salary = doctor.Salary,
                DepartmentId = doctor.Department.Id,
                Departments=await GetDepartments()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditDoctorViewModel model,Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var doctor= await context
                .Doctors
                .FindAsync(id);

            if (doctor == null)
            { 
                return BadRequest();
            }

            doctor.FirstName = model.FirstName;
            doctor.LastName = model.LastName;
            doctor.Salary = model.Salary;
            doctor.Specialty = model.Specialty;
            doctor.DepartmnetId=model.DepartmentId;
            doctor.EmailAddress = model.EmailAddress;
           
            
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var doctor = await context
                .Doctors
                .FindAsync(id);

            if(doctor == null)
            {
                return BadRequest();
            }

            var model = new DeleteDoctorViewModel
            {
                Id = id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                DepartmentName = doctor.Department.Name,
                Specialty = doctor.Specialty,
            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDoctorViewModel model, Guid id)
        {
            var doctor = await context
                .Doctors
                .Where(d => d.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (doctor == null)
            {
                return BadRequest();
            }

            doctor.IsDeleted = true;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private async Task<ICollection<Department>> GetDepartments()
        {
           return await context.Departments.ToListAsync();
        }
    }
}
