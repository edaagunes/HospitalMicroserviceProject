namespace Hospital.Employee.Entities
{
	public class Department
	{
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public List<Nurse> Nurses { get; set; }
		public List<Doctor> Doctors { get; set; }
	}
}
