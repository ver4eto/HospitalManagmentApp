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

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var treatment = await context
                .Treatments
                .Where(d => d.Id == id && d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (treatment == null)
            {
                return this.View();
            }

            EditTreatmentViewModel model = new()
            {
               Name =treatment.Name,
               Price = treatment.Price,
             
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTreatmentViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var treatment = await context
                .Treatments
                .FindAsync(id);

            if (treatment == null)
            {
                return BadRequest();
            }

           treatment.Name = model.Name;
            treatment.Price= model.Price;


            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var treatment = await context
                .Treatments
                .FindAsync(id);

            if (treatment == null)
            {
                return BadRequest();
            }

            var model = new DeleteTreatmentViewModel
            {
                Name=treatment.Name,
                TreatmentId=id,

            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteTreatmentViewModel model, Guid id)
        {
            var treatment = await context
                .Treatments
                .Where(d => d.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (treatment == null)
            {
                return BadRequest();
            }

            treatment.IsDeleted = true;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
