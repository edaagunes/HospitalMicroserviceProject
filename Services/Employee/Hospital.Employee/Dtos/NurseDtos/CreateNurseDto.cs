namespace Hospital.Employee.Dtos.NurseDtos
{
	public class CreateNurseDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Title { get; set; }
		public int DepartmentId { get; set; }
	}
}
