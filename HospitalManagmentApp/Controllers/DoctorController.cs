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
        public IActionResult Index()
        {
            var doctors=context
                .Doctors                
                .Select(d=>new DoctorIndexViewModel()
                {
                   FirstName= d.FirstName,
                  LastName=  d.LastName,
                   Specialty= d.Specialty,
                   DepartmentName= d.Department.Name,

                })
                .ToArray()
                ;
            return View(doctors);
        }
    }
}
