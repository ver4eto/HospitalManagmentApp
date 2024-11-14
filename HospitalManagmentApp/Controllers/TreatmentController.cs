using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Treatment;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class TreatmentController : Controller
    {
        private readonly HMDbContext context;

        public TreatmentController(HMDbContext dbContext)
        {
            this.context = dbContext;
        }
        public async Task< IActionResult> Index()
        {
            var treatments=  await context
                .Treatments
                .Where(t=>t.IsDeleted==false)
                .Select(t=>new TreatmentIndexViewModel()
                {
                    Name = t.Name,
                    Price=t.Price.ToString("f2"),
                    Id=t.Id
                })
                .ToListAsync();
            return View(treatments);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var treatment = new AddTreatmentViewModel();            
            return View(treatment);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTreatmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
               
                return View(model);
            }

            var treatment = new Treatment()
            {
                Name=model.Name,
                Price=model.Price,
            };

            await context.Treatments.AddAsync(treatment);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
