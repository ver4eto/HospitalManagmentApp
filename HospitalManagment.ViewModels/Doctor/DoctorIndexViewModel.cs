﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment.ViewModels.Doctor
{
    public class DoctorIndexViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public string Specialty { get; set; } = null!;


    }
}
