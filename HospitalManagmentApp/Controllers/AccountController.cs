using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Controllers
{
    public class AccountController : Controller
    {
        
            [HttpGet]
            public IActionResult AccessDenied()
            {
                return View();
            }
        
    }
}
