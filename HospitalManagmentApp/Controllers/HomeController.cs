using HospitalManagment.ViewModels.Home;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.Models;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HospitalManagmentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IConfiguration configuration;
        private readonly IManagerService managerService;
        private readonly HMDbContext context;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IManagerService managerService, HMDbContext context)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.managerService = managerService;
            this.context = context;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
               
                return RedirectToAction("Welcome");
            }

            bool isPatient = User.IsInRole("Patient"); // Replace with your role-check logic
            
                ViewBag.ShowPatientBanner = isPatient;

                return View();
            
            
           
        }
        public IActionResult Welcome()
        {
           
            return View();
        }

        public  ActionResult ContactUs()
        {
            var googleMapsApiKey = configuration["GoogleApiKeys:MapsApiKey"];
            ViewBag.GoogleMapsApiKey = googleMapsApiKey;

            var managers= this.managerService.GetAllManagersASync() 
                .Result.Select(m=>new MangersViewModel
                {
                    Name=m.FullName,
                    Phone=m.PhoneNumber,
                }).ToList();

            
            return View(managers);
        }



        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Error(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                if (statusCode == 404)
                {
                    return View("NotFound"); // Return a custom 404 page
                }

                if(statusCode == 500)
                {
                    return View("Error500");
                }
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
