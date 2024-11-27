using HospitalManagment.ViewModels.Doctor;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly HMDbContext context;
        private IRoomService roomService;
        public RoomController(HMDbContext hMDb,IRoomService room)
        {
            this.context = hMDb;
            this.roomService = room;
        }
        public async Task<IActionResult> Index()
        {
            var rooms = await roomService.GetAllRoomsAsync();

            return View(rooms);

        }
     
        [HttpGet]
        public async Task<IActionResult> Add(Guid depId)
        {
            var room = await roomService.GetAddRoomViewModelAsync(depId);

            if(room == null)
            {
                return BadRequest();
            }
            
            return View(room);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var success = await roomService.AddRoomAsync(model);
            if (!success)
            {
                ModelState.AddModelError(string.Empty, "This room already exists in the current department.");
                return View(model);
            }

            return RedirectToAction("Index", "Department");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await roomService.GetEditRoomViewModelAsync(id);
            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditRoomViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }

            var room = await context
                .Rooms
                .FindAsync(id);

            if (room == null)
            {
                ModelState.AddModelError(string.Empty, "No such room exists in the current department.");
                return View(model);
                //return BadRequest();
            }                       

            //if (await CheckIfSameNumberRoomExistInCurrentDepartment(model.DepartmnetId,model.RoomNumber) != null)
            //{
            //    ModelState.AddModelError(string.Empty, "This room already exists in the current department.");
            //    return View(model);
            //}

            room.RoomNumber = model.RoomNumber;
            room.BedCount = model.BedCount;            
            room.DepartmnetId = model.DepartmnetId;


            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var room = await roomService.GetDeleteRoomViewModelAsync(id);

            if (room == null)
            {
                return BadRequest();
            }

            return View(room);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRoomViewModel model, Guid id)
        {
            var success = await roomService.DeleteRoomAsync(id);
            if (!success)
            {
                return BadRequest();
            }

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

    
    }
}
