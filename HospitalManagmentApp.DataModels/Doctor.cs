﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Doctor info table")]
    public class Doctor 
    {
        [Key]
        [Comment("Doctor`s unique identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Doctor`s First Name")]
        [MaxLength(FirstNameMaxLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLenght)]
        [Comment("Doctor`s Last Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(SpecialtyMaxLenght)]
        [Comment("Doctor`s Speciality")]
        public string Specialty { get; set; } = SpecialtyDefaultValue;

        [Required]
        [EmailAddress]
        [Comment("The person email address")]
        public string EmailAddress { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Comment("Doctor`s monthly salary")]
        public decimal Salary { get; set; }

        [Required]
        [Comment("Soft delete property")]
        public bool IsDeleted { get; set; } = false;

       
        [Comment("In which department works the doctor")]
        public Guid DepartmnetId { get; set; } 

        [ForeignKey(nameof(DepartmnetId))]
        public Department Department { get; set; } =null!;

        public IEnumerable<PatientDoctor> DoctorPatients { get; set; } = new HashSet<PatientDoctor>();

        //public Guid UserId { get; set; }
        //public IdentityUser User { get; set; } = null!;
    }
}
