
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace HospitalManagmentApp.DataModels
{
    public class ApplicationUser : IdentityUser
    {


        public string UserType { get; set; } = "User";

      
        public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();
        public ICollection<Nurse> Nurses { get; set; } = new HashSet<Nurse>();
        public ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();
        public ICollection<Manager> Managers { get; set; } = new HashSet<Manager>();
    }
}
