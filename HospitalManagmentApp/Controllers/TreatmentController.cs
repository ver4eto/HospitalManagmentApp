using HospitalManagment.ViewModels.Treatment;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace HospitalManagmentApp.Controllers
{
    [Authorize(Roles ="Doctor,Nurse, Admin,Manager")]
    public class TreatmentController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ITreatmentService treatmentService;
        public TreatmentController( ITreatmentService treatmentService)
        {
            this.treatmentService = treatmentService;

        }
        public async Task<IActionResult> Index()
        {
            var treatments= await treatmentService.GetAllTreatmentsAsync();
            return View(treatments);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var treatment = new AddTreatmentViewModel();            
            return View(treatment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddTreatmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
               
                return View(model);
            }

            var treatment = await treatmentService.AddTreatmentAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var treatment = await treatmentService.GetEditTreatmentViewModelAsync(id);

            return View(treatment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditTreatmentViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var treatment = await treatmentService.UpdateTreatmentAsync(id, model);

            if (treatment == null)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var treatment = await treatmentService.GetDeleteTreatmentViewModelAsync(id);

            if (treatment == null)
            {
                return BadRequest();
            }
                        
            return View(treatment);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DeleteTreatmentViewModel model, Guid id)
        {
            var treatment = await treatmentService.DeleteTreatmentAsync(id);

            if (treatment == null)
            {
                return BadRequest();
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
