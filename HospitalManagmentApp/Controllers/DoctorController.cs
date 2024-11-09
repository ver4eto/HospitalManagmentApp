﻿using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Controllers
{
    public class DoctorController : Controller
    {
        private readonly HMDbContext context;

        public DoctorController(HMDbContext _context)
        {
            this.context = _context;
        }
        public async Task< IActionResult> Index()
        {
            var doctors=await context
                .Doctors    
                .Where(d=>d.IsDeleted==false)
                .Select(d=>new DoctorIndexViewModel()
                {
                    Id = d.Id,
                   FirstName= d.FirstName,
                  LastName=  d.LastName,
                   Specialty= d.Specialty,
                   DepartmentName= d.Department.Name,

                })
                .ToListAsync();
            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var doctor = new AddDoctorViewModel();
            doctor.Departents = await GetDepartments();
            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddDoctorViewModel model)
        {
            if (!ModelState.IsValid) 
            { 
                model.Departents=await GetDepartments();
                return View(model);
            }

            var doctor = new Doctor()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Specialty= model.Specialty,
                EmailAddress= model.EmailAddress,
                Salary= model.Salary,
                DepartmnetId=model.DepartmentId,
            };

           await context.Doctors.AddAsync(doctor);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Menage(Guid id)
        {
            var doctor  =await context
                .Doctors                
                .Where(d=>d.Id==id /*&& d.IsDeleted==false*/)  
                .Include(d=>d.Department)
                .FirstOrDefaultAsync();

            if (doctor == null)
            {
                return RedirectToAction(nameof (Index));
            }

            MenageDoctorViewModel model = new MenageDoctorViewModel()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialty = doctor.Specialty,
                EmailAddress = doctor.EmailAddress,
                Salary = doctor.Salary,
                DepartmentName = doctor.Department.Name
            };

            return View(model);
        }

        private async Task<ICollection<Department>> GetDepartments()
        {
           return await context.Departments.ToListAsync();
        }
    }
}
