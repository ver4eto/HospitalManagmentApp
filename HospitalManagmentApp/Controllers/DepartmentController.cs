using HospitalManagment.ViewModels.Department;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace HospitalManagmentApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly HMDbContext context;
        private readonly IDepartmentService departmentService;

        public DepartmentController(HMDbContext _context,IDepartmentService department)
        {
            this.context = _context;
            this.departmentService = department;
        }
        public async Task<IActionResult> Index()
        {
            var dep = await departmentService.GetAllDepartmentsAsync();
            return View(dep);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var doctor = new AddDepartmentViewModel();           
            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddDepartmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
              
                return View(model);
            }

            var deparmentIsAdded = await departmentService.AddDepartmentAsync(model);

            if (deparmentIsAdded == false)
            {
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var department = await departmentService.GetEditDepartmentViewModelAsync(id);

            if (department == null)
            {
                return this.View();
            }

           
            return View(department);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditDepartmentViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var isDepartmentUpdated = await departmentService.UpdateDepartmentAsync(id, model);

            if (isDepartmentUpdated == false)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var department = await departmentService.GetDeleteDepartmentViewModelAsync(id);

            if (department == null)
            {
                return BadRequest();
            }            

            return View(department);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDepartmentViewModel model, Guid id)
        {
            var dep = await departmentService.DeleteDepartmentAsync(id);

            if (dep == null)
            {
                return BadRequest();
            }
            
            return RedirectToAction(nameof(Index));
        }

      
    }
}
