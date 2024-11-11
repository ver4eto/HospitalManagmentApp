using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly HMDbContext context;
        public RoomController(HMDbContext hMDb )
        {
            this.context = hMDb;
        }
        public async Task< IActionResult> Index()
        {
            var rooms = await context
               .Rooms
               .Where(n => n.IsDeleted == false)
               .Select(n => new IndexRoomViewModel
               {
                   Id = n.Id,
                   BedCount = n.BedCount,
                   RoomNumber = n.RoomNumber,
                   Departmnet = n.Department.Name,
                   HasFreeBeds=HasFreeBeds(n.HasFreeBeds)
               })
               .ToListAsync();

            return View(rooms);
           
        }

        private static string HasFreeBeds(bool hasFreeBeds)
        {
            if (hasFreeBeds)
            {
                return "Yes!";
            }
            return "No";
        }
    }
}
