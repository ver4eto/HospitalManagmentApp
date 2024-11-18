using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment.ViewModels.Nurse
{
    public class NurseIndexViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;


      
        public string LastName { get; set; } = null!;

        public string Department { get; set; } = null!;
    }
}
