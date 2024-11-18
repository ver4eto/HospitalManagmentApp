using HospitalManagment.ViewModels.Doctor;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace HospitalManagmentApp.Controllers
{

    public class PatientController : Controller
    {

        private readonly HMDbContext context;

        public PatientController(HMDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var patients = await context
                .Patients
                .Where(p => p.IsDeleted == false)
                .Select(p => new PatientIndexViewModel()
                {
                    Name = $"{p.FirstName} {p.LastName}",
                    EGN = p.EGN,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address,
                    Department = p.Department.Name,
                    Room = p.Room.RoomNumber,
                    HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
                    EmailAddress = p.EmailAddress,

                })
                .ToListAsync();

            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var patient = new AddPatientViewModel();
            patient.Departments = await GetDepartments();
            patient.Rooms = new List<SelectListItem>() ;
            return View(patient);
        }

        [HttpGet]
        public async Task< IActionResult> GetFreeRooms(Guid departmentId)
        {
            var freeRooms = context.Rooms
                .Where(r => r.DepartmnetId == departmentId && r.HasFreeBeds == true)
                .Select(r => new SelectListItem
                {
                    Value = r.Id.ToString(),
                    Text = r.RoomNumber.ToString(),
                }).ToList();

            return Json(freeRooms); // Return free rooms as JSON
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddPatientViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Departments = await GetDepartments();
                model.Rooms = context.Rooms
               .Where(r => r.DepartmnetId == model.DepartmentId && r.HasFreeBeds == true)
               .Select(r => new SelectListItem
               {
                   Value = r.Id.ToString(),
                   Text = r.RoomNumber.ToString()
               }).ToList();

                return View(model);
            }

            var patient = new Patient()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = model.EmailAddress,
                Address = model.Address,
                DepartmentId = model.DepartmentId,
                HasMedicalInsurance=model.HasMedicalInsurance,
                EGN=model.EGN,
                PhoneNumber=model.PhoneNumber,
                RoomId=model.RoomId,

            };
            var room = await context
                .Rooms
                .FindAsync(model.RoomId);

            if (room != null)
            {
                room.HasFreeBeds = false;
            }

            await context.Patients.AddAsync(patient);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Manage()
        {
            var patients = await context
                .Patients
                .Where(p => p.IsDeleted == false)
                .Select(p => new PatientIndexViewModel()
                {
                    Id = p.Id,
                    Name = $"{p.FirstName} {p.LastName}",
                    EGN = p.EGN,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address,
                    Department = p.Department.Name,
                    Room = p.Room.RoomNumber,
                    HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
                    EmailAddress = p.EmailAddress,

                })
                .ToListAsync();

            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> MovePatient(Guid id)
        {
            var patient=await context
                .Patients
                .Where (p => p.IsDeleted == false && p.Id==id)
                .Include(p=>p.Room)
                .Include(p=>p.Department)
                .FirstOrDefaultAsync();

            if (patient == null)
            {
                return BadRequest();
            }

            var model = new MovePatientToDepartmentViewModel()
            {
                PatientId = id,
                Name = $"{patient.FirstName} {patient.LastName}",
                EGN = patient.EGN,
                CurrentRoom = patient.Room.RoomNumber,
                CurrentDepartment = patient.Department.Name,
                CurrentDepartmentId = patient.Department.Id,
                CurrentRoomId = patient.Room.Id,
                Departments=await GetDepartments()
            };
            return View(model);
        }

        [HttpGet]
        public async Task< IActionResult> GetFreeRoomsOnMove(Guid departmentId)
        {
            var freeRooms =await context.Rooms
                .Where(r => r.DepartmnetId == departmentId && !r.Patients.Any())
                .Select(r => new { value = r.Id, text = r.RoomNumber })
                .ToListAsync();

            return Json(freeRooms);
        }

        [HttpPost]
        public async Task<IActionResult> MovePatient(MovePatientToDepartmentViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var patient =await context.Patients.FindAsync(model.PatientId);

            if (patient == null)
                return NotFound();

            patient.DepartmentId = model.NewDepartmentId;
            patient.RoomId = model.NewRoomId;
           await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> DischargePatient(Guid id)
        {
            var patient = await context
                .Patients
                .FindAsync(id);

            if (patient == null)
            {
                return BadRequest();
            }
            //TODO: check if user is in this department!!

            var model = new DischargePatientViewModel
            {
                Id = id,
                Name=$"{patient.FirstName} {patient.LastName}"
            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> DischargePatient(DischargePatientViewModel model, Guid id)
        {
            var patient = await context
                .Patients
                .Where(d => d.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (patient == null)
            {
                return BadRequest();
            }

            patient.IsDeleted = true;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private static string HasMedicalInsurance(bool hasMedicalInsurance)
        {
            if (hasMedicalInsurance==true)
            {
                return "Yes";
            }
            return "No";

        }

        private async Task<ICollection<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
