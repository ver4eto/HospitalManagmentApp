namespace HospitalManagment.ViewModels.Manager
{
    public class ManagerDoctorsReportsViewModel
    {
        
            public int TotalDoctors { get; set; }
            public int TotalPatients { get; set; }
        public string TotalExpenses { get; set; } = null!;// Total salaries
        public string AverageSalary { get; set; } = null!;// Total salaries

    }
}
