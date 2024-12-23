﻿using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Room;

namespace HospitalManagment.ViewModels.Room
{
    public class AddRoomViewModel
    {
        
        public Guid Id { get; set; }

        [Required(ErrorMessage =RequiredErrorMessage)]
        //range???
        public int RoomNumber { get; set; }

        [Required(ErrorMessage =RequiredErrorMessage)]
        [Range(MinBedCount, MaxBedCount)]        
        public int BedCount { get; set; }

        //[Required(ErrorMessage = RequiredErrorMessage)]
        //[Comment("Does room has free beds?")]
        //public bool HasFreeBeds { get; set; } = true;
      
        
        public Guid DepartmnetId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
