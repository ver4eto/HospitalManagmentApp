﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static HospitalManagmentApp.Common.EntityValidationConstants.Manager;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Data for Hospital Manager")]
    public class Menager
    {
        [Comment("Manager unique identifier")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Manager Full Name")]
        [Required]
        [MinLength(ManagerNameMinLength)]
        [MaxLength(ManagerNameMaxLength)]
        public string FullName { get; set; } = null!;

        [Comment("Manager phone number")]
        [MinLength(PhoneMinLenght)]
        [MaxLength(PhoneMaxLenght)]
        public string PhoneNumber { get; set; }=PhoneDefaultValue;

       

    }
}
