using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Context
{
	public class EmployeeContext : DbContext
	{
		public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options) 
		{
			
		}

		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Nurse> Nurses { get; set; }
		public DbSet<Department> Departments { get; set; }

	}
}
