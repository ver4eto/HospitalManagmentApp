using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment.ViewModels.Department
{
    public class DepartmentIndexViewModel
    {
        
        public Guid Id { get; set; }

        
        public string Name { get; set; } = null!;

        
        public  int DepartmentDoctors { get; set; } 

        public  int Rooms { get; set; } 

        public  int Nurses { get; set; } 
    }
}
