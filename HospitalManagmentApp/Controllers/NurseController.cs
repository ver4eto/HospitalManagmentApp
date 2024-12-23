﻿using HospitalManagment.ViewModels.Nurse;
using HospitalManagmentApp.Data;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using static HospitalManagmentApp.Common.EntityValidationConstants;

namespace HospitalManagmentApp.Controllers
{
    [Authorize(Roles = "Manager,Admin")]
    public class NurseController : Controller
    {
     
        private readonly UserManager<ApplicationUser> userManager;
        private readonly INurseService nurseService;

        public NurseController( UserManager<ApplicationUser> userManager,INurseService nurseService)
        {          
            this.userManager = userManager;
            this.nurseService = nurseService;
        }
        public async Task< IActionResult> Index(string? search, string? department)
        {
            var nurses=await nurseService.GetAllNursesAsync( search, department);
            ViewData["SearchQuery"] = search;            
            ViewData["Department"] = department;

            if (!nurses.Any())
            {
                ViewBag.Message = "No nurses available.";
                nurses= await nurseService.GetAllNursesAsync(search, department);
            }
            return View(nurses);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var nurse = await nurseService.GetAddNurseViewModelAsync();
           
            return View(nurse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddNurseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                
                return View(model);
            }

            await nurseService.AddNurseAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var nurse = await nurseService.GetEditNurseViewModelAsync(id);

            if (nurse == null)
            {
                return this.View();
            }
                       

            return View(nurse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditNurseViewModel model, Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var nurse = await nurseService.UpdateNurseAsync(id,model);
            if (nurse == false)
            {
                return BadRequest();
            }

           
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var nurse = await nurseService.GetDeleteNurseViewModelAsync(id);

            if (nurse == null)
            {
                return BadRequest();
            }


            return View(nurse);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DeleteNurseViewModel model, Guid id)
        {
            var nurse = await nurseService.DeleteNurseAsync(id);

            if (nurse == false)
            {
                return BadRequest();
            }

            
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AddNurseToDepartment(Guid depId)
        {
            
            var nurse = await nurseService.GetAddNurseToDepartmentViewModelAsync(depId);

           if(nurse == null)
            {
                return BadRequest();
            }

            return View(nurse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNurseToDepartment(AddNurseToDepartmentViewModel model, Guid depId)
        {


            var nurse = await nurseService.AddNurseToDepartmentAsync(depId, model.SelectedNurseId);

            if (nurse == false)
            {
                return BadRequest();
            }

            return RedirectToAction("Index", "Department");
        }


    }
}
