using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
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
                   FirstName= d.FirstName,
                  LastName=  d.LastName,
                   Specialty= d.Specialty,
                   DepartmentName= d.Department.Name,

                })
                .ToListAsync();
            return View(doctors);
        }
    }
}
