using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    return View("404");
                case 500:
                    return View("500");
                default:
                    return View("Error");
            }
        }

        [Route("Error/500")]
        public IActionResult InternalServerError()
        {
            return View("500");
        }
    }
}
