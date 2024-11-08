using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment.ViewModels.Patient
{
    public class PatientIndexViewModel
    {
        
        public string Name { get; set; } = null!;
                
        
        public string EGN { get; set; }=null!;
      
        public string EmailAddress { get; set; } = null!;


        public string PhoneNumber { get; set; } = null!;

       
        public string Address { get; set; } = null!;


        public string HasMedicalInsurance { get; set; } = null!;

        public string Department { get; set; }=null!;
        public int Room { get; set; }
    }
}
