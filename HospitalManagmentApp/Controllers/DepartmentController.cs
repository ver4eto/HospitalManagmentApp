using HospitalManagment.ViewModels.Department;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
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
    }
}
