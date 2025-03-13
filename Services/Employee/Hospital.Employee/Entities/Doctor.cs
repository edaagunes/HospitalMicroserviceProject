namespace Hospital.Employee.Entities
{
	public class Doctor
	{
		public int DoctorId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Title { get; set; }
		public int DepartmentId { get; set; }
		public Department Department  { get; set; }
	}
}
