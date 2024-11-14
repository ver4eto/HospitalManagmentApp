﻿using HospitalManagment.ViewModels.Nurse;
using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return View(patient);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPatientViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Departments = await GetDepartments();
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
                PhoneNumber=model.PhoneNumber

            };

            await context.Patients.AddAsync(patient);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //[HttpGet]
        //public async Task<IActionResult> Edit(Guid id)
        //{
        //    var patient = await context
        //        .Patients
        //        .Where(d => d.Id == id && d.IsDeleted == false)
        //        .Include(d => d.Department)
        //        .FirstOrDefaultAsync();

        //    if (patient == null)
        //    {
        //        return this.View();
        //    }

        //    EditNurseViewModel model = new()
        //    {
        //        Id = nurse.Id,
        //        FirstName = nurse.FirstName,
        //        LastName = nurse.LastName,

        //        EmailAddress = nurse.EmailAddress,
        //        Salary = nurse.Salary,
        //        DepartmentId = nurse.Department.Id,
        //        Departments = await GetDepartments()
        //    };

        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(EditNurseViewModel model, Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var nurse = await context
        //        .Nurses
        //        .FindAsync(id);

        //    if (nurse == null)
        //    {
        //        return BadRequest();
        //    }

        //    nurse.FirstName = model.FirstName;
        //    nurse.LastName = model.LastName;
        //    nurse.Salary = model.Salary;
        //    nurse.DepartmentId = model.DepartmentId;
        //    nurse.EmailAddress = model.EmailAddress;


        //    await context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));

        //}

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
