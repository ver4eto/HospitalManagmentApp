using System.ComponentModel;

namespace HospitalManagmentApp.Views.Manager
{
    public class ManagerDepartmentReportsViewModel
    {
        public List<DepartmentStatsViewModel> Departments { get; set; } = new List<DepartmentStatsViewModel>();

        // Aggregated totals for all departments
        public int TotalDoctors { get; set; }
        public int TotalNurses { get; set; }
        public int TotalPatients { get; set; }
        public int TotalRooms { get; set; }
        public decimal TotalExpenses { get; set; }
    }

    public class DepartmentStatsViewModel
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int DoctorCount { get; set; }
        public int NurseCount { get; set; }
        public int PatientCount { get; set; }
        public int RoomCount { get; set; }
        public decimal TotalExpenses { get; set; }
    }
}
