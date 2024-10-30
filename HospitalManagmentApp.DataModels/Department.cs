using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static HospitalManagmentApp.Common.EntityValidationConstants.Department;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Department info")]
    public class Department
    {
        [Key]
        [Comment("Department unique identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(DepartmentMaxLength)]
        [Comment("Name of the Department")]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<Doctor> DepartmentDoctors { get; set; } = new HashSet<Doctor>();

        public virtual IEnumerable<Room> Rooms { get; set; } = new HashSet<Room>();

        public virtual IEnumerable<Nurse> Nurses { get; set; } = new HashSet<Nurse>();

        public virtual IEnumerable<Patient> Patients { get; set; } = new HashSet<Patient>();
    }
}