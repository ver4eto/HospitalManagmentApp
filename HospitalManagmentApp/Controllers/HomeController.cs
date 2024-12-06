using HospitalManagmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalManagmentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to Login page if the user is not authenticated
                return RedirectToAction("Welcome");
            }

            // If the user is authenticated, show the homepage
            return View();
           
        }
        public IActionResult Welcome()
        {
            // A special page for unauthenticated users to choose between Login and Register
            return View();
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
