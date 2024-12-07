using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagmentApp.Controllers
{
    [Authorize(Roles ="Manager, Nurse, Doctor")]
    public class RoomController : Controller
    {
        private IRoomService roomService;
        public RoomController(IRoomService room)
        {
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
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditRoomViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }

            var roomIsUpdated = await roomService.UpdateRoomAsync(id, model);

            if (roomIsUpdated == false)
            {
                ModelState.AddModelError(string.Empty, "No such room exists in the current department.");
                return View(model);
              
            }                       

            
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
        [ValidateAntiForgeryToken]
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
