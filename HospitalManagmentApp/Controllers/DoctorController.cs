using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

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
                .ToArrayAsync();
            return View(doctors);
        }
    }
}
