using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly HMDbContext context;
        public RoomController(HMDbContext hMDb)
        {
            this.context = hMDb;
        }
        public async Task<IActionResult> Index()
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
                   HasFreeBeds = HasFreeBeds(n.HasFreeBeds)
               })
               .ToListAsync();

            return View(rooms);

        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var room = new AddRoomViewModel();
            room.Departments = await GetDepartments();
            return View(room);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Departments = await GetDepartments();
                return View(model);
            }
            var room = await context.Rooms
                .Where(r=>r.DepartmnetId==model.DepartmnetId && r.RoomNumber==model.RoomNumber)
                .FirstOrDefaultAsync();

            if (room != null)
            {
                ModelState.AddModelError(string.Empty, "This room already exists in the current department.");
                return View(model);
            }

           room = new Room()
            {
                RoomNumber = model.RoomNumber,
                BedCount = model.BedCount,
                DepartmnetId = model.DepartmnetId,
            };


            await context.Rooms.AddAsync(room);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private static string HasFreeBeds(bool hasFreeBeds)
        {
            if (hasFreeBeds)
            {
                return "Yes!";
            }
            return "No";
        }

        private async Task<ICollection<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
