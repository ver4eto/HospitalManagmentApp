using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagmentApp.DataModels;

namespace HospitalManagment.ViewModels.Room
{
    public class IndexRoomViewModel
    {
       
        public Guid Id { get; set; }

       
        public int RoomNumber { get; set; }

        
        public int BedCount { get; set; }

      
        public string HasFreeBeds { get; set; } = null!;

        public string Departmnet { get; set; } = null!;       

        

    }
}
