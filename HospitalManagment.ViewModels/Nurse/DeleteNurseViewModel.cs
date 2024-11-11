using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment.ViewModels.Nurse
{
   public class DeleteNurseViewModel
    {
        public Guid Id { get; set; }

        public string LastName { get; set; } = null!;


        public string FirstName { get; set; } = null!;


        public string? DepartmentName { get; set; }
    }
}
