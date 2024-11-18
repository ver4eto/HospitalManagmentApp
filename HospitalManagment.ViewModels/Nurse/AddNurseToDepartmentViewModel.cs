namespace HospitalManagment.ViewModels.Nurse
{
    public class AddNurseToDepartmentViewModel
    {
        public Guid DepartmentId { get; set; }

        public string DepartmentName { get; set; } = null!;

        public List<HospitalManagmentApp.DataModels.Nurse> Nurses { get; set; } = new List<HospitalManagmentApp.DataModels.Nurse>();

        public Guid SelectedNurseId { get; set; }


        public string LastName { get; set; } = null!;


        public string FirstName { get; set; } = null!;

    }
}
