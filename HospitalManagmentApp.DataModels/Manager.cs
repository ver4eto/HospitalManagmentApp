using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HospitalManagmentApp.Common.EntityValidationConstants.Manager;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Data for Hospital Manager")]
    public class Manager
    {
        [Comment("Manager unique identifier")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Manager Full Name")]
        [Required]
        [MinLength(ManagerNameMinLength)]
        [MaxLength(ManagerNameMaxLength)]
        public string FullName { get; set; } = null!;

        [Required]
        [Comment("Soft delete property")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [EmailAddress]
        [Comment("The person email address")]
        public string EmailAddress { get; set; } = null!;

        [Comment("Manager phone number")]
        [MinLength(PhoneMinLenght)]
        [MaxLength(PhoneMaxLenght)]
        public string PhoneNumber { get; set; }=PhoneDefaultValue;


        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
