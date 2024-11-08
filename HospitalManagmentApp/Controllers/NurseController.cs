using HospitalManagment.ViewModels.Nurse;
using HospitalManagmentApp.Data;
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
    }
}
