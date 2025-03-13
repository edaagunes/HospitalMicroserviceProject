using AutoMapper;
using Hospital.Employee.Context;
using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Services.DepartmentServices
{
	public class DepartmentService : IDepartmentService
	{
		private readonly EmployeeContext _employeeContext;
		private readonly IMapper _mapper;

		public DepartmentService(EmployeeContext employeeContext, IMapper mapper)
		{
			_employeeContext = employeeContext;
			_mapper = mapper;
		}

		public async Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto)
		{
			var values=_mapper.Map<Department>(createDepartmentDto);
			await _employeeContext.Departments.AddAsync(values);
			await _employeeContext.SaveChangesAsync();
		}

		public async Task DeleteDepartmentAsync(int id)
		{
			var values=await _employeeContext.Departments.FindAsync(id);
			_employeeContext.Departments.Remove(values);
			await _employeeContext.SaveChangesAsync();
		}

		public async Task<List<ResultDepartmentDto>> GetAllDepartmentAsync()
		{
			var values = await _employeeContext.Departments.ToListAsync();
			return _mapper.Map<List<ResultDepartmentDto>>(values);
		}

		public async Task<GetByIdDepartmentDto> GetByIdDepartmentAsync(int id)
		{
			var values = await _employeeContext.Departments.FindAsync(id);
			return _mapper.Map<GetByIdDepartmentDto>(values);
		}

		public async Task UpdateDepartmentAsync(UpdateDepartmentDto updateDepartmentDto)
		{
			var values = _mapper.Map<Department>(updateDepartmentDto);
			_employeeContext.Departments.Update(values);
			await _employeeContext.SaveChangesAsync();
		}
	}
}
