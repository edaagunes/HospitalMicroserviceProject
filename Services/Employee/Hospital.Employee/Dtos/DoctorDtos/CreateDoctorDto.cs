using Hospital.Employee.Entities;

namespace Hospital.Employee.Dtos.DoctorDtos
{
	public class CreateDoctorDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Title { get; set; }
		public int DepartmentId { get; set; }
	}
}
