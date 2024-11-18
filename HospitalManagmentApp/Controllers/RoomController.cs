using HospitalManagment.ViewModels.Doctor;
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
        public async Task<IActionResult> Add(Guid depId)
        {
            var dep = await context
                .Departments
                .FirstOrDefaultAsync(n => n.Id == depId);
            if(dep == null)
            {
                return BadRequest();
            }
            var room = new AddRoomViewModel();
          room.DepartmnetId = depId;
           room.DepartmentName = dep.Name;
            return View(room);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
               // model.Departments = await GetDepartments();
                return View(model);
            }

            var room = await CheckIfSameNumberRoomExistInCurrentDepartment(model.DepartmnetId, model.RoomNumber);

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
            return RedirectToAction("Index","Department");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var room = await context
                .Rooms
                .Where(d => d.Id == id && d.IsDeleted == false)
                .Include(d => d.Department)
                .FirstOrDefaultAsync();

            if (room == null)
            {               
               return BadRequest();
            }

            EditRoomViewModel model = new()
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                BedCount = room.BedCount,
                DepartmnetId=room.DepartmnetId,
                Departments = await GetDepartments()
            };

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
            var room = await context
                .Rooms
                .FindAsync(id);

            if (room == null)
            {
                return BadRequest();
            }

            var model = new DeleteRoomViewModel
            {
                Id = id,
                RoomNumber=room.RoomNumber,

            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRoomViewModel model, Guid id)
        {
            var room = await context
                .Rooms
                .Where(d => d.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (room == null)
            {
                return BadRequest();
            }

            room.IsDeleted = true;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       



        private async Task<Room?> CheckIfSameNumberRoomExistInCurrentDepartment(Guid id, int roomNumber)
        {
            return await context.Rooms
                          .Where(r => r.DepartmnetId == id && r.RoomNumber == roomNumber)
                          .FirstOrDefaultAsync();
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
