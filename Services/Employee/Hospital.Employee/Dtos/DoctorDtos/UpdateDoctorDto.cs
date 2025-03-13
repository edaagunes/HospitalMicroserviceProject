using Hospital.Employee.Entities;

namespace Hospital.Employee.Dtos.DoctorDtos
{
	public class UpdateDoctorDto
	{
		public int DoctorId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Title { get; set; }
		public int DepartmentId { get; set; }
	}
}
