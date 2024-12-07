using HospitalManagment.ViewModels.Manager;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Views.Manager;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerService managerService;

        public ManagerController(IManagerService managerService)
        {
            this.managerService = managerService;
        }
        public IActionResult Index()
        {
            var model = new ManagerIndexViewModel
            {
                ReportButtons = new List<ReportButtonViewModel>
        {
            new ReportButtonViewModel
            {
                Title = "Departments Reports",
                ActionName = "DepartmentsReports"
            },
            new ReportButtonViewModel
            {
                Title = "Doctors Reports",
                ActionName = "DoctorsReports"
            },
            new ReportButtonViewModel
            {
                Title = "Patients Reports",
                ActionName = "PatientsReports"
            },
            new ReportButtonViewModel
            {
                Title = "General Reports",
                ActionName = "GeneralReports"
            }
        }
            };

            return View(model);
            //var result= managerService.GetIndexManagerViewModel();
            // return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> DepartmentsReports()
        {
            var model = await managerService.GetDepartmentReportsViewModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DoctorsReports()
        {
            // Fetch data
            var model = await managerService.GetDoctorsReportViewModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> PatientsReports()
        {
            var model = await managerService.GetPatientsReportViewModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GeneralReports()
        {
           var model=await managerService.GetGeneralReportViewModel();

            return View(model);
        }
        [HttpGet]
        public IActionResult EmployeeManage()
        {
            
            return View("EmployeeManage"); 
        }

        [HttpGet]
        public IActionResult FacilitiesManage()
        {
           
            return View("FacilitiesManage"); 
        }


    }
}
