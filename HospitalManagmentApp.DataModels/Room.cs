using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static HospitalManagmentApp.Common.EntityValidationConstants.Room;

namespace HospitalManagmentApp.DataModels
{
    [Comment("Room information table")]
    public class Room
    {
        [Key]
        [Comment("Room unique identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Room Number")]
        public int RoomNumber { get; set; }

        [Required]
        [Range(MinBedCount, MaxBedCount)]
        [Comment("Room`s beds count")]
        public int BedCount { get; set; }

        [Required]
        [Comment("Does room has free beds?")]
        public bool HasFreeBeds { get; set; } = true;

        [Required]
        [Comment("Soft delete property")]
        public bool IsDeleted { get; set; } = false;


        [Comment("In which department is the room")]
        public Guid DepartmnetId { get; set; } = Guid.Empty;

        [ForeignKey(nameof(DepartmnetId))]
        public Department Department { get; set; } = null!;

        public virtual IEnumerable<Patient> Patients { get; set; } = new HashSet<Patient>();
    }
}